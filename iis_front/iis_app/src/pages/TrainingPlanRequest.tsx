import React from "react";
import classes from "./TrainingPlanRequest.module.css";
import { useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";

const TrainingPlanRequest = () => {
  const goals = ["Bulk", "Cut", "Recomp", "Endurance"];
  const numberOfSessions = [2, 3, 4, 5, 6];
  const goalRef = useRef(null);
  const numberRef = useRef(null);
  const authCtx = useContext(AuthContext);

  const sumbitFormHandler = () => {
    event?.preventDefault();
    const selectedGoal = goalRef.current.value;
    const selectedNumber = numberRef.current.value;

    fetch("http://localhost:5041/api/training-plan-request/create", {
      method: "POST",
      body: JSON.stringify({
        sessionsPerWeek: selectedNumber,
        trainingGoal: selectedGoal,
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        if (res.ok) {
          console.log(res);
          return res;
        }
      })
      .then((data) => {
        alert("You have succesfully created training plan request!");
      });
  };

  return (
    <div className={classes.trainingPlanRequest}>
      <div className={classes.trainingPlanTitle}>
        Create Training Plan Request
      </div>
      <form className={classes.planRequestForm} onSubmit={sumbitFormHandler}>
        <div>
          <label>Select your training goal: </label>
          <select ref={goalRef}>
            {goals.map((goal, index) => {
              return <option key={index}>{goal}</option>;
            })}
          </select>
        </div>
        <div>
          <label>Select training intensity: </label>
          <select ref={numberRef}>
            {numberOfSessions.map((goal, index) => {
              return <option key={index}>{goal}</option>;
            })}
          </select>
        </div>
        <button className={classes.sendButton} type="submit">
          Submit
        </button>
      </form>
    </div>
  );
};

export default TrainingPlanRequest;
