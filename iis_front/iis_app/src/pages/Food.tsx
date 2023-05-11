import React from "react";
import classes from "./Food.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";

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

const Food1 = {
  name: "Rice",
  calories: 100,
  nutrientTable: {
    protein: 10,
    fat: 0,
    vitaminA: 10,
    vitaminB: 10,
    carbohydrates: 50,
  },
};

const Food = () => {
  const authCtx = useContext(AuthContext);
  const [food, setFood] = useState(null);

  let params = useParams();
  const foodName = params.name;

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/food" + foodName, {
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
        setFood(actualData.items);
      });
  }, []);

  return (
    <div>
      <div>{foodName}</div>
      <div className={classes.container}>
        <div className={classes.macro}>
          <span>Calories</span> <span>{Food1.calories}</span>
          <span>Protein</span> <span>{Food1.nutrientTable.protein}</span>
          <span>Fats</span> <span>{Food1.nutrientTable.fat}</span>
          <span>Carbohydrates</span>
          <span>{Food1.nutrientTable.carbohydrates}</span>
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
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Vitamin B</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Vitamin A</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
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
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Iron</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Magnesium</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Potassium</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Sodium</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
              <tr>
                <td>Zink</td>
                <td>{Food1.nutrientTable.vitaminA}</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

export default Food;
