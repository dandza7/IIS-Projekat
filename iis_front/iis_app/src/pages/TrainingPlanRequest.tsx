import React from "react";
import classes from "./TrainingPlanRequest.module.css";
import { useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import { useNavigate } from "react-router-dom";

const TrainingPlanRequest = () => {
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
        setTrainers(actualData.items);
      });
  };

  return (
    <div className={classes.trainingPlanRequest}>
      <div className={classes.trainingPlanTitle}>
        Create Training Plan Request
      </div>
      <div>
        {page === "GOALS" && (
          <div className={classes.container}>
            <div className={classes.planRequestForm}>
              <div className={classes.smallTitle}>Choose your goals</div>
              <div>
                <label>Select your training goal: </label>
                <select onChange={updateGoal} className={utils.selectType}>
                  {goals.map((goal, index) => {
                    return <option key={index}>{goal}</option>;
                  })}
                </select>
              </div>
              <div>
                <label>Select training intensity: </label>
                <select onChange={updateNumber} className={utils.selectNumber}>
                  {numberOfSessions.map((goal, index) => {
                    return <option key={index}>{goal}</option>;
                  })}
                </select>
              </div>
            </div>

            <div className={classes.buttonContainer}>
              <button
                className={utils.greenButton}
                onClick={() => setPage("MEASUREMENTS")}
              >
                Next
              </button>
            </div>
          </div>
        )}
        {page === "MEASUREMENTS" && (
          <div className={classes.container}>
            <div className={classes.planRequestForm}>
              <div className={classes.smallTitle}>Enter your measurements</div>
              <div>
                <label>Weight: </label>
                <input type="text" className={classes.input}></input>
              </div>
              <div>
                <label>Bicep: </label>
                <input type="text" className={classes.input}></input>
              </div>
              <div>
                <label>Forearm: </label>
                <input type="text" className={classes.input}></input>
              </div>
              <div>
                <label>Chest: </label>
                <input type="text" className={classes.input}></input>
              </div>
              <div>
                <label>Waist: </label>
                <input type="text" className={classes.input}></input>
              </div>
              <div>
                <label>Thigh: </label>
                <input type="text" className={classes.input}></input>
              </div>
              <div>
                <label>Calf: </label>
                <input type="text" className={classes.input}></input>
              </div>
            </div>

            <div className={classes.buttonContainer}>
              <button
                className={utils.redButton}
                onClick={() => setPage("GOALS")}
              >
                Back
              </button>
              <button
                className={utils.greenButton}
                onClick={() => {
                  setPage("TRAINERS");
                  fetchTrainers();
                }}
              >
                Next
              </button>
            </div>
          </div>
        )}
        {page === "TRAINERS" && (
          <div className={classes.container}>
            <div className={classes.planRequestForm}>
              <div className={classes.smallTitle}>Choose your trainer</div>
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
                    <div className={classes.smallTitle}>{trainer.fullName}</div>
                    <div>
                      Lorem ipsum dolor sit amet consectetur adipisicing elit.
                      Quae expedita voluptates harum veniam a pariatur, eveniet
                      perferendis numquam molestias id mollitia dolorum qui
                      necessitatibus ratione distinctio. Iste, nesciunt vel!
                      Impedit voluptate reprehenderit tempore libero earum
                      accusamus, tempora voluptas eligendi quisquam modi est
                      debitis perferendis, ratione, saepe et sequi?
                    </div>
                  </div>
                ))}
              </div>
            </div>

            <div className={classes.buttonContainer}>
              <button
                className={utils.redButton}
                onClick={() => setPage("MEASUREMENTS")}
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

export default TrainingPlanRequest;
