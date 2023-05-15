import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import classes from "./Exercises.module.css";
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
  }, []);

  const handleButtonClick = () => {
    navigate("/new-exercise");
  };

  const fetchData = () => {
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
        fetchData();
      });
  };

  return (
    <div className={classes.exercises}>
      <p className={utils.title}>Exercises</p>
      <div className={utils.buttonContainerRight}>
        <button className={utils.blackButton} onClick={handleButtonClick}>
          Add Exercise
        </button>
      </div>
      {exercises && (
        <div className={utils.tableContainer}>
          <table className={utils.styledTable}>
            <thead>
              <tr>
                <th>Id</th>
                <th>Name</th>
                <th>asd</th>
              </tr>
            </thead>
            <tbody>
              {exercises.map((exercise) => (
                <tr key={exercise.id}>
                  <td>{exercise.id}</td>
                  <td>{exercise.name}</td>
                  <td>as</td>
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
