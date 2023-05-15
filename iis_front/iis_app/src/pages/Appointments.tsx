import React from "react";
import classes from "./Appointments.module.css";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { useNavigate } from "react-router-dom";
import dayjs, { Dayjs } from "dayjs";
import utils from "./Utils.module.css";

const Appointments = () => {
  const [appointments, setAppointments] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/appointments", {
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
        setAppointments(actualData.items);
      });
  }, []);

  return (
    <div className={classes.appointments}>
      <p className={utils.title}>Appointments</p>
      {appointments && (
        <div className={utils.tableContainer}>
          <table className={utils.styledTable}>
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
                  <td>{appointment.patient.name}</td>
                  <td>{appointment.patient.surname}</td>
                  <td>
                    {dayjs(appointment.beginning).format(
                      "ddd, MMM D, YYYY h:mm A"
                    )}
                  </td>
                  <td>
                    {dayjs(appointment.ending).format(
                      "ddd, MMM D, YYYY h:mm A"
                    )}
                  </td>
                  <td>Regular</td>
                  <td>
                    <button className={utils.greenButton}>Start</button>
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
