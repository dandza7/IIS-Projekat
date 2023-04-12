import React from "react";
import classes from "./Sidebar.module.css";
import { NavLink } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext } from "react";
import { useNavigate } from "react-router-dom";

export const Sidebar = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const logoutHandler = () => {
    authCtx.logout();
    navigate("/", { replace: true });
  };

  return (
    <div className={classes.sidebar}>
      <div className={classes.avatar}>
        <img alt="logo"></img>
      </div>
      <ul className={classes.list}>
        {authCtx.role == "ADMIN" && (
          <li className={classes.listItem}>
            <NavLink to="/admin-dashboard">Dashboard</NavLink>
          </li>
        )}
        {authCtx.role == "ADMIN" && (
          <li className={classes.listItem}>
            <NavLink to="/users">Users</NavLink>
          </li>
        )}
        <li onClick={logoutHandler}>Logout</li>
      </ul>
    </div>
  );
};
