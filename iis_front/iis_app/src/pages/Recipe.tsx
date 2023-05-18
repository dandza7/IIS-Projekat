import React from "react";
import classes from "./NewFood.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";

const Recipe = () => {
  const authCtx = useContext(AuthContext);
  const [recipe, setRecipe] = useState({});

  useEffect(() => {
    fetch("http://localhost:5041/recipes/" + 1, {
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

  return <div className={classes.newRecipe}></div>;
};

export default Recipe;
