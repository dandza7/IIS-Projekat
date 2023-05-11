import React from "react";
import classes from "./NewFood.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
const NewFood = () => {
  const navigate = useNavigate();
  const nameRef = useRef(null);
  const authCtx = useContext(AuthContext);

  const addFoodHandler = () => {
    event?.preventDefault();
    const foodName = nameRef.current.value;

    fetch("http://localhost:5041/api/food/new", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        name: foodName,
        category: "Grains",
        calories: 350,
        allergyIds: [],
        nutrientTable: {
          protein: 10,
          fat: 0,
          carbohydrates: 80,
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
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("Food has been successfully added!");
      });
  };

  return (
    <div>
      <div>
        <form className={classes.form} onSubmit={addFoodHandler}>
          <div className={classes.container}>
            <div>
              <label>Name</label>
              <input type="text" ref={nameRef}></input>
            </div>
            <div>
              <label>Category</label>
              <select>
                <option>Grains</option>
                <option>Meat</option>
                <option>Fish</option>
              </select>
            </div>
            <div>
              <label>Energy (kcal)</label>
              <input></input>
            </div>
            <div>
              <label>Protein (grams)</label>
              <input></input>
            </div>
            <div>
              <label>Carbohydrates (grams)</label>
              <input></input>
            </div>
            <div>
              <label>Fiber (grams)</label>
              <input></input>
            </div>
            <div>
              <label>Sugars (grams)</label>
              <input></input>
            </div>
            <div>
              <label>Fat (grams)</label>
              <input></input>
            </div>
          </div>
          <div className={classes.micros}>
            <div>
              <label>Vitamin A (IU)</label>
              <input></input>
            </div>
            <div>
              <label>Vitamin B1 (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Vitamin B2 (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Vitamin B3 (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Vitamin C (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Vitamin D (IU)</label>
              <input></input>
            </div>
            <div>
              <label>Vitamin E (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Calcium (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Iron (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Magnesium (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Potassium (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Sodium (miligrams)</label>
              <input></input>
            </div>
            <div>
              <label>Zink (miligrams)</label>
              <input></input>
            </div>
          </div>
          <button type="submit">Add Food</button>
        </form>
      </div>
    </div>
  );
};

export default NewFood;
