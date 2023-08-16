import React from "react";
import classes from "./styles/Exercises.module.css";
import { useState, useRef, useEffect, useContext } from "react";
import AuthContext from "../../store/auth-context";
import utils from "../styles/Utils.module.css";

const NewExercise = () => {
  const authCtx = useContext(AuthContext);
  const [muscleGroups, setMuscleGroups] = useState<any[]>([]);
  const nameRef = useRef(null);
  const primarytargetRef = useRef(null);

  const [checked, setChecked] = useState<any[]>([]);

  const handleCheck = (event: any) => {
    var updatedList = [...checked];
    if (event.target.checked) {
      updatedList = [...checked, event.target.value];
    } else {
      updatedList.splice(checked.indexOf(event.target.value), 1);
    }
    setChecked(updatedList);
  };

  const handleSubmit = () => {
    event?.preventDefault();
    const enteredName = nameRef.current.value;
    const primaryTarget = primarytargetRef.current.value;

    fetch("http://localhost:5041/api/exercise/create", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        name: enteredName,
        primaryMuscleGroup: primaryTarget,
        secondaryMuscleGroups: checked,
        isHypertrophic: true,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("Exercise has been successfully created!");
      });
  };

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
        setMuscleGroups(actualData.items);
      });
  }, []);

  return (
    <div className={classes.whiteContainerNewExercise}>
      <h2>New exercise</h2>

      <form className={classes.nexExerciseForm} onSubmit={handleSubmit}>
        <div className={classes.inputContainer}>
          <label>Name of exercise: </label>
          <input type="text" ref={nameRef} className={classes.select}></input>
        </div>
        <div className={classes.inputContainer}>
          <label>Select primary target muscle: </label>
          <div className={classes.selectGrid}>
            <select ref={primarytargetRef} className={classes.select}>
              {muscleGroups.map((group, index) => {
                return <option key={index}>{group.name}</option>;
              })}
            </select>
          </div>
        </div>
        <div>
          <span>Secondary muscle groups: </span>
          <div className={classes.grid}>
            {muscleGroups.map((group, index) => {
              return (
                <div key={index} className={classes.secondaryMG}>
                  {" "}
                  <label>
                    <input
                      className={classes.secondaryMGCheckbox}
                      type="checkbox"
                      name={group.name}
                      value={group.name}
                      onChange={handleCheck}
                    ></input>
                    {group.name}
                  </label>
                </div>
              );
            })}
          </div>
        </div>
        <div className={utils.rightContainer}>
          <button type="submit" className={utils.greenButton}>
            Add Exercise
          </button>
        </div>
      </form>
    </div>
  );
};

export default NewExercise;
