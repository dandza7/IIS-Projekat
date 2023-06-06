import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Users.module.css";
import utils from "./Utils.module.css";
import { useNavigate } from "react-router-dom";
import dayjs, { Dayjs } from "dayjs";

const MyMealPlan = () => {
  const [users, setUsers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5041/api/nutritions", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        userId: 5,
        date: dayjs(new Date()).format("YYYY-MM-DD"),
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setBreakfast(actualData.breakfasts);
        setLunch(actualData.lunches);
        setDinner(actualData.dinners);
        setSnacks(actualData.snacks);
        let plan: recipe[] = [];
        let plan1 = plan.concat(
          actualData.breakfasts,
          actualData.lunches,
          actualData.dinners,
          actualData.snacks
        );
        setWholePlan(plan1);
      });
  }, []);

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
                  <td>Breakfast1, Breakfast2, Breakfast3 </td>
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

export default MyMealPlan;
