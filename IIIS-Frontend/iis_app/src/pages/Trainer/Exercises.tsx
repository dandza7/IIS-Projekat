import React from "react";
import classes from "./styles/Exercises.module.css";
import { useState, useEffect, useContext } from "react";
import AuthContext from "../../store/auth-context";
import Pagination from "../../components/Utils/Pagination";
import dayjs from "dayjs";
import utils from "../styles/Utils.module.css";
import { useNavigate } from "react-router";

const Exercises = () => {
  const authCtx = useContext(AuthContext);
  const [exercises, setExercises] = useState<any[]>([]);
  const [totalCount, setTotalCount] = useState(0);
  const [selectedPage, setSelectedPage] = useState(1);
  const pageSize = 5;
  const navigate = useNavigate();
  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/exercise", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: pageSize,
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
        console.log(actualData);
        setExercises(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Exercises</h2>

        <div className={utils.rightContainer}>
          <button
            className={utils.greenButton}
            onClick={() => {
              navigate("/new-exercise");
            }}
          >
            Add
          </button>
        </div>
        <br></br>
        <div className={classes.exercises}>
          <table className={classes.exercisesTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Primary muscle group</th>
                <th>Type</th>
              </tr>
            </thead>
            <tbody>
              {exercises?.map((exercise) => (
                <tr key={exercise.id}>
                  <td>{exercise.name}</td>
                  <td>{exercise.primaryMuscleGroup}</td>
                  <td>{exercise.type}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
        {totalCount > pageSize && (
          <Pagination
            change={changePage}
            totalCount={totalCount}
            pageSize={pageSize}
            currentPage={selectedPage}
          ></Pagination>
        )}
      </div>
    </div>
  );
};

export default Exercises;
