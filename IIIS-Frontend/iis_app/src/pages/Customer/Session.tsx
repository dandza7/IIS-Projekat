import React from "react";
import classes from "../Trainer/styles/TrainingPlan.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "../styles/Utils.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import AddIcon from "@mui/icons-material/Add";
import Select from "react-select";
import { act } from "react-dom/test-utils";

export const Session = () => {
  const authCtx = useContext(AuthContext);
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const [selectedExercise, setSelectedExercise] = useState(null);
  const [selectedExerciseIndex, setSelectedExerciseIndex] = useState(null);
  const textAreaRef = useRef();
  const navigate = useNavigate();
  const [message, setMessage] = React.useState(null);
  const [changed, setChanged] = React.useState(false);
  const [session, setSession] = useState<any[]>([]);
  const [weight, setWeight] = React.useState(0);
  const [doneReps, setDoneReps] = React.useState(0);

  const saveExerciseHandler = () => {
    console.log("As");
    const updatedSessionData = [...session.exerciseInfo];
    updatedSessionData[selectedExerciseIndex].note = weight;
    updatedSessionData[selectedExerciseIndex].isUnhappy = doneReps;
    setSession(updatedSessionData);
  };

  const changeWeightHandler = (event) => {
    setWeight(event?.target.value);
  };

  const changeDoneRepsHandler = (event) => {
    setDoneReps(event?.target.value);
  };

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  const getPlan = () => {
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
      .then((res) => {
        if (res.ok) {
          return res.json();
        } else if (res.status == 404) {
          throw new Error("error");
        }
      })
      .then((actualData) => {
        console.log(actualData);
        setSession(actualData.trainingSessions[0]);
      });
  };

  useEffect(() => {
    getPlan();
  }, []);

  return (
    <div className={utils.whiteContainer}>
      <h2>Today's session</h2>
      <div id="report">
        <div className={utils.form}>
          <div className={classes.container}>
            <div>
              <div className={classes.session}>
                <div className={classes.filters}>
                  <h3>{session?.name}</h3>
                </div>
                <div className={utils.buttonContainerRight}></div>
                <table className={classes.tpTable}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Sets</th>
                      <th>Repetition</th>
                      <th></th>
                    </tr>
                  </thead>
                  <tbody>
                    {session?.exerciseInfo?.map((exercise, index) => (
                      <tr
                        key={index}
                        className={
                          exercise?.isUnhappy ? classes.unhappy : classes.normal
                        }
                      >
                        <td>{exercise?.exerciseName}</td>
                        <td>{exercise?.numberOfSets}</td>
                        <td>{exercise?.repetitionRange}</td>
                        <td>
                          <button
                            className={classes.removeButton}
                            onClick={() => {
                              setSelectedExercise(exercise);
                              setSelectedExerciseIndex(index);
                              handleOpen();
                            }}
                          >
                            Add
                          </button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>

      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Todays session</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.form}>
                <span className={classes.span}>
                  <label>Exercise name: </label>
                  <p>{selectedExercise?.exerciseName}</p>
                </span>
                <span className={classes.span}>
                  <label>Recommended sets: </label>
                  <p>{selectedExercise?.numberOfSets}</p>
                </span>
                <span className={classes.span}>
                  <label>Recommended repetitions: </label>
                  <p>{selectedExercise?.repetitionRange}</p>
                </span>
                <span className={classes.span}>
                  <label>Done repetitions: </label>
                  <input
                    className={classes.input}
                    value={doneReps}
                    onChange={changeDoneRepsHandler}
                  ></input>
                </span>
                <span className={classes.span}>
                  <label>Weight: </label>
                  <input
                    className={classes.input}
                    value={weight}
                    onChange={changeWeightHandler}
                  ></input>
                </span>
                <br></br>
                <div className={utils.centerContainer}>
                  <button
                    className={utils.greenButton}
                    onClick={saveExerciseHandler}
                  >
                    Add
                  </button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default Session;
