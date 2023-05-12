import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Patients.module.css";
import { useNavigate } from "react-router-dom";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";

const patients = [
  {
    name: "Petar",
    surname: "Petorivc",
    birthDate: new Date().toJSON(),
  },
  {
    name: "Milos",
    surname: "Milosevic",
    birthDate: new Date().toJSON(),
  },
];

export const Patients = () => {
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
        console.log(actualData.items);
        setUsers(actualData.items);
      });
  }, []);

  const handleViewUserProfile = (id: number) => {
    console.log(id);
    navigate("/users/" + id);
  };

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 1000,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 4,
  };

  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  return (
    <div className={classes.users}>
      <p className={classes.title}>Users</p>
      {users && (
        <div className={classes.userTableContainer}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Role</th>
                <th>Profile</th>
                <th></th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {patients.map((patient, index) => (
                <tr key={index}>
                  <td>{patient.name}</td>
                  <td>{patient.surname}</td>
                  <td>{patient.birthDate}</td>
                  <td>
                    <button className={classes.viewProfileButton}>
                      Medical Record
                    </button>
                  </td>
                  <td>
                    <button
                      className={classes.viewProfileButton}
                      onClick={handleOpen}
                    >
                      New Appointment
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
          <div>
            <div className={classes.title}>Add new food</div>
            <div>
              <form className={classes.form}>
                <div className={classes.nutrientsContainer}></div>
                <div className={classes.buttonContainer}>
                  <button type="submit" className={classes.addButton}>
                    Schedule Appointment
                  </button>
                </div>
              </form>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};
