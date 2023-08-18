import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../../store/auth-context";
import classes from "./styles/TrainingPlanRequests.module.css";
import { useNavigate } from "react-router-dom";
import utils from "../styles/Utils.module.css";

const TrainingPlanRequests = () => {
  const [requests, setRequests] = useState<any[]>([]);
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
        console.log(actualData);
        setRequests(actualData.items);
      });
  }, []);

  return (
    <div className={utils.whiteContainer}>
      <h2>Training Plan Requests</h2>
      {requests?.length !== 0 ? (
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
              {requests?.map((request) => (
                <tr key={request.id}>
                  <td>{request.clientFullName}</td>
                  <td>{request.sessionsPerWeek}</td>
                  <td>{request.trainingGoal}</td>
                  <td>
                    <button
                      className={utils.greenMenuButton}
                      onClick={() => {
                        navigate("/new-training-plan/" + request.id);
                      }}
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
          <span>There is no pending requests.</span>
        </>
      )}
    </div>
  );
};

export default TrainingPlanRequests;
