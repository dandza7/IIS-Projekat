import React from "react";
import classes from "./Navbar.module.css";
import CloseIcon from "@mui/icons-material/Close";
import { useNavigate } from "react-router-dom";
import { useContext } from "react";
import AuthContext from "../../store/auth-context";

const SideMenu = (props) => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);

  const openPageHandler = (url: string) => {
    props.handleOpenMenu(false);
    navigate(url);
  };

  const closeMenu = () => {
    props.handleOpenMenu(false);
  };

  return (
    <div className={classes.backGround}>
      <div className={classes.openedMenu}>
        <div className={classes.closeMenuButtonContainer}>
          <button className={classes.closeMenuButton} onClick={closeMenu}>
            <CloseIcon></CloseIcon>
          </button>
        </div>
        <div className={classes.openedMenuItems}>
          <div
            className={classes.openMenuItem}
            onClick={() => openPageHandler("/my-profile")}
          >
            <div className={classes.NavLink}>My profile</div>
          </div>
          {authCtx.role == "NUTRITIONIST" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/foods")}
            >
              <div className={classes.NavLink}>Foods</div>
            </div>
          )}
          {authCtx.role == "NUTRITIONIST" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/recipes")}
            >
              <div className={classes.NavLink}>Recipes</div>
            </div>
          )}
          {authCtx.role == "TRAINER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/exercises")}
            >
              <div className={classes.NavLink}>Exercises</div>
            </div>
          )}
          {authCtx.role == "TRAINER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/training-plan-requests")}
            >
              <div className={classes.NavLink}>Training plan requests</div>
            </div>
          )}
          {authCtx.role == "TRAINER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/training-plans")}
            >
              <div className={classes.NavLink}>Training plans</div>
            </div>
          )}
          {authCtx.role == "CUSTOMER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/training-plan-request")}
            >
              <div className={classes.NavLink}>Training plan request</div>
            </div>
          )}{" "}
          {authCtx.role == "CUSTOMER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/progress")}
            >
              <div className={classes.NavLink}>My progress</div>
            </div>
          )}
          {authCtx.role == "CUSTOMER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/my-training-plan")}
            >
              <div className={classes.NavLink}>My training plan </div>
            </div>
          )}
          {authCtx.role == "CUSTOMER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/session")}
            >
              <div className={classes.NavLink}>Today's session</div>
            </div>
          )}
          {authCtx.role == "CUSTOMER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/my-sessions")}
            >
              <div className={classes.NavLink}>My sessions</div>
            </div>
          )}
          {authCtx.role == "CUSTOMER" && (
            <div
              className={classes.openMenuItem}
              onClick={() => openPageHandler("/new-measurement")}
            >
              <div className={classes.NavLink}>Measurement</div>
            </div>
          )}
        </div>
      </div>
    </div>
  );
};

export default SideMenu;
