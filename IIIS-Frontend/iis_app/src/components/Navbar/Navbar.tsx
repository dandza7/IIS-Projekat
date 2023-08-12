import React from "react";
import { useState, useContext, useEffect } from "react";
import { NavLink } from "react-router-dom";
import MenuIcon from "@mui/icons-material/Menu";
import classes from "./Navbar.module.css";
import PersonIcon from "@mui/icons-material/Person";
import SideMenu from "./SideMenu";
import NotificationsIcon from "@mui/icons-material/Notifications";
import AuthContext from "../../store/auth-context";

export const Navbar = () => {
  const [openMenu, setOpenMenu] = useState(false);
  const authCtx = useContext(AuthContext);
  useEffect(() => {
    authCtx.updateNotifications();
  });

  const handleOpenMenu = (value: boolean) => {
    setOpenMenu(value);
  };

  return (
    <>
      <div className={classes.nav}>
        <div className={classes.navbar}>
          <div className={classes.navbarItems}>
            <div
              className={classes.navbarItemMenu}
              onClick={() => handleOpenMenu(true)}
            >
              <MenuIcon></MenuIcon>
            </div>
            <div className={classes.navbarRightContainer}>
              <div className={classes.loginButton}>
                <NavLink to="/notifications" className={classes.NavLink}>
                  <NotificationsIcon
                    className={classes.icon}
                  ></NotificationsIcon>
                  {authCtx.notificationCount > 0 && (
                    <div className={classes.notificationCount}>
                      {authCtx.notificationCount}
                    </div>
                  )}
                </NavLink>
              </div>
              <div className={classes.loginButton}>
                <NavLink to="/login" className={classes.NavLink}>
                  <PersonIcon className={classes.icon}></PersonIcon>
                </NavLink>
              </div>
            </div>
          </div>
        </div>
      </div>
      {openMenu && <SideMenu handleOpenMenu={handleOpenMenu}></SideMenu>}
    </>
  );
};
