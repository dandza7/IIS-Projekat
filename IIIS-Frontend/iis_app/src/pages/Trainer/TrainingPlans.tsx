import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../../store/auth-context";
import classes from "./styles/TrainingPlanRequests.module.css";
import { useNavigate } from "react-router-dom";
import utils from "../styles/Utils.module.css";

const TrainingPlans = () => {
  const [plans, setPlans] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5041/api/training-plan", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        paginationQuery: {},
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setPlans(actualData.items);
      });
  }, []);

  const respondHandler = (request: any) => {
    navigate("/training-plan/" + request.trainingPlanId);
  };

  return (
    <div className={utils.whiteContainer}>
      <h2>Training Plans</h2>
      {plans?.length !== 0 ? (
        <div className={classes.trainingPlanRequests}>
          <table className={classes.requestsTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Sessions</th>
                <th>Goal</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {plans.map((plan, index) => (
                <tr key={index}>
                  <td>{plan.clientName}</td>
                  <td>{plan.sessionsPerWeek}</td>
                  <td>{plan.trainingGoal}</td>
                  <td>
                    <button
                      className={utils.greenMenuButton}
                      onClick={() => respondHandler(plan)}
                    >
                      Details
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      ) : (
        <>
          <br></br>
          <span>There is no training plans.</span>
        </>
      )}
    </div>
  );
};

export default TrainingPlans;
