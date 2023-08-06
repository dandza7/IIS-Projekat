import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Patients.module.css";
import { useNavigate } from "react-router-dom";
import dayjs, { Dayjs } from "dayjs";
import Paginations from "../components/Paginations";
import utils from "./Utils.module.css";

const MealPlanPatients = () => {
  const [users, setUsers] = useState<any[]>([]);
  const [selected, setSelected] = useState(null);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const typeRef = useRef();
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const [name, setName] = useState(null);
  const nameRef = useRef();
  const changePage = (page: number) => {
    setSelectedPage(page);
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/patients", {
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
          { 
            property: "Profile.Name",
            connecting: 0,
            filterValues: [
              {
                value: nameRef.current.value,
                operation: nameRef.current.value  ? 1 : 0,
              },
            ],
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        setUsers(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);



  const searchHandler = () =>{
    fetch("http://localhost:5041/api/patients", {
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
          {
            property: "Profile.Name",
            connecting: 0,
            filterValues: [
              {
                value: nameRef.current.value,
                operation: nameRef.current.value  ? 1 : 0,
              },
            ],
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        setUsers(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }


  const openMealPlanHandler = (id: number) => {
    localStorage.setItem("patientId", id);
    navigate("/meal-plan");
  };

  return (
    <div className={classes.users}>
      <p className={utils.title}>Patients</p>
      {users && (
        <div className={utils.tableContainer}>
          <div className={classes.containerCenter}>
          <input placeholder="Search for patients" className={classes.searchInput} ref={nameRef}></input>
          <button className={classes.searchButton} onClick={searchHandler}>Search</button>
          </div>
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
                  <td>{patient?.name}</td>
                  <td>{patient?.surname}</td>
                  <td>{dayjs(patient?.birthDate).format("MMM D, YYYY")}</td>
                  <td>{patient?.gender}</td>
                  <td></td>
                  <td></td>
                  <td>
                    <button
                      className={utils.greenButton}
                      onClick={() => openMealPlanHandler(patient.id)}
                    >
                      Meal plan
                    </button>
                  </td>
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

export default MealPlanPatients;
