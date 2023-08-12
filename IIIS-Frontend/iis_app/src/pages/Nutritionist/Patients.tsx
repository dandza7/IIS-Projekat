import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../../store/auth-context";
import classes from "./styles/Patients.module.css";
import { useNavigate } from "react-router-dom";
import dayjs, { Dayjs } from "dayjs";
import Pagination from "../../components/Utils/Pagination";
import utils from "../styles/Utils.module.css";

const Patients = () => {
  const pageSize = 5;
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
        pageSize: pageSize,
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
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        setUsers(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  const openMealPlanHandler = (id: number) => {
    navigate("/meal-plan/" + id);
  };

  return (
    <div className={utils.whiteContainer}>
      <h2>Patients</h2>
      {users && (
        <div className={utils.tableContainer}>
          <table className={classes.patientsTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Birth date</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {users.map((patient, index) => (
                <tr key={index}>
                  <td>{`${patient?.name} ${patient?.surname}`}</td>
                  <td>{dayjs(patient?.birthDate).format("MMM D, YYYY")}</td>
                  <td>
                    <button
                      className={classes.mealPlanButton}
                      onClick={() => openMealPlanHandler(patient.id)}
                    >
                      Meal plan
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
          {totalCount > pageSize && (
            <Pagination
              change={changePage}
              totalCount={totalCount}
              pageSize={pageSize}
              currentPage={selectedPage}
            ></Pagination>
          )}
        </div>
      )}
    </div>
  );
};
export default Patients;
