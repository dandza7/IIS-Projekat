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

const food1 = {
  name: "Rice",
  calories: 350,
  allergies: [],
  nutrientTable: {
    protein: 10,
    fat: 0,
    carbohydrates: 70,
    fiber: 0,
    sugar: 0,
    vitaminA: 0,
    vitaminB1: 0,
    vitaminB2: 0,
    vitaminB3: 0,
    vitaminC: 0,
    vitaminD: 0,
    vitaminE: 0,
    calcium: 0,
    iron: 0,
    magnesium: 0,
    potassium: 0,
    sodium: 0,
    zinc: 0
  },
};

const Food = () => {
  const authCtx = useContext(AuthContext);
  const [food, setFood] = useState<any>({});

  let params = useParams();
  const foodName = params.name;

  useEffect(() => {
    console.log(foodName);
    fetch("http://localhost:5041/api/food", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
          pageSize: 0,
          page: 0,
          order: [
            {
              orderField: "ID",
              ordering: "ASC",
            },
          ],
          filters: [
            {
              property: "name",
              connecting: 0,
              filterValues: [
                {
                  value: foodName,
                  operation: 0,
                }
              ]
            }
          ]
        
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items[0]);
        setFood(actualData.items[0]);
      });
  }, []);

  return <div>
  <div className={classes.title}>{food.name}</div>
  <div className={classes.container}>
    <div className={classes.macro}>
      <span>Calories</span> <span>{food.calories}</span>
      <span>Protein</span> <span>{food1.nutrientTable.protein}</span>
      <span>Fats</span> <span>{food1.nutrientTable.fat}</span>
      <span>Carbohydrates</span>
      <span>{food1.nutrientTable.carbohydrates}</span>
      <span>Fiber</span>
      <span>{food1.nutrientTable.fiber}</span>
      <span>Sugar</span>
      <span>{food1.nutrientTable.sugar}</span>
    </div>
    <div className={classes.micro}>
      <table className={classes.styledTableNutrients}>
        <thead>
          <tr>
            <th>Vitamin</th>
            <th>Value</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>Vitamin A</td>
            <td>{food1.nutrientTable.vitaminA}</td>
          </tr>
          <tr>
            <td>Vitamin B1</td>
            <td>{food1.nutrientTable.vitaminB1}</td>
          </tr>
          <tr>
            <td>Vitamin B2</td>
            <td>{food1.nutrientTable.vitaminB2}</td>
          </tr>
          <tr>
            <td>Vitamin B3</td>
            <td>{food1.nutrientTable.vitaminB3}</td>
          </tr>
          <tr>
            <td>Vitamin C</td>
            <td>{food1.nutrientTable.vitaminC}</td>
          </tr>
          <tr>
            <td>Vitamin D</td>
            <td>{food1.nutrientTable.vitaminD}</td>
          </tr>
          <tr>
            <td>Vitamin E</td>
            <td>{food1.nutrientTable.vitaminE}</td>
          </tr>
        </tbody>
      </table>
      <br></br>
      <table className={classes.styledTableNutrients}>
        <thead>
          <tr>
            <th>Mineral</th>
            <th>Value</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>Calcium</td>
            <td>{food1.nutrientTable.calcium}</td>
          </tr>
          <tr>
            <td>Iron</td>
            <td>{food1.nutrientTable.iron}</td>
          </tr>
          <tr>
            <td>Magnesium</td>
            <td>{food1.nutrientTable.magnesium}</td>
          </tr>
          <tr>
            <td>Potassium</td>
            <td>{food1.nutrientTable.potassium}</td>
          </tr>
          <tr>
            <td>Sodium</td>
            <td>{food1.nutrientTable.sodium}</td>
          </tr>
          <tr>
            <td>Zink</td>
            <td>{food1.nutrientTable.zinc}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</div>;
};

export default Food;
