import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Users.module.css";
import utils from "./Utils.module.css";
import { useNavigate } from "react-router-dom";
import dayjs from "dayjs";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";

const Notifications = () => {
  const [notifications, setNotifications] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const [selectedNotification, setSelectedNotification] = useState(null);
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 400,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.4,
    borderRadius: 3,
  };

  const fetchNotifications = () => {
    fetch("http://localhost:5041/api/notification/notifications", {
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
        setNotifications(actualData.items);
      });
  };

  useEffect(() => {
    fetchNotifications();
  }, []);

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
    <div className={classes.users}>
      <p className={utils.title}>Notifications</p>
      {notifications && (
        <div className={utils.userTableContainer}>
          <div className={utils.buttonContainerRight}>
            <button className={utils.blackButton}>Mark as read</button>
            <button className={utils.redButton}>Delete</button>
          </div>
          <table className={utils.styledTable}>
            <thead>
              <tr>
                <th></th>
                <th>Content</th>
                <th>Date</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {notifications.map((notification, index) => (
                <tr key={notification.id}>
                  <td>
                    <input type="checkbox"></input>
                  </td>
                  <td
                    className={
                      notification.isRead ? classes.read : classes.notRead
                    }
                  >
                    {notification.content}
                  </td>
                  <td>
                    {dayjs(notification.createdDate).format("DD.MM.YYYY")}
                  </td>
                  <td>
                    <button
                      className={utils.greenButton}
                      onClick={() => viewNotification(notification)}
                    >
                      View
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      )}
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={utils.modal}>
            <div className={utils.modalTitle}>
              <h2>Notification</h2>
            </div>
            <div className={utils.modalContainer}>
              <div className={classes.form}>
                <span className={classes.span}>
                  {selectedNotification?.content}
                </span>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button className={utils.whiteButton} onClick={handleClose}>
                    Close
                  </button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default Notifications;
