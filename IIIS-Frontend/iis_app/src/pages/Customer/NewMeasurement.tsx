import React from "react";
import classes from "./styles/Measurements.module.css";
import utils from "../styles/Utils.module.css";
import { useRef } from "react";
import { useContext } from "react";
import AuthContext from "../../store/auth-context";
import { useNavigate } from "react-router";

const NewMeasurement = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const weightRef = useRef();
  const bicepRef = useRef();
  const forearmRef = useRef();
  const chestRef = useRef();
  const waistRef = useRef();
  const thighRef = useRef();
  const calfRef = useRef();

  const saveMeasurement = () => {
    const enteredWeight = weightRef.current.value;
    const enteredBicep = bicepRef.current.value;
    const enteredForearm = forearmRef.current.value;
    const enteredChest = chestRef.current.value;
    const enteredWaist = waistRef.current.value;
    const enteredThigh = thighRef.current.value;
    const enteredCalf = calfRef.current.value;

    fetch("http://localhost:5041/api/measurement/create", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        weight: enteredWeight,
        bicep: enteredBicep,
        forearm: enteredForearm,
        chest: enteredChest,
        waist: enteredWaist,
        thigh: enteredThigh,
        calf: enteredCalf,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        navigate("/my-training-plan");
      });
  };

  return (
    <div className={classes.whiteContainer}>
      <div className={classes.measurements}>
        <h2>Enter your measurements</h2>
        <div className={classes.measurement}>
          <label>Weight: </label>
          <div className={classes.measurement_inputUnit}>
            <input
              type="text"
              className={classes.input}
              ref={weightRef}
            ></input>
            <span>kg</span>
          </div>
        </div>
        <div className={classes.measurement}>
          <label>Bicep: </label>
          <div className={classes.measurement_inputUnit}>
            <input type="text" className={classes.input} ref={bicepRef}></input>
            <span>cm</span>
          </div>
        </div>
        <div className={classes.measurement}>
          <label>Forearm: </label>
          <div className={classes.measurement_inputUnit}>
            <input
              type="text"
              className={classes.input}
              ref={forearmRef}
            ></input>
            <span>cm</span>
          </div>
        </div>
        <div className={classes.measurement}>
          <label>Chest: </label>
          <div className={classes.measurement_inputUnit}>
            <input type="text" className={classes.input} ref={chestRef}></input>
            <span>cm</span>
          </div>
        </div>
        <div className={classes.measurement}>
          <label>Waist: </label>
          <div className={classes.measurement_inputUnit}>
            <input type="text" className={classes.input} ref={waistRef}></input>
            <span>cm</span>
          </div>
        </div>
        <div className={classes.measurement}>
          <label>Thigh: </label>
          <div className={classes.measurement_inputUnit}>
            <input type="text" className={classes.input} ref={thighRef}></input>
            <span>cm</span>
          </div>
        </div>
        <div className={classes.measurement}>
          <label>Calf: </label>
          <div className={classes.measurement_inputUnit}>
            <input type="text" className={classes.input} ref={calfRef}></input>
            <span>cm</span>
          </div>
        </div>

        <div className={utils.rightContainer}>
          <button className={utils.greenButton} onClick={saveMeasurement}>
            Save
          </button>
        </div>
      </div>
    </div>
  );
};

export default NewMeasurement;
