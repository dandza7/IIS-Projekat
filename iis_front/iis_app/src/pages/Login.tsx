import React from "react";
import classes from "./Register.module.css";
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
import AuthContext from "../store/auth-context";

export const Login = () => {
  const [values, setValues] = useState({
    email: "",
    pass: "",
    showPass: false,
  });
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  const handleSubmit = (e: any) => {
    e.preventDefault();
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
          throw new Error("Wrong password or email");
        } else if (res.status == 404) {
          throw new Error("Account with this email does not exist");
        }
      })
      .then((data) => {
        const parsedJWT = parseJwt(data.token);
        authCtx.login(parsedJWT.role, parsedJWT.email, data.token);
        setTimeout(() => {
          navigateLogin(parsedJWT.role);
        }, 100);
      })
      .catch((error) => {
        alert(error);
      });
  };

  const navigateLogin = (role: string) => {
    if (role == "ADMIN") {
      navigate("/admin-dashboard", { replace: true });
    } else {
      navigate("/profile", { replace: true });
    }
  };

  function parseJwt(token: any) {
    if (!token) {
      return;
    }
    const base64Url = token.split(".")[1];
    const base64 = base64Url.replace("-", "+").replace("_", "/");
    return JSON.parse(window.atob(base64));
  }

  const handleChange = (e: any) => {
    setValues({
      ...values,
      [e.target.name]: e.target.value,
    });
  };

  const togglePasswordHide = () => {
    setValues({
      ...values,
      showPass: !values.showPass,
    });
  };

  return (
    <div className={classes.login}>
      <div className={classes.loginImage}></div>
      <div className={classes.loginFormContainer}>
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
                <form onSubmit={handleSubmit}>
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
                        type={values.showPass ? "text" : "password"}
                        fullWidth
                        label="Password"
                        placeholder="Password"
                        variant="outlined"
                        required
                        InputProps={{
                          endAdornment: (
                            <InputAdornment position="end">
                              <IconButton
                                // onClick={handlePassVisibilty}
                                aria-label="toggle password"
                                edge="end"
                                onClick={togglePasswordHide}
                              >
                                {values.showPass ? (
                                  <VisibilityIcon />
                                ) : (
                                  <VisibilityOffIcon />
                                )}
                              </IconButton>
                            </InputAdornment>
                          ),
                        }}
                        onChange={handleChange}
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
