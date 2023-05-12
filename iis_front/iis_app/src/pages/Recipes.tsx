import React from "react";

import classes from "./DiagnosesAndAllergies.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";
const recipes = [{ name: "Pilaf" }, { name: "Chicken risotto" }];

const Recipes = () => {
  const navigate = useNavigate();

  const [foodList, setfoodList] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/food", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        paginationQuery: {},
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setfoodList(actualData.items);
      });
  }, []);

  const selectFoodHandler = (name: any) => {
    navigate("/food/" + name);
  };

  const addFoodHandler = () => {
    event?.preventDefault();
    const foodName = nameRef.current.value;
  };

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 1000,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 4,
  };

  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  return (
    <div className={classes.dal}>
      <div className={classes.dalTitle}>Recipe list</div>
      <div className={classes.filters}>
        <div className={classes.categories}>
          <span>Breakfast</span>
          <span>Lunch</span>
          <span>Dinner</span>
          <span>Snack</span>
        </div>
        <button className={classes.addButton} onClick={handleOpen}>
          Add Recipe
        </button>
      </div>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div></div>
        </Box>
      </Modal>
      <table className={classes.styledTable}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Calories (per 100 grams)</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {recipes.map((recipe, index) => (
            <tr key={index}>
              <td>{recipe.name}</td>
              <td>
                <button
                  onClick={() => selectFoodHandler(user.name)}
                  className={classes.detailsButton}
                >
                  Details
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Recipes;
