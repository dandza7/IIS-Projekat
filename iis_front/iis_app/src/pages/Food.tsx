import React from "react";
import classes from "./NewFood.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";

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
                      <span>{food?.nutrientTable?.protein}</span>
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
                      <span>{food?.nutrientTable?.fat}</span>
                    </td>
                    <td>
                      <span>g</span>
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
                  {food?.allergies?.map((allergy: any, index) => (
                    <tr key={index}>
                      <td>{allergy}</td>
                    </tr>
                  ))}
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
                    <td>Potassium</td>
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
                    <td>Zink</td>
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
        </div>
      </div>
    </div>
  );
};

export default Food;
