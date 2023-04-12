import React from "react";
import classes from "./Sidebar.module.css";
import { NavLink } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext } from "react";
import { useNavigate } from "react-router-dom";
import AccountBoxIcon from "@mui/icons-material/AccountBox";
import DashboardIcon from "@mui/icons-material/Dashboard";
import PeopleIcon from "@mui/icons-material/People";
import LogoutIcon from "@mui/icons-material/Logout";
import HomeIcon from "@mui/icons-material/Home";

export const Sidebar = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const logoutHandler = () => {
    authCtx.logout();
    navigate("/", { replace: true });
  };

  return (
    <div className={classes.sidebar}>
      <div className={classes.avatar}></div>
      <ul className={classes.list}>
        <li className={classes.listItem}>
          <NavLink
            to="/home"
            style={({ isActive }) => ({
              color: isActive ? "#99db48" : "#fff",
            })}
          >
            <div className={classes.navLink}>
              <HomeIcon></HomeIcon>
              Home
            </div>
          </NavLink>
        </li>

        <li className={classes.listItem}>
          <NavLink
            to="/profile"
            style={({ isActive }) => ({
              color: isActive ? "#99db48" : "#fff",
            })}
          >
            <div className={classes.navLink}>
              <AccountBoxIcon></AccountBoxIcon>
              My Profile
            </div>
          </NavLink>
        </li>

        {authCtx.role == "ADMIN" && (
          <li className={classes.listItem}>
            <NavLink
              to="/admin-dashboard"
              style={({ isActive }) => ({
                color: isActive ? "#99db48" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <DashboardIcon></DashboardIcon>
                Dashboard
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "ADMIN" && (
          <li className={classes.listItem}>
            <NavLink
              to="/users"
              style={({ isActive }) => ({
                color: isActive ? "#99db48" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <PeopleIcon></PeopleIcon>
                Users
              </div>
            </NavLink>
          </li>
        )}
      </ul>
      <button onClick={logoutHandler} className={classes.logoutButton}>
        <LogoutIcon fontSize="large"></LogoutIcon>
      </button>
    </div>
  );
};
