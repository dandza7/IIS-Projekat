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

const Appointment = () => {
  let params = useParams();
  const patientId = params.id;
  const [patient, setPatient] = useState({});
  const [muscleGroups, setMuscleGroups] = useState<any>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const [toggleMR, setToggleMR] = useState(true);
  const [toggleTherapy, setToggleTherapy] = useState(false);
  const [toggleReport, setToggleReport] = useState(false);
  useEffect(() => {
    fetch("http://localhost:5041/api/patients/" + patientId, {
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
        setMuscleGroups(actualData.items);
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

  return (
    <div className={classes.appointment}>
      <p className={utils.title}>Appointment</p>
      <div>
        <div className={classes.menu}>
          <div className={classes.menuItem} onClick={toggleMRHandler}>
            Medical Record
          </div>
          <div className={classes.menuItem} onClick={toggleTherapyHandler}>
            Therapy
          </div>
          <div className={classes.menuItem} onClick={toggleReportHandler}>
            Report
          </div>
        </div>
        <div className={classes.container}>
          {toggleMR && <div className={classes.report}>{patient?.name}</div>}
          {toggleTherapy && (
            <div className={classes.report}>
              {" "}
              <table className={classes.styledTableFoods}>
                <thead>
                  <tr>
                    <th>Name</th>
                    <th>Number of sets</th>
                    <th>Repetition range</th>
                    <th>
                      <AddIcon fontSize="small"></AddIcon>
                    </th>
                  </tr>
                </thead>
                <tbody>
                  {muscleGroups.map((mg, index) => (
                    <tr key={index}>
                      <td>{mg?.name}</td>
                      <td>{mg?.amount}</td>
                      <td>{mg?.range}</td>
                      <td>
                        <button className={classes.deleteButton}>X</button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          )}
          {toggleReport && (
            <div className={classes.report}>
              <label className={classes.smallTitle}>Appointment Report: </label>
              <textarea></textarea>
              <div className={utils.buttonContainerCenter}>
                <button className={utils.blackButton}>End appointment</button>
              </div>
            </div>
          )}
        </div>
      </div>
    </div>
  );
};

export default Appointment;
