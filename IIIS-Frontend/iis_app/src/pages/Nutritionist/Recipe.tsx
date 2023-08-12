import React from "react";
import utils from "../styles/Utils.module.css";
import AuthContext from "../../store/auth-context";
import { useEffect, useState, useRef, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { useParams } from "react-router-dom";
import classes from "./styles/Food.module.css";
import { Chart as ChartJs, ArcElement, Tooltip, Legend } from "chart.js";
import { Doughnut, Pie } from "react-chartjs-2";
ChartJs.register(ArcElement, Tooltip, Legend);

const Recipe = () => {
  const authCtx = useContext(AuthContext);
  const [recipe, setRecipe] = useState<any>({});
  let params = useParams();
  const recipeId = params.id;
  const macrosData = {
    labels: ["Carbs", "Protein", "Fat"],
    datasets: [
      {
        data: [
          recipe?.nutrientTable?.carbohydrates,
          recipe?.nutrientTable?.protein,
          recipe?.nutrientTable?.fat,
        ],
        backgroundColor: ["#42f5ce", "#12725d", "#2ac9aa"],
      },
    ],
  };
  const carbsData = {
    labels: ["Fiber", "Sugar"],
    datasets: [
      {
        data: [recipe?.nutrientTable?.fiber, recipe?.nutrientTable?.sugar],
        backgroundColor: ["#42f5ce", "#12725d"],
      },
    ],
  };
  const options = {
    plugins: { legend: { position: "right" } },
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/recipes/" + recipeId, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setRecipe(actualData);
      });
  }, []);

  return (
    <div>
      <div className={utils.whiteContainer}>
        <h2>{recipe.name}</h2>
        <br></br>
        {recipe.name !== "Water" && (
          <div className={classes.chartsContainer}>
            <div className={classes.chartContainer}>
              <Doughnut data={macrosData} options={options}></Doughnut>
            </div>
            {recipe.nutrientTable?.carbohydrates > 0 && (
              <div className={classes.chartContainer}>
                <Doughnut data={carbsData} options={options}></Doughnut>
              </div>
            )}
          </div>
        )}
        <div className={classes.ingredients}>
          <h3>Ingredients</h3>

          <table className={classes.nutrientTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Amount</th>
              </tr>
            </thead>
            <tbody>
              {recipe?.ingredients?.map((ingredient, index) => (
                <tr key={index}>
                  <td>{ingredient?.name}</td>
                  <td>{ingredient?.amount}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
        <div className={classes.nutrientContainer}>
          <div className={classes.macros}>
            <h3>General</h3>
            <table className={classes.nutrientTable}>
              <thead>
                <tr>
                  <th>Name</th>
                  <th>Amount</th>
                  <th>Unit</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Energy</td>
                  <td>
                    <span>{recipe?.calories?.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>kcal</span>
                  </td>
                </tr>
              </tbody>
            </table>
            <h3>Carbohydrates</h3>
            <table className={classes.nutrientTable}>
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
                      {recipe?.nutrientTable?.carbohydrates.toFixed(2)}
                    </span>
                  </td>
                  <td>
                    <span>g</span>
                  </td>
                </tr>
                <tr>
                  <td>Fiber</td>
                  <td>
                    <span>{recipe?.nutrientTable?.fiber.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>g</span>
                  </td>
                </tr>
                <tr>
                  <td>Sugars</td>
                  <td>
                    <span>{recipe?.nutrientTable?.sugar.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>g</span>
                  </td>
                </tr>
              </tbody>
            </table>
            <h3>Protein</h3>
            <table className={classes.nutrientTable}>
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
                    <span>{recipe?.nutrientTable?.protein.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>g</span>
                  </td>
                </tr>
              </tbody>
            </table>
            <h3>Lipids</h3>
            <table className={classes.nutrientTable}>
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
                    <span>{recipe?.nutrientTable?.fat.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>g</span>
                  </td>
                </tr>
              </tbody>
            </table>
            <h3>Allergens</h3>
            <table className={classes.nutrientTable}>
              <thead>
                <tr>
                  <th>Allergen</th>
                </tr>
              </thead>
              <tbody>
                {recipe?.allergies?.map((allergy: any, index: number) => (
                  <tr key={index}>
                    <td>{allergy}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
          <div className={classes.micros}>
            <h3>Vitamins</h3>
            <table className={classes.nutrientTable}>
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
                    <span>{recipe?.nutrientTable?.vitaminA.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mcg</span>
                  </td>
                </tr>
                <tr>
                  <td>Vitamin B1</td>
                  <td>
                    <span>{recipe?.nutrientTable?.vitaminB1.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Vitamin B2</td>
                  <td>
                    <span>{recipe?.nutrientTable?.vitaminB2.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Vitamin B3</td>
                  <td>
                    <span>{recipe?.nutrientTable?.vitaminB3.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Vitamin C</td>
                  <td>
                    <span>{recipe?.nutrientTable?.vitaminC.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Vitamin D</td>
                  <td>
                    <span>{recipe?.nutrientTable?.vitaminD.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>IU</span>
                  </td>
                </tr>
                <tr>
                  <td>Vitamin E</td>
                  <td>
                    <span>{recipe?.nutrientTable?.vitaminE.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
              </tbody>
            </table>
            <h3>Minerals</h3>
            <table className={classes.nutrientTable}>
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
                    <span>{recipe?.nutrientTable?.calcium.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Iron</td>
                  <td>
                    <span>{recipe?.nutrientTable?.iron.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Magnesium</td>
                  <td>
                    <span>{recipe?.nutrientTable?.magnesium.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Potassium</td>
                  <td>
                    <span>{recipe?.nutrientTable?.potassium.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Sodium</td>
                  <td>
                    <span>{recipe?.nutrientTable?.sodium.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
                <tr>
                  <td>Zink</td>
                  <td>
                    <span>{recipe?.nutrientTable?.zinc.toFixed(2)}</span>
                  </td>
                  <td>
                    <span>mg</span>
                  </td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Recipe;
