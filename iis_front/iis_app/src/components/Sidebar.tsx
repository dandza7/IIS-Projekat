import React from "react";
import classes from "./Sidebar.module.css";
import { NavLink } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext, useState } from "react";
import { useNavigate } from "react-router-dom";
import AccountBoxIcon from "@mui/icons-material/AccountBox";
import DashboardIcon from "@mui/icons-material/Dashboard";
import PeopleIcon from "@mui/icons-material/People";
import LogoutIcon from "@mui/icons-material/Logout";
import HomeIcon from "@mui/icons-material/Home";
import MenuSharpIcon from "@mui/icons-material/MenuSharp";

export const Sidebar = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const [toggleMenu, setToggleMenu] = useState(true);

  const logoutHandler = () => {
    authCtx.logout();
    navigate("/", { replace: true });
  };

  const toggleMenuHandler = () => {
    setToggleMenu(!toggleMenu);
  };

  return (
    <div className={classes.sidebar}>
      <div className={classes.menu}>
        <button className={classes.menuButton} onClick={toggleMenuHandler}>
          <MenuSharpIcon
            className={classes.menuIcon}
            fontSize="medium"
          ></MenuSharpIcon>
        </button>
      </div>
      {toggleMenu && <div className={classes.avatar}></div>}
      {<div className={classes.avatarClosed}></div>}
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
              {toggleMenu && <span>Home</span>}
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
              {toggleMenu && <span>My Profile</span>}
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
                {toggleMenu && <span>Dashboard</span>}
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
                {toggleMenu && <span>Users</span>}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "CUSTOMER" && (
          <li className={classes.listItem}>
            <NavLink
              to=""
              style={({ isActive }) => ({
                color: isActive ? "#99db48" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <DashboardIcon></DashboardIcon>
                {toggleMenu && <span>Reservations</span>}
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
