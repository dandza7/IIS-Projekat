import React from "react";
import classes from "./styles/TrainingPlan.module.css";
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
const style = {
  position: "absolute" as "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "background.paper",
  boxShadow: 24,
  borderRadius: 3,
};
const natures = [
  { label: "Hypertropy", value: "Hypertropy" },
  { label: "Rehabilitaion", value: "Rehabilitation" },
  { label: "Both", value: "Both" },
];

export const TrainingPlan = () => {
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

  const updatePlanHandler = () => {
    const backendModel = {
      trainingPlanId: plan?.trainingPlanId,
      trainingGoal: plan?.trainingGoal,
      sessionsPerWeek: plan?.sessionsPerWeek,
      trainingSessions: plan?.trainingSessions.map((session) => {
        const exerciseInfo = session.exerciseInfo.map((exercise) => {
          const { isUnhappy, note, ...rest } = exercise;
          return rest;
        });

        return {
          name: session.name,
          exerciseInfo: exerciseInfo,
        };
      }),
    };
    console.log(backendModel);

    fetch("http://localhost:5041/api/training-plan/update", {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify(backendModel),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
      });
  };

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

  const planToUpdatePlan = (plan: plan) => {
    const backendModel = {
      trainingPlanId: plan.trainingPlanId,
      clientName: plan.clientName,
      trainingGoal: plan.trainingGoal,
      sessionsPerWeek: plan.sessionsPerWeek,
      trainingSessions: plan.trainingSessions.map((session) => {
        const exerciseInfo = session.exerciseInfo.map((exercise) => {
          const { isUnhappy, note, ...rest } = exercise;
          return rest;
        });

        return {
          name: session.name,
          exerciseInfo: exerciseInfo,
        };
      }),
    };

    return backendModel;
  };

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

  type planUpdate = {
    trainingPlanId: number;
    sessionsPerWeek: number;
    trainingGoal: string;
    trainingSessions: [
      {
        name: string;
        exercises: [
          {
            exerciseId: 0;
            repetitionRange: string;
            numberOfSets: 0;
          }
        ];
      }
    ];
  };

  type plan = {
    trainingPlanId: number;
    clientId: number;
    clientName: string;
    trainingGoal: string;
    sessionsPerWeek: number;
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
    <div className={utils.whiteContainer}>
      <h2>Training plan overview</h2>
      <div id="report">
        <div className={utils.form}>
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
            <div className={utils.rightContainer}>
              <button className={utils.greenButton} onClick={updatePlanHandler}>
                Update
              </button>
            </div>
            <div>
              {plan?.trainingSessions.map((session: trainingSession, index) => (
                <div key={index}>
                  <div className={classes.session}>
                    <div className={classes.filters}>
                      <h3>{session.name}</h3>
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
                    <table className={classes.tpTable} key={index}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Sets</th>
                          <th>Repetition</th>
                          <th>
                            <div className={classes.menuButtonGreen}>
                              <AddIcon
                                fontSize="small"
                                onClick={() => {
                                  handleOpenAdd(session);
                                  fetchExercises(true);
                                }}
                              ></AddIcon>
                            </div>
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
                                className={classes.removeButton}
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
              ))}
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
              <h2>Add allergen</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.tableContainer}>
                <table className={classes.allergenTable}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th></th>
                    </tr>
                  </thead>
                  <tbody>
                    {selecetedSession?.exerciseInfo?.map((exercise, index) => (
                      <tr
                        key={index}
                        className={
                          exercise?.isUnhappy ? classes.unhappy : classes.normal
                        }
                      >
                        <td>{exercise.exerciseName}</td>
                        <td>
                          <button className={classes.removeButton}>+</button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>

                <div className={classes.selectedIngredientContainer}>
                  <div className={classes.selectedIngredient}>
                    <div
                      className={classes.selectedIngredientNutrientsContainer}
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
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Add exercise</h2>
              <div className={classes.modalClose} onClick={handleCloseAdd}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.filtersContainer}>
                <div className={classes.filterContainer}>
                  <label>Primary target muscle: </label>
                  <Select
                    className={classes.select}
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
                    placeholder={"Exercise nature"}
                  />
                </div>
              </div>
              <div className={utils.centerContainer}>
                <button
                  className={utils.greenButton}
                  onClick={() => fetchExercises(false)}
                >
                  Search
                </button>
              </div>
              <div className={classes.tableContainer}>
                <table className={classes.allergenTable}>
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
                            className={classes.removeButton}
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
                    <div className={classes.exerciseName}>
                      <span>{selectedExercise?.name}</span>
                    </div>
                    <div className={classes.exerciseAmount}>
                      <div className={utils.span}>
                        <span>Number of sets:</span>
                        <input
                          ref={selectedNumberOfSetsRef}
                          className={utils.inputNumber}
                        ></input>
                      </div>
                      <div className={utils.span}>
                        <span>Repetition range :</span>
                        <select
                          ref={selectedExerciseRangeRef}
                          className={utils.inputNumber}
                        >
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
            <div className={utils.centerContainer}>
              <button
                className={utils.greenButton}
                onClick={() => addExerciseHandler()}
              >
                Add
              </button>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default TrainingPlan;
