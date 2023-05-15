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
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/training-plan-request", {
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
        setUsers(actualData.items);
      });
  }, []);

  return (
    <div>
      {" "}
      <div className={classes.trainingPlanRequest}>
        <p className={utils.title}>Training Plan Requests</p>
        {users && (
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
                {users.map((user) => (
                  <tr key={user.id}>
                    <td>{user.clientFullName}</td>
                    <td>{user.sessionsPerWeek}</td>
                    <td>{user.trainingGoal}</td>
                    <td>
                      <button className={utils.greenButton}>Respond</button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        )}
      </div>
    </div>
  );
};

export default TrainingPlanRequests;
