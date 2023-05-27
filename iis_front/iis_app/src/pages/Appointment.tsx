import React from "react";
import classes from "./Appointments.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "./Utils.module.css";
import AddIcon from "@mui/icons-material/Add";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import dayjs from "dayjs";

type injuredMuscle = { injuredMuscle: string; severity: string };

const Appointment = () => {
  let params = useParams();
  const appointmentId = params.id;
  const [patient, setPatient] = useState({});
  const authCtx = useContext(AuthContext);
  const [height, setHeight] = useState(null);
  const [weight, setWeight] = useState(null);
  const navigate = useNavigate();
  const [toggleMR, setToggleMR] = useState(true);
  const [toggleTherapy, setToggleTherapy] = useState(false);
  const [toggleReport, setToggleReport] = useState(false);
  const [allMG, setAllMG] = useState<any[]>([]);
  const [muscleGroups, setMuscleGroups] = useState<any>([]);
  const [allExerecises, setAllExercises] = useState<any[]>([]);
  const [exerecises, setExercises] = useState<any[]>([]);
  const [openMG, setOpenMG] = React.useState(false);
  const [openExercises, setOpenExercises] = React.useState(false);
  const handleOpenMG = () => setOpenMG(true);
  const handleCloseMG = () => setOpenMG(false);
  const handleOpenExercises = () => setOpenExercises(true);
  const handleCloseExercises = () => setOpenExercises(false);
  const [selectedMG, setselectedMG] = useState<any[]>([]);
  const [selectedExercises, setselectedExercises] = useState<any[]>([]);
  const [selectedSingleMG, setSelectedSingleMG] = useState(null);
  const [severity, setSeverity] = useState("");
  const selectedSeverityRef = useRef();
  const textAreaRef = useRef();
  const handleSeverityChange = () => {
    setSeverity(event?.target.value);
  };

  const styleEX = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 620,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };
  const styleMG = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 600,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  const patientId = localStorage.getItem("patientId");
  useEffect(() => {
    fetch("http://localhost:5041/api/medical-record/patient/" + patientId, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        setPatient(actualData);
      });
  }, []);

  useEffect(() => {
    fetch("http://localhost:5041/api/exercise/", {
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
        setAllExercises(actualData.items);
      });
  }, []);

  const fetchMG = () => {
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
        setAllMG(actualData.items);
      });
  };

  const toggleMRHandler = () => {
    setToggleMR(true);
    setToggleTherapy(false);
    setToggleReport(false);
  };

  const toggleTherapyHandler = () => {
    setToggleTherapy(true);
    setToggleMR(false);
    setToggleReport(false);
    fetchMG();
  };

  const toggleReportHandler = () => {
    setToggleReport(true);
    setToggleTherapy(false);
    setToggleMR(false);
  };

  const addMGHandler = () => {
    var mg: injuredMuscle = { injuredMuscle: "", severity: "" };
    mg.injuredMuscle = selectedSingleMG?.name;
    mg.severity = selectedSeverityRef.current.value;
    var updatedList = [...selectedMG];
    updatedList = [...selectedMG, mg];
    setselectedMG(updatedList);
  };

  const removeMGHandler = (muscleGroup: any) => {
    console.log(muscleGroup);
    console.log(selectedMG);
    setselectedMG((current) =>
      current.filter((mg) => mg.name !== muscleGroup.name)
    );
  };

  const saveMGHandler = () => {
    setMuscleGroups(selectedMG);
  };

  const addExerciseHandler = (exercise: any) => {
    var updatedList = [...selectedExercises];
    updatedList = [...selectedExercises, exercise.name];
    setselectedExercises(updatedList);
  };

  const removeExerciseHandler = (oldExercise: any) => {
    setselectedExercises((current) =>
      current.filter((exercise) => oldExercise.id !== exercise.id)
    );
  };

  const saveExerciseHandler = () => {
    setExercises(selectedExercises);
  };

  const changeWeightHandler = () => {
    setWeight(event?.target.value);
  };
  const changeHeightHandler = () => {
    setHeight(event?.target.value);
  };

  const endAppointmentHandler = () => {
    console.log(appointmentId);
    fetch("http://localhost:5041/api/therapy/create", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        appointmentId: appointmentId,
        reportMessage: textAreaRef.current.value,
        injuries: selectedMG,
        rehabilitationExercises: exerecises,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        navigate("/appointments");
      });
  };

  return (
    <div className={classes.appointment}>
      <p className={utils.title}>Appointment</p>
      <div>
        <div className={classes.menu}>
          <div
            className={toggleMR ? classes.menuItemSelected : classes.menuItem}
            onClick={toggleMRHandler}
          >
            Medical Record
          </div>
          <div
            className={
              toggleTherapy ? classes.menuItemSelected : classes.menuItem
            }
            onClick={toggleTherapyHandler}
          >
            Therapy
          </div>
          <div
            className={
              toggleReport ? classes.menuItemSelected : classes.menuItem
            }
            onClick={toggleReportHandler}
          >
            Report
          </div>
        </div>
        <div className={classes.container}>
          {toggleMR && (
            <div className={classes.medicalRecord}>
              <div className={classes.dataContainer}>
                <div className={utils.span}>
                  <label>Name:</label>
                  <span>{patient?.name}</span>
                </div>
                <div className={utils.span}>
                  <label>Surname:</label>
                  <span>{patient?.surname}</span>
                </div>
                <div className={utils.span}>
                  <label>Birthdate:</label>
                  <span>{dayjs(patient?.birthDate).format("DD.MM.YYYY ")}</span>
                </div>
              </div>
              <div className={classes.dataContainer}>
                <div className={utils.span}>
                  <label>Gender:</label>
                  <span>{patient?.gender}</span>
                </div>
                <div className={utils.span}>
                  <label>Height:</label>
                  <input
                    value={patient?.height}
                    onChange={changeWeightHandler}
                    className={classes.weightInput}
                  ></input>
                </div>
                <div className={utils.span}>
                  <label>Weight:</label>
                  <input
                    value={patient?.weight}
                    onChange={changeHeightHandler}
                    className={classes.weightInput}
                  ></input>
                </div>
              </div>
              <div>
                <label>Anamnesis:</label>
                <input className={classes.anamnesisInput}></input>
              </div>

              <div className={classes.dalContainer}>
                <div className={classes.diagnosesContainer}>
                  <span className={classes.smallTitle}>Diagnoses</span>
                  <table className={classes.styledTableNutrients}>
                    <thead>
                      <tr>
                        <th>Diagnosis</th>
                      </tr>
                    </thead>
                    <tbody>
                      {patient?.diagnoses?.map(
                        (allergy: any, index: number) => (
                          <tr key={index}>
                            <td>{allergy}</td>
                          </tr>
                        )
                      )}
                    </tbody>
                  </table>
                </div>
                <div className={classes.diagnosesContainer}>
                  <span className={classes.smallTitle}>Allergies</span>
                  <table className={classes.styledTableNutrients}>
                    <thead>
                      <tr>
                        <th>Allergen</th>
                      </tr>
                    </thead>
                    <tbody>
                      {patient?.allergies?.map(
                        (allergy: any, index: number) => (
                          <tr key={index}>
                            <td>{allergy}</td>
                          </tr>
                        )
                      )}
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
          )}
          {toggleTherapy && (
            <div className={classes.therapy}>
              <span className={classes.smallTitle}>Injured muscle groups</span>
              <table className={classes.styledTableNutrients}>
                <thead>
                  <tr>
                    <th>Muscle group</th>
                    <th>Severity</th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th>
                      <AddIcon
                        fontSize="small"
                        onClick={handleOpenMG}
                      ></AddIcon>
                    </th>
                  </tr>
                </thead>
                <tbody>
                  {selectedMG.map((mg: any, index) => (
                    <tr key={index}>
                      <td>{mg.injuredMuscle}</td>
                      <td>{mg.severity}</td>
                      <td></td>
                      <td></td>
                      <td></td>
                      <td></td>
                      <td>
                        <button
                          className={classes.deleteButton}
                          onClick={() => {
                            removeMGHandler(mg);
                          }}
                        >
                          X
                        </button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
              <span className={classes.smallTitle}>Recommended exercises</span>
              <table className={classes.styledTableNutrients}>
                <thead>
                  <tr>
                    <th>Excercise name</th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th>
                      <AddIcon
                        fontSize="small"
                        onClick={handleOpenExercises}
                      ></AddIcon>
                    </th>
                  </tr>
                </thead>
                <tbody>
                  {exerecises.map((exercise: any, index) => (
                    <tr key={index}>
                      <td>{exercise}</td>
                      <td></td>
                      <td></td>
                      <td></td>
                      <td></td>
                      <td></td>
                      <td></td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          )}
          {toggleReport && (
            <div className={classes.report}>
              <label className={classes.smallTitle}>Appointment Report: </label>
              <textarea
                ref={textAreaRef}
                className={classes.textArea}
              ></textarea>
              <div className={utils.buttonContainerCenter}>
                <button
                  className={utils.blackButton}
                  onClick={endAppointmentHandler}
                >
                  End appointment
                </button>
              </div>
            </div>
          )}
        </div>
      </div>
      <Modal
        open={openMG}
        onClose={handleCloseMG}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={styleMG}>
          <div className={utils.modal}>
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Add injured muscle group</h2>
              </div>

              <div className={utils.modalContainer}>
                <div className={classes.mg}>
                  <div>
                    <input
                      type="text"
                      placeholder="Seach for muscle groups"
                      className={classes.mgSearchInput}
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
                        {allMG.map((mg, index) => (
                          <tr key={index}>
                            <td>{mg.name}</td>
                            <td>
                              <button
                                className={classes.blackButton}
                                onClick={() => {
                                  setSelectedSingleMG(mg);
                                }}
                              >
                                +
                              </button>
                            </td>
                          </tr>
                        ))}
                      </tbody>
                    </table>
                  </div>
                </div>
                <br></br>
                {selectedSingleMG && (
                  <div className={classes.severityDiv}>
                    <span>{selectedSingleMG.name}</span>
                    <div className={classes.amountContainer}>
                      <span>Severity :</span>
                      <input
                        ref={selectedSeverityRef}
                        value={severity}
                        onChange={handleSeverityChange}
                        className={classes.severityInput}
                      ></input>
                    </div>
                  </div>
                )}
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleCloseMG}
                  >
                    Close
                  </button>
                  <button className={utils.greenButton} onClick={addMGHandler}>
                    Save
                  </button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
      <Modal
        open={openExercises}
        onClose={handleCloseExercises}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={styleEX}>
          <div className={utils.modal}>
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Add recommended exercises</h2>
              </div>

              <div className={utils.modalContainer}>
                <div className={classes.ex}>
                  <div>
                    <input
                      type="text"
                      placeholder="Seach for exercises"
                      className={classes.exSearchInput}
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
                        {allExerecises.map((exercise, index) => (
                          <tr key={index}>
                            <td>{exercise.name}</td>
                            <td>
                              <button
                                className={classes.blackButton}
                                onClick={() => {
                                  addExerciseHandler(exercise);
                                }}
                              >
                                +
                              </button>
                            </td>
                          </tr>
                        ))}
                      </tbody>
                    </table>
                    <div className={classes.exerciseContainer}>
                      {selectedExercises.map((exercise, index) => (
                        <button
                          className={classes.exercise}
                          onClick={() => removeExerciseHandler(exercise)}
                        >
                          {exercise}
                        </button>
                      ))}
                    </div>
                  </div>
                </div>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleCloseExercises}
                  >
                    Close
                  </button>
                  <button
                    className={utils.greenButton}
                    onClick={saveExerciseHandler}
                  >
                    Save
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

export default Appointment;
