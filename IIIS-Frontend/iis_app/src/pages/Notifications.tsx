import React from "react";
import classes from "./styles/Notifications.module.css";
import { useState, useEffect, useContext } from "react";
import AuthContext from "../store/auth-context";
import Pagination from "../components/Utils/Pagination";
import dayjs from "dayjs";
import utils from "./styles/Utils.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";

const style = {
  position: "absolute" as "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "background.paper",
  boxShadow: 24,
  borderRadius: 3,
};

const Notifications = () => {
  const authCtx = useContext(AuthContext);
  const [notifications, setNotifications] = useState<any[]>([]);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedNotification, setSelectedNotification] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const pageSize = 5;
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  const fetchNotifications = () => {
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
  };

  useEffect(() => {
    fetchNotifications();
  }, [selectedPage]);

  const viewNotification = (notification: any) => {
    setSelectedNotification(notification);
    handleOpen();
    fetch("http://localhost:5041/api/notification/update/" + notification.id, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({}),
    })
      .then((response) => response.json())
      .then((actualData) => {
        authCtx.updateNotifications();
        fetchNotifications();
      });
  };

  return (
    <div>
      <div className={classes.whiteContainer}>
        <h2>Notifications</h2>

        <div className={classes.notifications}>
          <table className={classes.notificationTable}>
            <thead>
              <tr>
                <th>Date</th>
                <th>Content</th>
              </tr>
            </thead>
            <tbody>
              {notifications?.map((notification) => (
                <tr
                  key={notification.id}
                  onClick={() => viewNotification(notification)}
                >
                  <td>
                    <span>
                      {dayjs(notification.createdDate).format("DD.MM.YYYY.")}
                    </span>
                  </td>
                  <td>
                    <span
                      className={
                        notification.isRead
                          ? classes.notificationContent
                          : classes.notificationContentUnread
                      }
                    >
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
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Notification</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>
            <div className={utils.modalContainer}>
              <div className={classes.modalBody}>
                <div className={classes.span}>
                  {selectedNotification?.content}
                </div>
                <br></br>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default Notifications;
