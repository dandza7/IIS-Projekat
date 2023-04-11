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
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import CheckBoxIcon from "@mui/icons-material/CheckBox";
import DisabledByDefaultSharpIcon from "@mui/icons-material/DisabledByDefaultSharp";

const Register = () => {
  const [values, setValues] = useState({
    email: "",
    pass: "",
    showPass: false,
  });

  const [passwordValidation, setPasswordValidation] = useState({
    len: false,
  });

  const navigate = useNavigate();

  const handleSubmit = (e: any) => {
    e.preventDefault();
    console.log(values);
  };

  const handleChange = (e: any) => {
    console.log(e.target.value.length);
    if (e.target.value.length > 8) {
      setPasswordValidation({
        ...values,
        len: true,
      });
    } else {
      setPasswordValidation({
        ...values,
        len: false,
      });
    }

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
      <div className={classes.registerImage}></div>
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
                      <p className={classes.title}>Register</p>
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
                      <p>At least 8 characters</p>{" "}
                      {passwordValidation.len ? (
                        <CheckBoxIcon />
                      ) : (
                        <DisabledByDefaultSharpIcon />
                      )}
                    </Grid>
                    <Grid item>
                      <TextField
                        name="reepass"
                        type={values.showPass ? "text" : "password"}
                        fullWidth
                        label="Reenter Password"
                        placeholder="Reenter Password"
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
                      />
                    </Grid>
                    <Grid item>
                      <p>
                        Already a member? <Link to={"/login"}>Sign in!</Link>
                      </p>
                    </Grid>
                    <Grid item>
                      <Button
                        className={classes.loginButton}
                        type="submit"
                        fullWidth
                        variant="contained"
                        disabled={!passwordValidation.len}
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

export default Register;
