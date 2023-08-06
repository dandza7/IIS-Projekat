import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import classes from "./Exercises.module.css";
import { useNavigate } from "react-router-dom";
import Paginations from "../components/Paginations";

const Exercises = () => {
  const [exercises, setExercises] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);

  const changePage = (page: number) => {
    setSelectedPage(page);
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/exercise", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: 5,
        page: selectedPage,
        order: [
          {
            orderField: "ID",
            ordering: "ASC",
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        setExercises(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

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
        setExercises(actualData.items);
      });
  };

  const deleteExerciseHandler = (id: any) => {
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
                <th>Name</th>
                <th>Primary muscle group </th>
                <th>Type </th>
              </tr>
            </thead>
            <tbody>
              {exercises.map((exercise) => (
                <tr key={exercise.id}>
                  <td>{exercise.name}</td>
                  <td>{exercise.primaryMuscleGroup}</td>
                  <td>{exercise.type}</td>
                </tr>
              ))}
            </tbody>
          </table>
          <Paginations
            change={changePage}
            totalCount={totalCount}
          ></Paginations>
        </div>
      )}
    </div>
  );
};

export default Exercises;
