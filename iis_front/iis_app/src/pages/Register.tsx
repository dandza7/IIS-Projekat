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
import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import CheckBoxIcon from "@mui/icons-material/CheckBox";
import DisabledByDefaultSharpIcon from "@mui/icons-material/DisabledByDefaultSharp";
import shadows from "@mui/material/styles/shadows";

const Register = () => {
  const [values, setValues] = useState({
    email: "",
    pass: "",
    showPass: false,
  });

  const [error, setError] = useState(Error());

  const [passwordValidation, setPasswordValidation] = useState({
    len: false,
    numbers: false,
    specChar: false,
    forbiddencpecChar: false,
    upperCase: false,
    lowerCase: false,
    compare: false,
    valid: false,
    reentered: "",
  });

  const navigate = useNavigate();

  useEffect(() => {
    checkPwValidity();
  }, [values.pass]);

  useEffect(() => {
    handleComparePw();
  }, [passwordValidation.reentered, values.pass]);

  const handleSubmit = (e: any) => {
    e.preventDefault();
    fetch("http://localhost:5041/api/authentication/registration", {
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
          throw new Error("Your password must not contain £, #, “ or ”");
        }
      })
      .then((data) => {
        if (data) console.log(data);
        navigate("/login");
      })
      .catch((error) => {
        alert(error);
      });
  };

  const handleChange = (e: any) => {
    setValues((prevState) => ({
      ...prevState,
      [e.target.name]: e.target.value,
    }));
    console.log(e.target.value.length);
  };

  const checkPwValidity = () => {
    if (values.pass.length >= 8) {
      setPasswordValidation((prevState) => ({ ...prevState, len: true }));
    } else {
      setPasswordValidation((prevState) => ({ ...prevState, len: false }));
    }
    const numberRegex = /\d/;
    if (numberRegex.test(values.pass)) {
      setPasswordValidation((prevState) => ({ ...prevState, numbers: true }));
    } else {
      setPasswordValidation((prevState) => ({ ...prevState, numbers: false }));
    }
    const upperCaseRegex = /(?=.*[A-Z])/;
    if (upperCaseRegex.test(values.pass)) {
      setPasswordValidation((prevState) => ({ ...prevState, upperCase: true }));
    } else {
      setPasswordValidation((prevState) => ({
        ...prevState,
        upperCase: false,
      }));
    }
    const lowerCaseRegex = /(?=.*[a-z])/;
    if (lowerCaseRegex.test(values.pass)) {
      setPasswordValidation((prevState) => ({ ...prevState, lowerCase: true }));
    } else {
      setPasswordValidation((prevState) => ({
        ...prevState,
        lowerCase: false,
      }));
    }
    const specCharRegex = /(?=.*\W)/;
    if (specCharRegex.test(values.pass)) {
      setPasswordValidation((prevState) => ({ ...prevState, specChar: true }));
    } else {
      setPasswordValidation((prevState) => ({
        ...prevState,
        specChar: false,
      }));
    }
  };

  const togglePasswordHide = () => {
    setValues((prevState) => ({
      ...prevState,
      showPass: !prevState.showPass,
    }));
  };

  const handleReenterPassword = (e: any) => {
    setPasswordValidation((prevState) => ({
      ...prevState,
      reentered: e.target.value,
    }));
  };

  const handleComparePw = () => {
    if (
      passwordValidation.reentered == values.pass &&
      passwordValidation.lowerCase &&
      passwordValidation.upperCase &&
      passwordValidation.numbers &&
      passwordValidation.specChar
    ) {
      console.log("asd");
      setPasswordValidation((prevState) => ({ ...prevState, compare: true }));
    } else {
      setPasswordValidation((prevState) => ({ ...prevState, compare: false }));
    }
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
                      <div className={classes.valContainer}>
                        {passwordValidation.len ? (
                          <CheckBoxIcon />
                        ) : (
                          <DisabledByDefaultSharpIcon />
                        )}
                        <p>At least 8 characters</p>{" "}
                      </div>
                    </Grid>
                    <Grid item>
                      <div className={classes.valContainer}>
                        {passwordValidation.numbers ? (
                          <CheckBoxIcon />
                        ) : (
                          <DisabledByDefaultSharpIcon />
                        )}
                        <p>At least one number</p>{" "}
                      </div>
                    </Grid>
                    <Grid item>
                      <div className={classes.valContainer}>
                        {passwordValidation.upperCase ? (
                          <CheckBoxIcon />
                        ) : (
                          <DisabledByDefaultSharpIcon />
                        )}
                        <p>At least one uppercase character</p>{" "}
                      </div>
                    </Grid>
                    <Grid item>
                      <div className={classes.valContainer}>
                        {passwordValidation.lowerCase ? (
                          <CheckBoxIcon />
                        ) : (
                          <DisabledByDefaultSharpIcon />
                        )}
                        <p>At least one lowercase character</p>{" "}
                      </div>
                    </Grid>
                    <Grid item>
                      <div className={classes.valContainer}>
                        {passwordValidation.specChar ? (
                          <CheckBoxIcon />
                        ) : (
                          <DisabledByDefaultSharpIcon />
                        )}
                        <p>At least one special character</p>{" "}
                      </div>
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
                        onChange={handleReenterPassword}
                      />
                    </Grid>
                    <Grid item>
                      <p>
                        Already a member? <Link to={"/login"}>Sign in!</Link>
                      </p>
                    </Grid>
                    <Grid item>
                      <Button
                        className={classes.registerButton}
                        type="submit"
                        fullWidth
                        variant="contained"
                        disabled={!passwordValidation.compare}
                      >
                        Sign Up
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
