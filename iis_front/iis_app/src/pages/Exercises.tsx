import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Users.module.css";
import { useNavigate } from "react-router-dom";

const Exercises = () => {
  const [users, setUsers] = useState<any[]>([]);
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
        setUsers(actualData.items);
      });
  }, []);

  const handleButtonClick = () => {
    navigate("/new-exercise");
  };

  return (
    <div className={classes.users}>
      <p className={classes.title}>Exercises</p>
      <button className={classes.addButton} onClick={handleButtonClick}>
        Add Exercise
      </button>
      {users && (
        <div className={classes.userTableContainer}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Name</th>
              </tr>
            </thead>
            <tbody>
              {users.map((user) => (
                <tr key={user.id}>
                  <td>{user.name}</td>
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
