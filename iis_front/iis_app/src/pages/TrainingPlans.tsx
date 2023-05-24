import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import classes from "./TrainingPlanRequest.module.css";
import { useNavigate } from "react-router-dom";

const TrainingPlans = () => {
  const [users, setUsers] = useState<any[]>([]);
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
        setUsers(actualData.items);
      });
  }, []);

  const respondHandler = (request: any) => {
    navigate("/training-plans/" + request.id);
  };

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
                {users.map((request) => (
                  <tr key={request.id}>
                    <td>{request.clientName}</td>
                    <td>{request.sessionsPerWeek}</td>
                    <td>{request.trainingGoal}</td>
                    <td>
                      <button
                        className={utils.greenButton}
                        onClick={() => respondHandler(request)}
                      >
                        Details
                      </button>
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

export default TrainingPlans;
