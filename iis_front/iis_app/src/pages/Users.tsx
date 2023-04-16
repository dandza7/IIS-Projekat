import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Users.module.css";
import { useNavigate } from "react-router-dom";

export const Users = () => {
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
        setUsers(actualData.items);
      });
  }, []);

  const handleViewUserProfile = (id: number) => {
    console.log(id);
    navigate("/users/" + id);
  };

  return (
    <div className={classes.users}>
      <p className={classes.title}>Users</p>
      {users && (
        <div className={classes.userTableContainer}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Id</th>
                <th>Email</th>
                <th>Role</th>
                <th>Profile</th>
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
                      className={classes.viewProfileButton}
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
