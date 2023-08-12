import React from "react";
import classes from "./styles/Foods.module.css";
import { useState, useEffect, useContext } from "react";
import AuthContext from "../../store/auth-context";
import Pagination from "../../components/Utils/Pagination";
import { useNavigate } from "react-router";

export const Recipes = () => {
  const authCtx = useContext(AuthContext);
  const [recipes, setRecipes] = useState<any[]>([]);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const pageSize = 5;
  const navigate = useNavigate();

  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  const handleOpenRecipe = (id: number) => {
    navigate(`/recipe/${id}`);
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/recipes", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: pageSize,
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
        console.log(actualData);
        setRecipes(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Recipes</h2>
        <br></br>
        <div className={classes.leagues}>
          <table className={classes.foodTable}>
            <thead>
              <tr>
                <th>Name</th>
              </tr>
            </thead>
            <tbody>
              {recipes?.map((recipe) => (
                <tr key={recipe.id} onClick={() => handleOpenRecipe(recipe.id)}>
                  <td>
                    <span>{recipe.name}</span>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
        {totalCount > pageSize && (
          <Pagination
            change={changePage}
            totalCount={totalCount}
            pageSize={pageSize}
            currentPage={selectedPage}
          ></Pagination>
        )}
      </div>
    </div>
  );
};
