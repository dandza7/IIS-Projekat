import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Users.module.css";
import { useNavigate } from "react-router-dom";

const Exercises = () => {
  const [exercises, setExercises] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/exercise", {
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
        setExercises(actualData.items);
      });
  }, [exercises]);

  const handleButtonClick = () => {
    navigate("/new-exercise");
  };

  const deleteExerciseHandler = (id: any) => {
    console.log(id);
    fetch("http://localhost:5041/api/exercise/delete/" + id, {
      method: "DELETE",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("You successfully deleted exercise!");
      });
  };

  return (
    <div className={classes.users}>
      <p className={classes.title}>Exercises</p>
      <button className={classes.addButton} onClick={handleButtonClick}>
        Add Exercise
      </button>
      {exercises && (
        <div className={classes.userTableContainer}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Id</th>
                <th>Name</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {exercises.map((exercise) => (
                <tr key={exercise.id}>
                  <td>{exercise.id}</td>
                  <td>{exercise.name}</td>
                  <td>
                    <button
                      className={classes.viewProfileButton}
                      onClick={() => deleteExerciseHandler(exercise.id)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      )}
    </div>
  );
};

export default Exercises;
