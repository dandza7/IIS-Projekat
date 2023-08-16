import React from "react";
import classes from "./Navbar.module.css";
import CloseIcon from "@mui/icons-material/Close";
import { useNavigate } from "react-router-dom";

const SideMenu = (props) => {
  const navigate = useNavigate();

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
            onClick={() => openPageHandler("/foods")}
          >
            <div className={classes.NavLink}>Foods</div>
          </div>
          <div
            className={classes.openMenuItem}
            onClick={() => openPageHandler("/recipes")}
          >
            <div className={classes.NavLink}>Recipes</div>
          </div>
          <div
            className={classes.openMenuItem}
            onClick={() => openPageHandler("/exercises")}
          >
            <div className={classes.NavLink}>Exercises</div>
          </div>
          <div
            className={classes.openMenuItem}
            onClick={() => openPageHandler("/training-plan-requests")}
          >
            <div className={classes.NavLink}>Training plan requests</div>
          </div>
          <div
            className={classes.openMenuItem}
            onClick={() => openPageHandler("/training-plans")}
          >
            <div className={classes.NavLink}>Training plans</div>
          </div>
          <div
            className={classes.openMenuItem}
            onClick={() => openPageHandler("/training-plan-request")}
          >
            <div className={classes.NavLink}>Training Plan Request</div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default SideMenu;
