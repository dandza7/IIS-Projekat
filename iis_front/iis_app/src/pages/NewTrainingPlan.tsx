import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./NewTrainingPlan.module.css";
import utils from "./Utils.module.css";
import { useNavigate } from "react-router-dom";

const NewTrainingPlan = () => {
  const [users, setUsers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/training-plan-request", {
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
            property: "Id",
            connecting: 0,
            filterValues: [
              {
                value: 8,
                operation: 0,
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

  const handleViewUserProfile = (id: number) => {
    console.log(id);
    navigate("/users/" + id);
  };

  return (
    <div className={classes.users}>
      <p className={utils.title}>Users</p>
      {users && (
        <div className={utils.userTableContainer}>
          <table className={utils.styledTable}>
            <thead>
              <tr>
                <th>Id</th>
                <th>Email</th>
                <th>Role</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {users.map((user) => (
                <tr key={user.id}>
                  <td>{user.id}</td>
                  <td>{user.email}</td>
                  <td>{user.role}</td>
                  <td>
                    <button
                      className={utils.greenButton}
                      onClick={() => handleViewUserProfile(user.id)}
                    >
                      View Profile
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

export default NewTrainingPlan;
