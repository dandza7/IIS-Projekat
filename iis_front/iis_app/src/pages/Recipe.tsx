import React from "react";
import classes from "./Recipes.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";
import { Chart as ChartJs, ArcElement, Tooltip, Legend } from "chart.js";
import { Doughnut, Pie } from "react-chartjs-2";
ChartJs.register(ArcElement, Tooltip, Legend);

const Recipe = () => {
  const authCtx = useContext(AuthContext);
  const [recipe, setRecipe] = useState({});
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
    const recipeId = localStorage.getItem("recipeId");
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
    <div className={classes.newRecipe}>
      <div className={utils.title}>{recipe.name}</div>
      <div>
        <form className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.chartsContainer}>
                <span className={classes.smallTitle}>Nutrients </span>
                <div className={classes.chartsContainer_}>
                  <div className={classes.chartContainer}>
                    <Doughnut data={macrosData} options={options}></Doughnut>
                  </div>
                  <div className={classes.chartContainer}>
                    <Doughnut data={carbsData} options={options}></Doughnut>
                  </div>
                </div>
              </div>
              <span className={classes.smallTitle}>Ingredients</span>
              <table className={utils.styledTableDark}>
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
              <div className={classes.nutrientsContainer}>
                <div className={classes.nutrientContainer}>
                  <span className={classes.smallTitle}>General</span>
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
                          <span>{recipe?.calories}</span>
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
                          <span>{recipe?.nutrientTable?.carbohydrates}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Fiber</td>
                        <td>
                          <span>{recipe?.nutrientTable?.fiber}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Sugars</td>
                        <td>
                          <span>{recipe?.nutrientTable?.sugar}</span>
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
                          <span>{recipe?.nutrientTable?.protein}</span>
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
                          <span>{recipe?.nutrientTable?.fat}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </div>
                <div className={classes.nutrientContainer}>
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
                          <span>{recipe?.nutrientTable?.vitaminA}</span>
                        </td>
                        <td>
                          <span>mcg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin B1</td>
                        <td>
                          <span>{recipe?.nutrientTable?.vitaminB1}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin B2</td>
                        <td>
                          <span>{recipe?.nutrientTable?.vitaminB2}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin B3</td>
                        <td>
                          <span>{recipe?.nutrientTable?.vitaminB3}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin C</td>
                        <td>
                          <span>{recipe?.nutrientTable?.vitaminC}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin D</td>
                        <td>
                          <span>{recipe?.nutrientTable?.vitaminD}</span>
                        </td>
                        <td>
                          <span>IU</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin E</td>
                        <td>
                          <span>{recipe?.nutrientTable?.vitaminE}</span>
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
                          <span>{recipe?.nutrientTable?.calcium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Iron</td>
                        <td>
                          <span>{recipe?.nutrientTable?.iron}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Magnesium</td>
                        <td>
                          <span>{recipe?.nutrientTable?.magnesium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Potassium</td>
                        <td>
                          <span>{recipe?.nutrientTable?.potassium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Sodium</td>
                        <td>
                          <span>{recipe?.nutrientTable?.sodium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Zinc</td>
                        <td>
                          <span>{recipe?.nutrientTable?.zinc}</span>
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
        </form>
      </div>
    </div>
  );
};

export default Recipe;
