import React from "react";
import classes from "./Appointments.module.css";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useNavigate } from "react-router-dom";

const appointments = [
  {
    name: "Petar",
    surname: "Petorivc",
    start: new Date().toJSON(),
    end: new Date().toJSON(),
  },
  {
    name: "Milos",
    surname: "Milosevic",
    start: new Date().toJSON(),
    end: new Date().toJSON(),
  },
];

const Appointments = () => {
  const [users, setUsers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/users", {
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

  return (
    <div className={classes.appointments}>
      <p className={classes.title}>Appointments</p>
      {appointments && (
        <div className={classes.userTableContainer}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Surname</th>
                <th>Start</th>
                <th>End</th>
                <th>Type</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {appointments.map((appointment, index) => (
                <tr key={index}>
                  <td>{appointment.name}</td>
                  <td>{appointment.surname}</td>
                  <td>{appointment.start}</td>
                  <td>{appointment.start}</td>
                  <td>Regular</td>
                  <td>
                    <button className={classes.startButton}>Start</button>
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

export default Appointments;
