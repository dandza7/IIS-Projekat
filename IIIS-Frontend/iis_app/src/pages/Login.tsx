import React from "react";
import { Link } from "react-router-dom";
import {
  Container,
  Button,
  Grid,
  Paper,
  TextField,
  IconButton,
  InputAdornment,
} from "@mui/material";
import VisibilityIcon from "@mui/icons-material/Visibility";
import VisibilityOffIcon from "@mui/icons-material/VisibilityOff";
import { useState, useContext } from "react";
import { useNavigate } from "react-router-dom";
import classes from "./styles/Login.module.css";
import AuthContext from "../store/auth-context";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import utils from "./styles/Utils.module.css";

const Login = () => {
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  const [values, setValues] = useState({
    email: "",
    pass: "",
  });

  const [showPass, setShowPass] = useState(false);

  const handleChange = (e: any) => {
    setValues({
      ...values,
      [e.target.name]: e.target.value,
    });
  };

  const togglePasswordHide = () => {
    setShowPass((prevState) => !prevState);
  };

  function parseJwt(token: any) {
    if (!token) {
      return;
    }
    const base64Url = token.split(".")[1];
    const base64 = base64Url.replace("-", "+").replace("_", "/");
    return JSON.parse(window.atob(base64));
  }

  const navigateLogin = (role: string) => {
    if (role == "CUSTOMER") {
      navigate("/my-profile", { replace: true });
    }
    if (role == "TRAINER") {
      navigate("/training-plans", { replace: true });
    }
  };

  const handleSubmit = (e: any) => {
    e.preventDefault();
    console.log("asd");
    fetch("http://localhost:5041/api/authentication/login", {
      method: "POST",
      body: JSON.stringify({
        email: values.email,
        password: values.pass,
      }),
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((res) => {
        if (res.ok) {
          return res.json();
        } else if (res.status == 400) {
          throw new Error("Incorrect password or email.");
        } else if (res.status == 404) {
          throw new Error("Account with this email does not exist.");
        }
      })
      .then((data) => {
        const parsedJWT = parseJwt(data.token);
        console.log(parsedJWT.id);
        authCtx.login(
          parsedJWT.role,
          parsedJWT.email,
          data.token,
          parsedJWT.id
        );
        console.log("d");
        setTimeout(() => {
          navigateLogin(parsedJWT.role);
        }, 100);
      })
      .catch((error) => {
        toast.error(error.message);
      });
  };

  return (
    <div className={classes.login}>
      <div className={classes.loginFormContainer}>
        <ToastContainer
          position="top-center"
          autoClose={1000}
          hideProgressBar
          newestOnTop={false}
          closeOnClick
          rtl={false}
          pauseOnFocusLoss
          draggable
          pauseOnHover
          theme="light"
        />
        <div>
          <Container maxWidth="sm">
            <Grid
              container
              spacing={2}
              direction="column"
              justifyContent="center"
              style={{ minHeight: "100vh" }}
            >
              <>
                <form className={classes.loginForm} onSubmit={handleSubmit}>
                  <Grid container direction="column" spacing={2}>
                    <Grid item alignSelf={"center"} marginBottom={5}>
                      <p className={classes.title}>Sign in</p>
                    </Grid>
                    <Grid item>
                      <TextField
                        name="email"
                        type="email"
                        fullWidth
                        label="Enter your email"
                        placeholder="Email Address"
                        variant="outlined"
                        required
                        onChange={handleChange}
                      />
                    </Grid>

                    <Grid item>
                      <TextField
                        name="pass"
                        type={showPass ? "text" : "password"}
                        fullWidth
                        label="Password"
                        placeholder="Password"
                        variant="outlined"
                        onChange={handleChange}
                        required
                        InputProps={{
                          endAdornment: (
                            <InputAdornment position="end">
                              <IconButton
                                aria-label="toggle password"
                                edge="end"
                                onClick={togglePasswordHide}
                              >
                                {showPass ? (
                                  <VisibilityIcon />
                                ) : (
                                  <VisibilityOffIcon />
                                )}
                              </IconButton>
                            </InputAdornment>
                          ),
                        }}
                      />
                    </Grid>
                    <Grid item>
                      <p>
                        Not a member?{" "}
                        <Link to={"/register"}>Register here!</Link>
                      </p>
                    </Grid>
                    <Grid item>
                      <Button
                        className={classes.loginButton}
                        type="submit"
                        fullWidth
                        variant="contained"
                      >
                        Sign In
                      </Button>
                    </Grid>
                  </Grid>
                </form>
              </>
            </Grid>
          </Container>
        </div>
      </div>
    </div>
  );
};

export default Login;
