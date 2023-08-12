import React from "react";
import classes from "./NewTrainingPlan.module.css";
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
import AddIcon from "@mui/icons-material/Add";
import Select from "react-select";

export const TrainingPlanOverview = () => {
  const authCtx = useContext(AuthContext);
  const [open, setOpen] = React.useState(false);
  const [openAdd, setOpenAdd] = React.useState(false);
  const [selecetedSession, setSelectedSession] = useState(null);
  const ranges = ["5-8", "8-12", "12-15", "15-20"];
  const [selectedExercise, setSelectedExercise] = useState(null);
  const [allExercises, setAllExercises] = useState<any[]>([]);
  const selectedNumberOfSetsRef = useRef();
  const selectedExerciseRangeRef = useRef();
  const [muscleGroups, setMuscleGroups] = useState<any[]>([]);
  const [selectedPrimary, setSelectedPrimary] = useState(null);
  const [selectedSecondary, setSelectedSecondary] = useState(null);
  const [selectedNature, setSelectedNature] = useState(null);

  const natures = [
    { label: "Hypertropy", value: "Hypertropy" },
    { label: "Rehabilitaion", value: "Rehabilitation" },
    { label: "Both", value: "Both" },
  ];

  const fetchExercises = (isInital: boolean) => {
    if (isInital) {
      fetch(
        "http://localhost:5041/api/exercise/suitableForClient/" +
          plan?.clientId,
        {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
            Authorization: "Bearer " + authCtx.token,
          },
          body: JSON.stringify({}),
        }
      )
        .then((response) => response.json())
        .then((actualData) => {
          console.log(actualData.items);
          setAllExercises(actualData.items);
        });
    } else {
      fetch(
        "http://localhost:5041/api/exercise/suitableForClient/" +
          plan?.clientId,
        {
          method: "POST",
          headers: {
            "Content-Type": "application/json",
            Authorization: "Bearer " + authCtx.token,
          },
          body: JSON.stringify({
            primaryMuscleGroup: selectedPrimary?.value,
            secondarymuscleGroup: selectedSecondary?.value,
            exerciseNature: selectedNature?.value,
          }),
        }
      )
        .then((response) => response.json())
        .then((actualData) => {
          console.log(actualData.items);
          setAllExercises(actualData.items);
        });
    }
  };

  const handleOpenAdd = (session: any) => {
    setOpenAdd(true);
    setSelectedExercise(null);
    setSelectedSession(session);
  };
  const handleCloseAdd = () => setOpenAdd(false);

  const handleOpen = (session: any) => {
    setOpen(true);
    setSelectedSession(session);
  };
  const handleClose = () => setOpen(false);

  type trainingSession = {
    name: string;
    exerciseInfo: [
      {
        exerciseName: string;
        repetitionRange: string;
        numberOfSets: number;
      }
    ];
  };

  type plan = {
    trainingPlanId: number;
    clientId: number;
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
            note: string;
          }
        ];
      }
    ];
  };

  const [plan, setPlan] = useState<plan>();

  let params = useParams();
  const id = params.id;

  useEffect(() => {
    fetch(
      "http://localhost:5041/api/training-plan/detailedTrainingPlan/" + id,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + authCtx.token,
        },
        body: JSON.stringify({
          paginationQuery: {},
        }),
      }
    )
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setPlan(actualData);
      });
  }, []);

  useEffect(() => {
    fetch("http://localhost:5041/api/muscle-group", {
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
        const mGroups: any = [];
        actualData.items.map((item: any) => {
          mGroups.push({ label: item.name, value: item.name });
        });
        setMuscleGroups(mGroups);
      });
  }, []);

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

  const updateSessionHandler = (name: string) => {
    console.log(name);
  };

  const removeExerciseHandler = (session: trainingSession, exercise: any) => {
    setPlan((prevState: any) => {
      const updatedSessions = prevState.trainingSessions.map(
        (sessionn: any) => {
          if (sessionn.name === session.name) {
            const updatedExercises = session.exerciseInfo.filter(
              (exercisee) => exercisee.exerciseName !== exercise.exerciseName
            );
            return {
              ...session,
              exerciseInfo: updatedExercises,
            };
          } else {
            return sessionn;
          }
        }
      );
      console.log(updatedSessions);
      return {
        ...prevState,
        trainingSessions: updatedSessions,
      };
    });
  };

  const addExerciseHandler = () => {
    const session = selecetedSession;
    console.log(session);
    setPlan((prevState: any) => {
      const updatedSessions = prevState.trainingSessions.map(
        (sessionn: any) => {
          if (sessionn.name === session.name) {
            const ses = sessionn;
            ses.exerciseInfo.push({
              exerciseName: selectedExercise.name,
              isUnhappy: false,
              note: "",
              numberOfSets: selectedNumberOfSetsRef.current.value,
              repetitionRange: selectedExerciseRangeRef.current.value,
            });
            console.log(ses);
            return {
              ...session,
              exerciseInfo: ses.exerciseInfo,
            };
          } else {
            return sessionn;
          }
        }
      );
      console.log(updatedSessions);
      return {
        ...prevState,
        trainingSessions: updatedSessions,
      };
    });
    handleCloseAdd();
  };

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
      <div className={utils.title}>Training plan overview</div>
      <div id="report">
        <div className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.nameContainer}>
                <div className={utils.span}>
                  <label>Name:</label>
                  <span>{plan?.clientName}</span>
                </div>
              </div>
              <div className={utils.span}>
                <label>Training goal:</label>
                <span>{plan?.trainingGoal}</span>
              </div>
              <div className={utils.span}>
                <label>Sessions per week:</label>
                <span>{plan?.sessionsPerWeek}</span>
              </div>
              <button
                onClick={() => {
                  console.log(plan);
                }}
              >
                PROBA
              </button>
              <div>
                {plan?.trainingSessions.map(
                  (session: trainingSession, index) => (
                    <div key={index}>
                      <div>
                        <div className={classes.filters}>
                          <span className={classes.smallTitle}>
                            {session.name}
                          </span>
                        </div>
                        <div className={utils.buttonContainerRight}>
                          {/*
                          <button
                            className={utils.greenButton}
                            onClick={() => {
                              handleOpen(session);
                            }}
                          >
                            Update
                          </button>
                          */}
                        </div>
                        <table
                          className={classes.styledTableNutrients}
                          key={index}
                        >
                          <thead>
                            <tr>
                              <th>Name</th>
                              <th>Number of sets</th>
                              <th>Repetition range</th>
                              <th>
                                <AddIcon
                                  fontSize="small"
                                  onClick={() => {
                                    handleOpenAdd(session);
                                    fetchExercises(true);
                                  }}
                                ></AddIcon>
                              </th>
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
                                  <button
                                    className={classes.deleteButton}
                                    onClick={() => {
                                      removeExerciseHandler(session, exercise);
                                    }}
                                  >
                                    X
                                  </button>
                                </td>
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
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Update session</h2>
              </div>
              <br></br>
              <div className={classes.smallTitle}>
                Session name: {selecetedSession?.name}
              </div>
              <div className={utils.modalContainer}>
                <div className={classes.dalContainer}>
                  <div className={classes.tableContainer}>
                    <table className={classes.styledTable}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        {selecetedSession?.exerciseInfo?.map(
                          (exercise, index) => (
                            <tr
                              key={index}
                              className={
                                exercise?.isUnhappy
                                  ? classes.unhappy
                                  : classes.normal
                              }
                            >
                              <td>{exercise.exerciseName}</td>
                              <td>
                                <button className={classes.blackButton}>
                                  +
                                </button>
                              </td>
                            </tr>
                          )
                        )}
                      </tbody>
                    </table>

                    <div className={classes.selectedIngredientContainer}>
                      <div className={classes.selectedIngredient}>
                        <div
                          className={
                            classes.selectedIngredientNutrientsContainer
                          }
                        ></div>
                        <div className={classes.amountContainer}>
                          <span>Number of sets :</span>
                          <input className={classes.amountInput}></input>
                          <span>Repetition range :</span>
                          <select>
                            {ranges.map((range, index) => (
                              <option id={index}>{range}</option>
                            ))}
                          </select>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleClose}
                  >
                    Close
                  </button>
                  <button className={utils.greenButton}>Add</button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
      <Modal
        open={openAdd}
        onClose={handleCloseAdd}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={utils.modal}>
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Add exercise to session</h2>
              </div>

              <div className={utils.modalContainer}>
                <div className={classes.dalContainer}>
                  <div className={classes.filtersContainer}>
                    <div className={classes.filterContainer}>
                      <label>Primary target muscle: </label>
                      <Select
                        name="name"
                        isClearable
                        options={muscleGroups}
                        onChange={setSelectedPrimary}
                        placeholder={"Primary muscle group"}
                      />
                    </div>
                    <div className={classes.filterContainer}>
                      <label>Secondary target muscle: </label>
                      <Select
                        name="names"
                        isClearable
                        options={muscleGroups}
                        onChange={setSelectedSecondary}
                        placeholder={"Secondary muscle group"}
                      />
                    </div>
                    <div className={classes.filterContainer}>
                      <label>Exercise nature: </label>
                      <Select
                        name="names"
                        isClearable
                        options={natures}
                        onChange={setSelectedNature}
                        placeholder={"Exercise nature"}
                      />
                    </div>
                  </div>
                  <div className={classes.buttonContainerCenter}>
                    <button
                      className={utils.greenButton}
                      onClick={() => fetchExercises(false)}
                    >
                      Search
                    </button>
                  </div>
                  <div className={classes.tableContainer}>
                    <table className={classes.styledTable}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        {allExercises.map((exercise, index) => (
                          <tr key={index}>
                            <td>{exercise.name}</td>
                            <td>
                              <button
                                className={classes.blackButton}
                                onClick={() => {
                                  setSelectedExercise(exercise);
                                }}
                              >
                                +
                              </button>
                            </td>
                          </tr>
                        ))}
                      </tbody>
                    </table>

                    {selectedExercise && (
                      <div className={classes.selectedIngredientContainer}>
                        <span>{selectedExercise?.name}</span>
                        <div className={classes.selectedIngredient}>
                          <div
                            className={
                              classes.selectedIngredientNutrientsContainer
                            }
                          ></div>
                          <div className={classes.amountContainer}>
                            <span>Number of sets :</span>
                            <input
                              ref={selectedNumberOfSetsRef}
                              className={classes.amountInput}
                            ></input>
                            <span>Repetition range :</span>
                            <select ref={selectedExerciseRangeRef}>
                              {ranges.map((range, index) => (
                                <option id={index}>{range}</option>
                              ))}
                            </select>
                          </div>
                        </div>
                      </div>
                    )}
                  </div>
                </div>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleClose}
                  >
                    Close
                  </button>
                  <button
                    className={utils.greenButton}
                    onClick={() => addExerciseHandler()}
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
