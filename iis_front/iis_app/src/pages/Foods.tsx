import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";

const Food = () => {
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

  const handleButtonClick = () => {
    navigate("/new-food");
  };

  return (
    <div className={classes.dal}>
      <div className={classes.dalTitle}>Diagnoses and allergies</div>
      <div className={classes.filters}>
        <div className={classes.categories}>
          <span>Meat</span>
          <span>Fruit</span>
          <span>Vegetables</span>
          <span>Fish</span>
          <span>Dairy</span>
        </div>
        <button className={classes.addButton} onClick={handleButtonClick}>
          Add Food
        </button>
      </div>
      <table className={classes.styledTable}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Calories (per 100 grams)</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {foodList.map((user, index) => (
            <tr key={index}>
              <td>{user.name}</td>
              <td>{user.calories}</td>
              <td>
                <button onClick={() => selectFoodHandler(user.name)}>
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

export default Food;
