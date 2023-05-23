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
import GroupIcon from "@mui/icons-material/Group";
import CalendarMonthIcon from "@mui/icons-material/CalendarMonth";
import MenuBookIcon from "@mui/icons-material/MenuBook";
import RestaurantIcon from "@mui/icons-material/Restaurant";
import MonitorHeartIcon from "@mui/icons-material/MonitorHeart";
export const Sidebar = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const [toggleMenu, setToggleMenu] = useState(false);

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
            to="/profile"
            style={({ isActive }) => ({
              color: isActive ? "#45FF93" : "#fff",
            })}
          >
            <div className={classes.navLink}>
              <AccountBoxIcon></AccountBoxIcon>
              {toggleMenu && <span className={classes.text}>My Profile</span>}
            </div>
          </NavLink>
        </li>
        {authCtx.role == "CUSTOMER" && (
          <li className={classes.listItem}>
            <NavLink
              to="/training-plan-request"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <AccountBoxIcon></AccountBoxIcon>
                {toggleMenu && (
                  <span className={classes.text}>Training plan request</span>
                )}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "CUSTOMER" && (
          <li className={classes.listItem}>
            <NavLink
              to="/my-training-plan"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <AccountBoxIcon></AccountBoxIcon>
                {toggleMenu && (
                  <span className={classes.text}>Training plan request</span>
                )}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "TRAINER" && (
          <li className={classes.listItem}>
            <NavLink
              to="/training-plan-requests"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <DashboardIcon></DashboardIcon>
                {toggleMenu && (
                  <span className={classes.text}>Training Plan Requests</span>
                )}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "TRAINER" && (
          <li className={classes.listItem}>
            <NavLink
              to="/training-plans"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <DashboardIcon></DashboardIcon>
                {toggleMenu && (
                  <span className={classes.text}>Training Plans</span>
                )}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "PHYSIOTHERAPIST" && (
          <li className={classes.listItem}>
            <NavLink
              to="/appointments"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <CalendarMonthIcon></CalendarMonthIcon>
                {toggleMenu && (
                  <span className={classes.text}>My Appointments</span>
                )}
              </div>
            </NavLink>
          </li>
        )}

        {authCtx.role == "NUTRITIONIST" && (
          <li className={classes.listItem}>
            <NavLink
              to="/foods"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <RestaurantIcon></RestaurantIcon>
                {toggleMenu && <span className={classes.text}>Food</span>}
              </div>
            </NavLink>
          </li>
        )}

        {authCtx.role == "NUTRITIONIST" && (
          <li className={classes.listItem}>
            <NavLink
              to="/recipes"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <MenuBookIcon></MenuBookIcon>
                {toggleMenu && <span className={classes.text}>Recipes</span>}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "NUTRITIONIST" && (
          <li className={classes.listItem}>
            <NavLink
              to="/meal-plans"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <GroupIcon></GroupIcon>
                {toggleMenu && <span className={classes.text}>Patients</span>}
              </div>
            </NavLink>
          </li>
        )}

        {authCtx.role == "PHYSIOTHERAPIST" && (
          <li className={classes.listItem}>
            <NavLink
              to="/patients"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <GroupIcon></GroupIcon>
                {toggleMenu && <span className={classes.text}>Patients</span>}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "NUTRITIONIST" && (
          <li className={classes.listItem}>
            <NavLink
              to="/diagnoses"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
              })}
            >
              <div className={classes.navLink}>
                <MonitorHeartIcon></MonitorHeartIcon>
                {toggleMenu && <span className={classes.text}>Diagnoses</span>}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "TRAINER" && (
          <li className={classes.listItem}>
            <NavLink
              to="/exercises"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
                display: "inline-block",
              })}
            >
              <div className={classes.navLink}>
                <DashboardIcon></DashboardIcon>
                {toggleMenu && <span>Exercises</span>}
              </div>
            </NavLink>
          </li>
        )}
        {authCtx.role == "ADMIN" && (
          <li className={classes.listItem}>
            <NavLink
              to="/admin-dashboard"
              style={({ isActive }) => ({
                color: isActive ? "#45FF93" : "#fff",
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
                color: isActive ? "#45FF93" : "#fff",
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
                color: isActive ? "#45FF93" : "#fff",
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
