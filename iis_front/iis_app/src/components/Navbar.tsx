import React from "react";
import { NavLink } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext } from "react";
import classes from "./Navbar.module.css";

const Navbar = () => {
  const authCtx = useContext(AuthContext);
  const logoutHandler = () => {
    authCtx.logout();
  };

  return (
    <nav className={authCtx.isLoggedIn ? classes.sidebar : classes.navbar}>
      <div className={classes.logo}>
        <img
          alt="logo"
          src="https://images.squarespace-cdn.com/content/v1/5bfc0cee9d5abb437583b9fd/1581440140166-JEAP1CNU81DHQ02RJNRA/BALANCE_LOGO-UPDATE.png?format=1500w"
          width={100}
          height={80}
        ></img>
      </div>
      <ul className={classes.list}>
        <li className={classes.navlistItem}>
          <NavLink to="/">Home</NavLink>
        </li>

        {!authCtx.isLoggedIn && (
          <li className={classes.navlistItem}>
            <NavLink to="/packages-preview">Packages</NavLink>
          </li>
        )}
        <li className={classes.navlistItem}>
          <NavLink to="/login">
            <button className={classes.loginButton}>Login</button>
          </NavLink>
        </li>
        {!authCtx.isLoggedIn && (
          <li className={classes.navlistItem}>
            <NavLink to="/register">
              <button className={classes.registerButton}>Register</button>
            </NavLink>
          </li>
        )}
        {authCtx.isLoggedIn && <li onClick={logoutHandler}>Logout</li>}
      </ul>
    </nav>
  );
};

export default Navbar;
