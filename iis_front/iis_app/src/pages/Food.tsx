import React from "react";
import classes from "./NewFood.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";
import { Chart as ChartJs, ArcElement, Tooltip, Legend } from "chart.js";
import { Doughnut, Pie } from "react-chartjs-2";
ChartJs.register(ArcElement, Tooltip, Legend);

const Food = () => {
  const authCtx = useContext(AuthContext);
  const [food, setFood] = useState<any>({});

  let params = useParams();
  const foodName = params.name;
  const macrosData = {
    labels: ["Carbs", "Protein", "Fat"],
    datasets: [
      {
        data: [
          food?.nutrientTable?.carbohydrates,
          food?.nutrientTable?.protein,
          food?.nutrientTable?.fat,
        ],
        backgroundColor: ["#42f5ce", "#12725d", "#2ac9aa"],
      },
    ],
  };
  const carbsData = {
    labels: ["Fiber", "Sugar"],
    datasets: [
      {
        data: [food?.nutrientTable?.fiber, food?.nutrientTable?.sugar],
        backgroundColor: ["#42f5ce", "#12725d"],
      },
    ],
  };
  const options = {
    plugins: { legend: { position: "right" } },
  };
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
      <div className={utils.title}>{food.name}</div>
      <div>
        <div className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.macros}>
              <div className={utils.span}>
                <label className={classes.smallTitle}>Category: </label>
                <span className={classes.smallTitle}>{food.category}</span>
              </div>
              <span className={classes.smallTitle}>General</span>
              {food.name !== "Water" && (
                <div className={classes.chartsContainer}>
                  <div className={classes.chartsContainer_}>
                    <div className={classes.chartContainer}>
                      <Doughnut data={macrosData} options={options}></Doughnut>
                    </div>
                  </div>
                </div>
              )}
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
                      <span>{(food.calories * 100).toFixed(2)}</span>
                    </td>
                    <td>
                      <span>kcal</span>
                    </td>
                  </tr>
                </tbody>
              </table>
              <span className={classes.smallTitle}>Carbohydrates</span>
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
                      <span>
                        {(food?.nutrientTable?.carbohydrates * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>g</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Fiber</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.fiber * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>g</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Sugars</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.sugar * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>g</span>
                    </td>
                  </tr>
                </tbody>
              </table>
              <span className={classes.smallTitle}>Protein</span>
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
                      <span>
                        {(food?.nutrientTable?.protein * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>g</span>
                    </td>
                  </tr>
                </tbody>
              </table>
              <span className={classes.smallTitle}>Lipids</span>
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
                      <span>{(food?.nutrientTable?.fat * 100).toFixed(2)}</span>
                    </td>
                    <td>
                      <span>g</span>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>
            <div className={classes.micros}>
              <span className={classes.smallTitle}>Vitamins</span>
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
                      <span>
                        {(food?.nutrientTable?.vitaminA * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mcg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Vitamin B1</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.vitaminB1 * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Vitamin B2</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.vitaminB2 * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Vitamin B3</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.vitaminB3 * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Vitamin C</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.vitaminC * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Vitamin D</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.vitaminD * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>IU</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Vitamin E</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.vitaminE * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                </tbody>
              </table>
              <span className={classes.smallTitle}>Minerals</span>
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
                      <span>
                        {(food?.nutrientTable?.calcium * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Iron</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.iron * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Magnesium</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.magnesium * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Potassium</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.potassium * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Sodium</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.sodium * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                  <tr>
                    <td>Zink</td>
                    <td>
                      <span>
                        {(food?.nutrientTable?.zinc * 100).toFixed(2)}
                      </span>
                    </td>
                    <td>
                      <span>mg</span>
                    </td>
                  </tr>
                </tbody>
              </table>
              <span className={classes.smallTitle}>Allergens</span>
              <table className={classes.styledTableNutrients}>
                <thead>
                  <tr>
                    <th>Allergen</th>
                  </tr>
                </thead>
                <tbody>
                  {food?.allergies?.map((allergy: any, index: number) => (
                    <tr key={index}>
                      <td>{allergy}</td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Food;
