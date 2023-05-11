import React from "react";
import classes from "./Food.module.css";

const Food1 = {
  name: "Rice",
  calories: 100,
  Nutrients: {
    Protein: 10,
    Fat: 0,
    VitaminA: 10,
    VitaminB: 10,
    Carbohydrates: 50,
  },
};

const micros = [
  "VitaminA",
  "VitaminB1",
  "VitaminB2",
  "VitaminB3",
  "VitaminC",
  "VitaminD",
  "VitaminE",
  "Magnesium",
];
const macros = ["Protein", "Protein", "Protein", "Protein", "Protein"];
const Food = () => {
  const params = new URLSearchParams(window.location.pathname);

  return (
    <div>
      <div>{Food1.name}</div>
      <div className={classes.container}>
        <div className={classes.macro}>
          <span>Calories</span> <span>{Food1.calories}</span>
          <span>Protein</span> <span>{Food1.Nutrients.Protein}</span>
          <span>Fats</span> <span>{Food1.Nutrients.Fat}</span>
          <span>Carbohydrates</span>
          <span>{Food1.Nutrients.Carbohydrates}</span>
        </div>
        <div className={classes.micro}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Vitamin</th>
                <th>Value</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>Vitamin A</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Vitamin B</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Vitamin A</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
            </tbody>
          </table>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Mineral</th>
                <th>Value</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>Calcium</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Iron</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Magnesium</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Potassium</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Sodium</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
              <tr>
                <td>Zink</td>
                <td>{Food1.Nutrients.VitaminA}</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default Food;
