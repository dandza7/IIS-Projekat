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
import dayjs from "dayjs";

const style = {
  position: "absolute" as "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "background.paper",
  boxShadow: 24,
  borderRadius: 3,
};

const NewTrainingPlan = () => {
  const authCtx = useContext(AuthContext);
  const listRef = useRef([]);
  const [allExercises, setAllExercises] = useState<any[]>([]);
  const [open, setOpen] = React.useState(false);
  const [openDetails, setOpenDetails] = React.useState(false);
  const primaryMuscleRef = useRef(null);
  const secondaryMuscleRef = useRef(null);
  const natureRef = useRef(null);
  const selectedNumberOfSetsRef = useRef(null);
  const selectedExerciseRangeRef = useRef(null);
  const [selecetedSession, setSelectedSession] = useState(1);
  const [exercises, setExercises] = useState<any[]>([]);
  const [selectedExercise, setSelectedExercise] = useState(null);
  const [muscleGroups, setMuscleGroups] = useState<any[]>([]);
  const [selectedPrimary, setSelectedPrimary] = useState(null);
  const [selectedSecondary, setSelectedSecondary] = useState(null);
  const [selectedNature, setSelectedNature] = useState(null);

  const { id } = useParams();

  const [request, setRequest] = useState<{
    clientFullName: string;
    trainingGoal: string;
    sessionsPerWeek: number;
    clientId: number;
  }>();

  const ranges = ["5-8", "8-12", "12-15", "15-20"];
  const natures = [
    { label: "Hypertropy", value: "Hypertropy" },
    { label: "Rehabilitaion", value: "Rehabilitation" },
    { label: "Both", value: "Both" },
  ];
  const handleOpen = (i: number) => {
    setOpen(true);
    setSelectedExercise(null);
    setSelectedSession(i);
  };
  const handleClose = () => setOpen(false);

  const handleOpenDetails = () => {
    setOpenDetails(true);
  };
  const handleCloseDetails = () => setOpenDetails(false);

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

  useEffect(() => {
    fetch("http://localhost:5041/api/training-plan-request/" + id, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setRequest(actualData);
      });
  }, []);

  const addExerciseHandler = () => {
    const se = selectedExercise;
    let _selectedExercise = {
      amount: 0,
      name: "string",
      session: 1,
      range: "string",
      sessionName: "string",
      id: 0,
    };
    _selectedExercise.amount = selectedNumberOfSetsRef?.current?.value;
    _selectedExercise.range = selectedExerciseRangeRef?.current?.value;
    const i = selecetedSession;
    _selectedExercise.session = i;
    _selectedExercise.sessionName = listRef.current[selecetedSession - 1].value;
    _selectedExercise.id = se.id;
    _selectedExercise.name = se.name;
    var updatedList = [...exercises];
    updatedList.push(_selectedExercise);
    setExercises(updatedList);
    handleClose();
  };

  const removeExerciseHandler = (foodId: number, i: number) => {
    setExercises((current) =>
      current.filter((food) => food.id !== foodId || food.session !== i + 1)
    );
  };

  const addPlanHandler = () => {
    event?.preventDefault();

    const sessions: {
      name: string;
      exerciseInfo: {
        exerciseName: string;
        repetitionRange: string;
        numberOfSets: number;
      }[];
    }[] = [];
    const sessionNames = Array.from(
      new Set(exercises.map((item: any) => item.sessionName))
    );

    sessionNames.forEach((sessionName) => {
      sessions.push({ name: sessionName, exerciseInfo: [] });
    });

    sessions.forEach((session) => {
      exercises.forEach((exercise) => {
        if (exercise.sessionName === session.name) {
          session.exerciseInfo.push({
            exerciseName: exercise.name,
            repetitionRange: exercise.range,
            numberOfSets: exercise.amount,
          });
        }
      });
    });
    console.log(sessions);
    fetch("http://localhost:5041/api/training-plan/create", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        trainingPlanRequestId: id,
        sessionsPerWeek: request?.sessionsPerWeek,
        trainingGoal: request?.trainingGoal,
        trainingSessions: sessions,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("Training plan has been successfully added!");
      });
  };

  const fetchExercises = (isInital: boolean) => {
    if (isInital) {
      fetch(
        "http://localhost:5041/api/exercise/suitableForClient/" +
        request?.clientId,
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
        request?.clientId,
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

  return (
    <div className={utils.whiteContainer}>
      <h2>New training plan</h2>
      <div id="report">
        <div className={utils.form}>
          <div className={classes.container}>
            <div className={classes.nameContainer}>
              <div className={utils.span}>
                <label>Name:</label>
                <span>{request?.clientFullName}</span>
              </div>

              <div className={utils.span}>
                <label>Training goal:</label>
                <span>{request?.trainingGoal}</span>
              </div>
              <div className={utils.span}>
                <label>Sessions per week:</label>
                <span>{request?.sessionsPerWeek}</span>
              </div>
            </div>
            <div className={utils.rightContainer}>
              <button className={utils.redButton} onClick={handleOpenDetails}>
                Details
              </button>
              <button className={utils.greenButton} onClick={addPlanHandler}>
                Create
              </button>
            </div>
            <div className={classes.sessionsContainer}>
              {request &&
                Array.from({ length: request?.sessionsPerWeek }, (_, i) => (
                  <div key={i} className={classes.sessionContainer}>
                    {" "}
                    <div className={utils.span}>
                      <span>Name: </span>
                      <input
                        className={utils.input}
                        ref={(ref) => (listRef.current[i] = ref)}
                      ></input>
                    </div>
                    <table className={classes.tpTable} key={i + 1}>
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
                                  handleOpen(i + 1);
                                  fetchExercises(true);
                                }}
                              ></AddIcon>
                            </div>
                          </th>
                        </tr>
                      </thead>
                      <tbody>
                        {exercises
                          .filter((exercise) => exercise.session == i + 1)
                          .map((exercise, index) => (
                            <tr key={index}>
                              <td>{exercise?.name}</td>
                              <td>{exercise?.amount}</td>
                              <td>{exercise?.range}</td>
                              <td>
                                <button
                                  className={classes.removeButton}
                                  onClick={() =>
                                    removeExerciseHandler(exercise?.id, i)
                                  }
                                >
                                  X
                                </button>
                              </td>
                            </tr>
                          ))}
                      </tbody>
                    </table>
                  </div>
                ))}
            </div>
          </div>
        </div>
      </div>

      <Modal
        open={openDetails}
        onClose={handleCloseDetails}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Medical Record</h2>
              <div className={classes.modalClose} onClick={handleCloseDetails}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.patientInfoModal}>
                <div className={utils.span}>
                  <label>Patient:</label>
                  <span>{request?.clientFullName}</span>
                </div>
                <div className={utils.span}>
                  <label>Gender:</label>
                  <span>{request?.patientInfo.gender}</span>
                </div>
                <div className={utils.span}>
                  <label>Birthdate:</label>
                  <span>
                    {dayjs(request?.patientInfo.birthDate).format("DD.MM.YYYY")}
                  </span>
                </div>
                <div className={utils.span}>
                  <label>Height:</label>
                  <span>{request?.patientInfo.height} cm</span>
                </div>
                <div className={utils.span}>
                  <label>Weight:</label>
                  <span>{request?.patientInfo.weight} kg</span>
                </div>

                <div className={utils.spanTop}>
                  <label>Diagnoses:</label>
                  {request?.patientInfo.diagnoses.length > 0 ? (
                    <>
                      <ul className={classes.list}>
                        {request?.patientInfo.diagnoses.map(
                          (diagnose, index) => {
                            return <li className={classes.bold}>{diagnose}</li>;
                          }
                        )}
                      </ul>
                    </>
                  ) : (
                    <span>Customer does not have any diagonses.</span>
                  )}
                </div>

                <div className={utils.spanTop}>
                  <label>Injuries:</label>
                  {request?.patientInfo.injuries.length > 0 ? (
                    <>
                      <ul className={classes.list}>
                        {request?.patientInfo.injuries.map((injury, index) => {
                          return (
                            <li className={classes.bold}>
                              {injury.injuredMuscle} - {injury.severity} level injury
                            </li>
                          );
                        })}
                      </ul>
                    </>
                  ) : (
                    <span>Customer does not have any injuries.</span>
                  )}
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Add exercise</h2>
              <div className={classes.modalClose} onClick={handleClose}>
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
                            className={utils.greenMenuButton}
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

export default NewTrainingPlan;
