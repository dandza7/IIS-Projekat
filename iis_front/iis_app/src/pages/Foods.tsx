import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";
import { useNavigate } from "react-router-dom";
const foodList = [
  {
    name: "Rice",
    calories: 350,
    allergies: "Rice",
    nutrients: { a: 10, b: 30 },
  },
  {
    name: "Chicken Breast",
    calories: 350,
    allergies: "Rice",
    nutrients: { a: 10, b: 30 },
  },
  {
    name: "Apple",
    calories: 350,
    allergies: "Rice",
    nutrients: { a: 10, b: 30 },
  },
  {
    name: "Banana",
    calories: 350,
    allergies: "Rice",
    nutrients: { a: 10, b: 30 },
  },
];

const Food = () => {
  const navigate = useNavigate();

  const selectFoodHandler = (name: any) => {
    navigate("/food/" + name);
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
        <button className={classes.addButton}>Add Food</button>
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
