import React from "react";
import classes from "./NewTrainingPlan.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import AddIcon from "@mui/icons-material/Add";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";

const NewTrainingPlan = () => {
  const authCtx = useContext(AuthContext);
  const listRef = useRef([]);
  const [allExercises, setAllExercises] = useState<any[]>([]);
  const [open, setOpen] = React.useState(false);
  const selectedNumberOfSetsRef = useRef();
  const selectedExerciseRangeRef = useRef();
  const [selecetedSession, setSelectedSession] = useState(1);
  const [exercises, setExercises] = useState<any[]>([]);
  const [selectedExercise, setSelectedExercise] = useState(null);
  const [request, setRequest] = useState<{
    clientFullName: string;
    trainingGoal: string;
    sessionsPerWeek: number;
  }>();

  const ranges = ["5-8", "8-12", "12-15", "15-20"];

  const handleOpen = (i: number) => {
    setOpen(true);
    setSelectedExercise(null);
    setSelectedSession(i);
  };
  const handleClose = () => setOpen(false);

  useEffect(() => {
    console.log(localStorage.getItem("requestId"));
    fetch("http://localhost:5041/api/training-plan-request", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: 0,
        page: 0,
        order: [
          {
            orderField: "ID",
            ordering: "ASC",
          },
        ],
        filters: [
          {
            property: "Id",
            connecting: 0,
            filterValues: [
              {
                value: localStorage.getItem("requestId"),
                operation: 2,
              },
            ],
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items[0]);
        setRequest(actualData.items[0]);
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
      exercises: {
        exerciseId: number;
        repetitionRange: string;
        numberOfSets: number;
      }[];
    }[] = [];
    const sessionNames = Array.from(
      new Set(exercises.map((item: any) => item.sessionName))
    );

    sessionNames.forEach((sessionName) => {
      sessions.push({ name: sessionName, exercises: [] });
    });

    sessions.forEach((session) => {
      exercises.forEach((exercise) => {
        if (exercise.sessionName === session.name) {
          session.exercises.push({
            exerciseId: exercise.id,
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
        trainingPlanRequestId: localStorage.getItem("requestId"),
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

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/exercise", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({}),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setAllExercises(actualData.items);
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

  return (
    <div className={classes.newRecipe}>
      <div className={utils.title}>New training plan</div>
      <div>
        <div className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.nameContainer}>
                <div className={utils.span}>
                  <label>Name:</label>
                  <span>{request?.clientFullName}</span>
                </div>

                <button className={utils.greenButton} onClick={addPlanHandler}>
                  Create
                </button>
              </div>
              <div className={utils.span}>
                <label>Training goal:</label>
                <span>{request?.trainingGoal}</span>
              </div>
              <div className={utils.span}>
                <label>Sessions per week:</label>
                <span>{request?.sessionsPerWeek}</span>
              </div>
              {Array.from(
                { length: localStorage.getItem("sessionsPerWeek") },
                (_, i) => (
                  <div key={i} className={classes.sessionContainer}>
                    {" "}
                    <span className={classes.smallTitle}>Session {i + 1} </span>
                    <div className={utils.span}>
                      <span>Name: </span>
                      <input
                        className={utils.input}
                        ref={(ref) => (listRef.current[i] = ref)}
                      ></input>
                    </div>
                    <table className={classes.styledTableFoods} key={i + 1}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Number of sets</th>
                          <th>Repetition range</th>
                          <th>
                            <AddIcon
                              fontSize="small"
                              onClick={() => handleOpen(i + 1)}
                            ></AddIcon>
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
                                  className={classes.deleteButton}
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
          <div className={utils.modal}>
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Add exercise to session</h2>
              </div>

              <div className={utils.modalContainer}>
                <div className={classes.dalContainer}>
                  <div>
                    <input
                      type="text"
                      placeholder="Search all exercises..."
                      className={classes.allergySearchInput}
                    ></input>
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

export default NewTrainingPlan;
