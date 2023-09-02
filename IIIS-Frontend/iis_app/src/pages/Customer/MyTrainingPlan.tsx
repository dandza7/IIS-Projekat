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
import JsPDF from "jspdf";
import html2canvas from "html2canvas";
import PrintIcon from "@mui/icons-material/Print";
export const MyTrainingPlan = () => {
  const authCtx = useContext(AuthContext);
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const [selectedExercise, setSelectedExercise] = useState(null);
  const textAreaRef = useRef();
  const navigate = useNavigate();
  const [message, setMessage] = React.useState(null);
  const [changed, setChanged] = React.useState(false);
  const [showChange, setShowChange] = React.useState(true);
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
      .then((res) => {
        if (res.ok) {
          return res.json();
        } else if (res.status == 404) {
          throw new Error("error");
        }
      })
      .then((actualData) => {
        setPlan(actualData);
      });
  };

  useEffect(() => {
    getPlan();
  }, []);

  const generatePDF = () => {
    setShowChange(true);
    const input = document.getElementById("report");
    html2canvas(input).then((canvas) => {
      const imgData = canvas.toDataURL("image/png");
      const pdf = new JsPDF();
      pdf.addImage(imgData, "PNG", 0, 0, 210, 300);
      pdf.save("download.pdf");
    });
  };

  return (
    <div className={utils.whiteContainer}>
      <div className={classes.titleBox}>
        <h2>My training plan</h2>
        <button
          className={utils.redButtonSmall}
          onClick={() => {
            setShowChange(false);
            setTimeout(() => {
              generatePDF();
            }, 1);
          }}
        >
          <PrintIcon></PrintIcon>
        </button>
      </div>

      <div id="report">
        <div className={utils.form}>
          <div className={classes.container}>
            <div className={classes.tpInfo}>
              <div className={classes.nameContainer}></div>
              <div className={utils.span}>
                <label>Training goal:</label>
                <span>{plan?.trainingGoal}</span>
              </div>
              <div className={utils.span}>
                <label>Sessions per week:</label>
                <span>{plan?.sessionsPerWeek}</span>
              </div>
            </div>
            <div>
              {plan?.trainingSessions?.map(
                (session: trainingSession, index) => (
                  <div key={index}>
                    <div className={classes.session}>
                      <div className={classes.filters}>
                        <h3>{session.name}</h3>
                      </div>
                      <div className={utils.buttonContainerRight}></div>
                      <table className={classes.tpTable} key={index}>
                        <thead>
                          <tr>
                            <th>Name</th>
                            <th>Sets</th>
                            <th>Repetition</th>
                            {showChange && <th></th>}
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
                              {showChange && (
                                <td>
                                  <button
                                    className={classes.removeButton}
                                    onClick={() => {
                                      setSelectedExercise(
                                        exercise?.exerciseName
                                      );
                                      handleOpen();
                                    }}
                                  >
                                    Change
                                  </button>
                                </td>
                              )}
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

      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Change exercise</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.form}>
                <span className={classes.span}>
                  <label>Exercise name: </label>
                  <p>{selectedExercise}</p>
                </span>
                <span className={classes.span}>
                  <label>Note: </label>
                  <textarea
                    className={classes.note}
                    ref={textAreaRef}
                  ></textarea>
                </span>
                <br></br>
                <div className={utils.centerContainer}>
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

export default MyTrainingPlan;
