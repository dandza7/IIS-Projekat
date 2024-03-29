import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import classes from "./TrainingPlanRequest.module.css";
import { useNavigate } from "react-router-dom";

const TrainingPlanRequests = () => {
  const [users, setUsers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5041/api/training-plan-request/trainer", {
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
        setUsers(actualData.items);
      });
  }, []);

  const respondHandler = (request: any) => {
    localStorage.setItem("requestId", request.id);
    localStorage.setItem("sessionsPerWeek", request.sessionsPerWeek);
    localStorage.setItem("trainingGoal", request.trainingGoal);
    navigate("/new-training-plan");
  };

  return (
    <div>
      <div className={classes.trainingPlanRequest}>
        <p className={utils.title}>Training Plan Requests</p>
        {users?.length !== 0 ? (
          <div className={utils.tableContainer}>
            <table className={utils.styledTable}>
              <thead>
                <tr>
                  <th>Name</th>
                  <th>Sessions per week</th>
                  <th>Goal</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                {users?.map((request) => (
                  <tr key={request.id}>
                    <td>{request.clientFullName}</td>
                    <td>{request.sessionsPerWeek}</td>
                    <td>{request.trainingGoal}</td>
                    <td>
                      <button
                        className={utils.greenButton}
                        onClick={() => respondHandler(request)}
                      >
                        Respond
                      </button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        ) : (
          <h3>No pending requests</h3>
        )}
      </div>
    </div>
  );
};

export default TrainingPlanRequests;
