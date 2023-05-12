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
  category: "Grains",
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
    zinc: 0,
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
              },
            ],
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items[0]);
        setFood(actualData.items[0]);
      });
  }, []);

  return (
    <div>
      <div>
        <div className={classes.title}>{food.name}</div>
        <div>
          <form className={classes.form}>
            <div className={classes.nutrientsContainer}>
              <div className={classes.macros}>
                <h2>
                  <label>Category: </label>
                  <span>{food.category}</span>
                </h2>
                <h2>General</h2>
                <table className={classes.styledTableNutrients}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Unit</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Energy(kcal)</td>
                      <td>
                        <span>{food.calories}</span>
                      </td>
                      <td>
                        <span>kcal</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
                <h2>Carbohydrates</h2>
                <table className={classes.styledTableNutrients}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Unit</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Total</td>
                      <td>
                        <span>{food?.nutrientTable?.carbohydrates}</span>
                      </td>
                      <td>
                        <span>g</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Fiber</td>
                      <td>
                        <span>{food?.nutrientTable?.fiber}</span>
                      </td>
                      <td>
                        <span>g</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Sugars</td>
                      <td>
                        <span>{food?.nutrientTable?.sugar}</span>
                      </td>
                      <td>
                        <span>g</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
                <h2>Protein</h2>
                <table className={classes.styledTableNutrients}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Unit</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Total Protein</td>
                      <td>
                        <span>{food?.nutrientTable?.protein}</span>
                      </td>
                      <td>
                        <span>g</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
                <h2>Lipids</h2>
                <table className={classes.styledTableNutrients}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Unit</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Total Fat</td>
                      <td>
                        <span>{food?.nutrientTable?.fat}</span>
                      </td>
                      <td>
                        <span>g</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div>
              <div className={classes.micros}>
                <h2>Vitamins</h2>
                <table className={classes.styledTableNutrients}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Unit</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Vitamin A</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminA}</span>
                      </td>
                      <td>
                        <span>IU</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Vitamin B1</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminB1}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Vitamin B2</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminB2}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Vitamin B3</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminB3}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Vitamin C</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminC}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Vitamin D</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminD}</span>
                      </td>
                      <td>
                        <span>IU</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Vitamin E</td>
                      <td>
                        <span>{food?.nutrientTable?.vitaminE}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
                <h2>Minerals</h2>
                <table className={classes.styledTableNutrients}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Unit</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>Calcium</td>
                      <td>
                        <span>{food?.nutrientTable?.calcium}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Iron</td>
                      <td>
                        <span>{food?.nutrientTable?.iron}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Magnesium</td>
                      <td>
                        <span>{food?.nutrientTable?.magnesium}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Pottasium</td>
                      <td>
                        <span>{food?.nutrientTable?.potassium}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Sodium</td>
                      <td>
                        <span>{food?.nutrientTable?.sodium}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                    <tr>
                      <td>Zinc</td>
                      <td>
                        <span>{food?.nutrientTable?.zinc}</span>
                      </td>
                      <td>
                        <span>mg</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
};

export default Food;
