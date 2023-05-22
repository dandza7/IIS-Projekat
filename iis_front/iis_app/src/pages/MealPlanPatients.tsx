import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Patients.module.css";
import { useNavigate } from "react-router-dom";
import dayjs, { Dayjs } from "dayjs";

import utils from "./Utils.module.css";

const MealPlanPatients = () => {
  const [users, setUsers] = useState<any[]>([]);
  const [selected, setSelected] = useState(null);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const typeRef = useRef();

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/profiles", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: 0,
        page: 0,
        order: [
          {
            orderField: "ID",
            ordering: "ASC",
          },
        ],
        filters: [
          {
            property: "Role",
            connecting: 0,
            filterValues: [
              {
                value: "CUSTOMER",
                operation: 1,
              },
            ],
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setUsers(actualData.items);
      });
  }, []);

  const openMealPlanHandler = (email: string) => {
    localStorage.setItem("patientEmail", email);
    navigate("/meal-plan");
  };

  return (
    <div className={classes.users}>
      <p className={utils.title}>Patients</p>
      {users && (
        <div className={utils.tableContainer}>
          <table className={utils.styledTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Surname</th>
                <th>Birth date</th>
                <th>Gender</th>
                <th></th>
                <th></th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {users.map((patient, index) => (
                <tr key={index}>
                  <td>{patient.name}</td>
                  <td>{patient.surname}</td>
                  <td>{dayjs(patient.birthDate).format("MMM D, YYYY")}</td>
                  <td>{patient.gender}</td>
                  <td></td>
                  <td></td>
                  <td>
                    <button
                      className={utils.blackButton}
                      onClick={() => openMealPlanHandler(patient.email)}
                    >
                      Meal plan
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

export default MealPlanPatients;
