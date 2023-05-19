import React from "react";
import classes from "./MyTrainingPlan.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";
const MyExercisePlan = () => {
  const authCtx = useContext(AuthContext);
  type trainingSession = {
    name: string;
    exerciseInfo: [
      {
        exerciseName: string;
        repetitionRange: string;
        numberOfSets: number;
      }
    ];
  };

  const [plan, setPlan] = useState<{
    id: number;
    clientName: string;
    trainingGoal: string;
    sessionsPerWeek: string;
    trainingSessions: [
      {
        name: string;
        exerciseInfo: [
          {
            exerciseName: string;
            repetitionRange: string;
            numberOfSets: number;
          }
        ];
      }
    ];
  }>();

  useEffect(() => {
    console.log(authCtx.email);

    console.log(authCtx.token);
    fetch(
      "http://localhost:5041/api/training-plan/trainingPlanForClient?email=" +
        authCtx.email,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + authCtx.token,
        },
      }
    )
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setPlan(actualData);
      });
  }, []);
  return (
    <div className={classes.newRecipe}>
      <div className={utils.title}>My training plan</div>
      <div>
        <div className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.nameContainer}></div>
              <div className={utils.span}>
                <label>Training goal:</label>
                <span>{plan?.trainingGoal}</span>
              </div>
              <div className={utils.span}>
                <label>Sessions per week:</label>
                <span>{plan?.sessionsPerWeek}</span>
              </div>
              <div>
                {plan?.trainingSessions.map(
                  (session: trainingSession, index) => (
                    <div className={classes.tablesContainer}>
                      <div className={utils.span}>
                        <span>Session name: </span>
                        <span>{session.name}</span>
                      </div>
                      <table className={classes.styledTableFoods} key={index}>
                        <thead>
                          <tr>
                            <th>Name</th>
                            <th>Number of sets</th>
                            <th>Repetition range</th>
                          </tr>
                        </thead>
                        <tbody>
                          {session.exerciseInfo.map((exercise, index) => (
                            <tr key={index}>
                              <td>{exercise?.exerciseName}</td>
                              <td>{exercise?.numberOfSets}</td>
                              <td>{exercise?.repetitionRange}</td>
                            </tr>
                          ))}
                        </tbody>
                      </table>
                    </div>
                  )
                )}
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};
export default MyExercisePlan;
