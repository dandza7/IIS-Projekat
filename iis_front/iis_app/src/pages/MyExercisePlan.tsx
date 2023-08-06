import React from "react";
import classes from "./MyTrainingPlan.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";
import JsPDF from "jspdf";
import html2canvas from "html2canvas";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";

const MyExercisePlan = () => {
  const authCtx = useContext(AuthContext);
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const [selectedExercise, setSelectedExercise] = useState(null);
  const textAreaRef = useRef();
  const navigate = useNavigate();
  const [message, setMessage] = React.useState(null);
  const [changed, setChanged] = React.useState(false);
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

  type trainingSession = {
    name: string;
    exerciseInfo: [
      {
        exerciseName: string;
        repetitionRange: string;
        numberOfSets: number;
        isUnhappy: boolean;
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
            isUnhappy: boolean;
          }
        ];
      }
    ];
  }>();

  const requestExerciseChangeHandler = () => {
    fetch("http://localhost:5041/api/exercise/flag", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        exerciseName: selectedExercise,
        note: textAreaRef.current.value,
      }),
    }).then((response) => {
      getPlan();
      handleClose();
    });
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
      .then((res) =>        {if (res.ok) {
        return res.json();
      } else if (res.status == 404) {
        throw new Error("error");
      }})
      .then((actualData) => {
        if(actualData.message !== null)
        setPlan(actualData.message)
        else
        setPlan(actualData);
      });
  };

  useEffect(() => {
    getPlan();
  }, []);

  const generatePDF = () => {
    const input = document.getElementById("report");
    html2canvas(input).then((canvas) => {
      const imgData = canvas.toDataURL("image/png");
      const pdf = new JsPDF();
      pdf.addImage(imgData, "PNG", 0, 0, 210, 90);
      pdf.save("download.pdf");
    });
  };

  return (
    <div className={classes.newRecipe}>
      <div className={utils.title}>My training plan</div>
      <div id="report">
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
                {plan?.trainingSessions?.map(
                  (session: trainingSession, index) => (
                    <div className={classes.tablesContainer} key={index}>
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
                            <th></th>
                          </tr>
                        </thead>
                        <tbody>
                          {session?.exerciseInfo?.map((exercise, index) => (
                            <tr
                              key={index}
                              className={
                                exercise?.isUnhappy
                                  ? classes.unhappy
                                  : classes.normal
                              }
                            >
                              <td>{exercise?.exerciseName}</td>
                              <td>{exercise?.numberOfSets}</td>
                              <td>{exercise?.repetitionRange}</td>
                              <td>
                                {" "}
                                {!exercise?.isUnhappy && (
                                  <button
                                    className={classes.greenButton}
                                    onClick={() => {
                                      setSelectedExercise(
                                        exercise?.exerciseName
                                      );
                                      handleOpen();
                                    }}
                                  >
                                    Change
                                  </button>
                                )}
                              </td>
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
      <div className={utils.buttonContainerRight}>
        <button
          onClick={generatePDF}
          type="button"
          className={utils.blackButton}
        >
          Export PDF
        </button>
      </div>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={utils.modal}>
            <div className={utils.modalTitle}>
              <h2>Request exercise change</h2>
            </div>
            <div className={utils.modalContainer}>
              <div className={classes.form}>
                <span className={classes.span}>
                  <label>Exercise name: </label>
                  <p>{selectedExercise}</p>
                </span>
                <span className={classes.span}>
                  <label>Note : </label>
                  <textarea
                    className={classes.note}
                    ref={textAreaRef}
                  ></textarea>
                </span>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleClose}
                  >
                    Cancel
                  </button>
                  <button
                    className={utils.greenButton}
                    onClick={requestExerciseChangeHandler}
                  >
                    Send
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
export default MyExercisePlan;
