import React from "react";
import classes from "./NewTrainingPlan.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";
import AddIcon from "@mui/icons-material/Add";
export const TrainingPlan = () => {
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

  let params = useParams();
  const id = params.id;

  useEffect(() => {
    fetch(
      "http://localhost:5041/api/training-plan/detailedTrainingPlan/" + id,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + authCtx.token,
        },
        body: JSON.stringify({
          paginationQuery: {},
        }),
      }
    )
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setPlan(actualData);
      });
  }, []);

  const updateSessionHandler = (name: string) => {
    console.log(name);
  };

  return (
    <div className={classes.newRecipe}>
      <div className={utils.title}>Update training plan</div>
      <div>
        <div className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.nameContainer}>
                <div className={utils.span}>
                  <label>Name:</label>
                  <span>{plan?.clientName}</span>
                </div>
              </div>
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
                    <div key={index}>
                      <div>
                        <div className={classes.filters}>
                          <span>{session.name}</span>
                          <button
                            className={utils.greenButton}
                            onClick={() => updateSessionHandler(session.name)}
                          >
                            Update
                          </button>
                        </div>
                        <table className={classes.styledTableFoods} key={index}>
                          <thead>
                            <tr>
                              <th>Name</th>
                              <th>Number of sets</th>
                              <th>Repetition range</th>
                              <th>
                                <AddIcon fontSize="small"></AddIcon>
                              </th>
                            </tr>
                          </thead>
                          <tbody>
                            {session.exerciseInfo.map((exercise, index) => (
                              <tr key={index}>
                                <td>{exercise?.exerciseName}</td>
                                <td>{exercise?.numberOfSets}</td>
                                <td>{exercise?.repetitionRange}</td>
                                <td>
                                  <button className={classes.deleteButton}>
                                    X
                                  </button>
                                </td>
                              </tr>
                            ))}
                          </tbody>
                        </table>
                      </div>
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
