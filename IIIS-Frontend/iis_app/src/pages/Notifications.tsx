import React from "react";
import classes from "./styles/Notifications.module.css";
import { useState, useEffect, useContext } from "react";
import AuthContext from "../store/auth-context";
import Pagination from "../components/Utils/Pagination";
import dayjs from "dayjs";
const Notifications = () => {
  const authCtx = useContext(AuthContext);
  const [notifications, setNotifications] = useState<any[]>([]);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const pageSize = 5;

  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/notification/notifications", {
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
        setNotifications(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Notifications</h2>
        <br></br>
        <div className={classes.notifications}>
          <table className={classes.notificationTable}>
            <thead>
              <tr>
                <th></th>
                <th>Date</th>
                <th>Content</th>
              </tr>
            </thead>
            <tbody>
              {notifications?.map((notification) => (
                <tr key={notification.id}>
                  <td>
                    <input type="checkbox"></input>
                  </td>
                  <td>
                    <span>
                      {dayjs(notification.createdDate).format("DD.MM.YYYY.")}
                    </span>
                  </td>
                  <td>
                    <span className={classes.notificationContent}>
                      {notification.content}
                    </span>
                  </td>
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

export default Notifications;
