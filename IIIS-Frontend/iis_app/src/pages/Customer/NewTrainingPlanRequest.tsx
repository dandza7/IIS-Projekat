import React from "react";
import { useNavigate } from "react-router-dom";
import { useState, useRef, useContext } from "react";
import AuthContext from "../../store/auth-context";
import classes from "./styles/NewTrainingPlanRequest.module.css";
import utils from "../styles/Utils.module.css";
import { act } from "react-dom/test-utils";
import NavigateNextIcon from "@mui/icons-material/NavigateNext";

const NewTrainingPlanRequest = () => {
  const goals = ["Bulk", "Cut", "Recomp", "Endurance"];
  const numberOfSessions = [2, 3, 4, 5, 6];
  const [goal, setGoal] = useState<any>("Bulk");
  const [number, setNumber] = useState<any>(2);
  const authCtx = useContext(AuthContext);
  const [page, setPage] = useState("GOALS");
  const [trainers, setTrainers] = useState<any[]>([]);
  const [selectedTrainer, setSelectedTrainer] = useState(null);
  const navigate = useNavigate();

  const sumbitFormHandler = () => {
    event?.preventDefault();

    if (!selectedTrainer) {
      alert("You must selected trainer.");
      return;
    }
    fetch("http://localhost:5041/api/training-plan-request/create", {
      method: "POST",
      body: JSON.stringify({
        sessionsPerWeek: number,
        trainingGoal: goal,
        trainerEmail: selectedTrainer.email,
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        if (res.ok) {
          return res;
        }
      })
      .then((data) => {
        alert("You have succesfully created training plan request!");
        navigate("/");
      });
  };

  const updateNumber = (event: any) => {
    console.log(event?.target.value);
    setNumber(event?.target.value);
  };

  const updateGoal = (event: any) => {
    console.log(event?.target.value);
    setGoal(event?.target.value);
  };

  const fetchTrainers = () => {
    fetch("http://localhost:5041/api/users/trainers", {
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
        setTrainers(actualData.items);
      });
  };

  return (
    <div className={classes.whiteContainer}>
      <div>
        {page === "GOALS" && (
          <div className={classes.goal}>
            <h2>Choose your goals</h2>
            <div className={classes.option}>
              <label>Select your training goal: </label>
              <select onChange={updateGoal} className={classes.select}>
                {goals.map((goal, index) => {
                  return <option key={index}>{goal}</option>;
                })}
              </select>
            </div>
            <div className={classes.option}>
              <label>Select training intensity: </label>
              <select onChange={updateNumber} className={classes.selectNumber}>
                {numberOfSessions.map((goal, index) => {
                  return <option key={index}>{goal}</option>;
                })}
              </select>
            </div>

            <div className={utils.rightContainer}>
              <button
                className={utils.greenButton}
                onClick={() => {
                  fetchTrainers();
                  setPage("TRAINERS");
                }}
              >
                Next
              </button>
            </div>
          </div>
        )}

        {page === "TRAINERS" && (
          <div className={classes.trainersContainer}>
            <h2>Choose your trainer</h2>
            <div className={classes.trainers}>
              {trainers.map((trainer, index: any) => (
                <div
                  key={index}
                  className={
                    trainer.fullName === selectedTrainer?.fullName
                      ? classes.trainerCardSelected
                      : classes.trainerCard
                  }
                  onClick={() => {
                    setSelectedTrainer(trainer);
                  }}
                >
                  <div className={classes.avatar}></div>
                  <h3>{trainer.fullName}</h3>
                  <div>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit.
                    Molestiae vitae officiis id debitis, quam eligendi maiores
                    nihil blanditiis harum corrupti soluta asperiores
                    consequatur perferendis pariatur at dolorum officia dolorem
                    ratione voluptatibus voluptas cumque delectus ad! Aliquid
                    doloribus officia ut velit!
                  </div>
                </div>
              ))}
            </div>

            <div className={utils.centerContainer}>
              <button
                className={utils.redButton}
                onClick={() => setPage("GOALS")}
              >
                Back
              </button>
              <button className={utils.greenButton} onClick={sumbitFormHandler}>
                Finish
              </button>
            </div>
          </div>
        )}
      </div>
    </div>
  );
};

export default NewTrainingPlanRequest;
