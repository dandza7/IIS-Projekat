import React from "react";
import classes from "./Recipes.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import Paginations from "../components/Paginations";

const Recipes = () => {
  const navigate = useNavigate();

  const [recipes, setRecipes] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);

  const changePage = (page: number) => {
    setSelectedPage(page);
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/recipes", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: 5,
        page: selectedPage,
        order: [
          {
            orderField: "ID",
            ordering: "ASC",
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        setRecipes(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  const viewRecipeDetailsHandler = (recipe: any) => {
    localStorage.setItem("recipeId", recipe.id);
    navigate("/recipes/" + recipe.name);
  };

  const addFoodHandler = () => {
    navigate("/new-recipe");
  };

  return (
    <div className={classes.dal}>
      <div className={utils.title}>Recipe list</div>
      <div className={classes.filters}>
        <div className={classes.categories}>
          <span>Breakfast</span>
          <span>Lunch</span>
          <span>Dinner</span>
          <span>Snack</span>
        </div>
        <button className={utils.blackButton} onClick={addFoodHandler}>
          Add Recipe
        </button>
      </div>
      <table className={utils.styledTable}>
        <thead>
          <tr>
            <th>Name</th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {recipes.map((recipe, index) => (
            <tr key={index}>
              <td>{recipe.name}</td>
              <td></td>
              <td></td>
              <td></td>
              <td></td>
              <td>
                <button
                  className={utils.greenButton}
                  onClick={() => viewRecipeDetailsHandler(recipe)}
                >
                  Details
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
      <Paginations change={changePage} totalCount={totalCount}></Paginations>
    </div>
  );
};

export default Recipes;
