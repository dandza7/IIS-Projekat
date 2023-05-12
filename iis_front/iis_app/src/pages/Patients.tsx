import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Patients.module.css";
import { useNavigate } from "react-router-dom";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";
import dayjs, { Dayjs } from "dayjs";
import TextField from "@mui/material/TextField";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { DateTimePicker } from "@mui/x-date-pickers/DateTimePicker";

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
  const [selected, setSelected] = useState(null);
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
    width: 400,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 4,
  };

  const [open, setOpen] = React.useState(false);
  const handleOpen = (name: any) => {
    setOpen(true);
    setSelected(name);
  };
  const handleClose = () => setOpen(false);

  const [value, setValue] = React.useState<Dayjs | null>(dayjs("2022-04-07"));

  const scheduleAppointmentHandler = () => {
    event?.preventDefault();
    console.log(selected);
  };

  return (
    <div className={classes.users}>
      <p className={classes.title}>Patients</p>
      {users && (
        <div className={classes.userTableContainer}>
          <table className={classes.styledTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Surname</th>
                <th>Birth date</th>
                <th></th>
                <th></th>
                <th></th>
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
                  <td></td>
                  <td></td>
                  <td></td>
                  <td>
                    <button className={classes.viewProfileButton}>
                      Medical Record
                    </button>
                  </td>
                  <td>
                    <button
                      className={classes.viewProfileButton}
                      onClick={() => handleOpen(patient.name)}
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
            <div className={classes.title}></div>
            <div>
              <form
                className={classes.form}
                onSubmit={scheduleAppointmentHandler}
              >
                <div className={classes.container}>
                  <LocalizationProvider dateAdapter={AdapterDayjs}>
                    <DateTimePicker
                      renderInput={(props) => <TextField {...props} />}
                      label="DateTimePicker"
                      value={value}
                      onChange={(newValue) => {
                        setValue(newValue);
                      }}
                    />
                  </LocalizationProvider>
                </div>
                <select>
                  <option>Regular</option>
                  <option>Spa</option>
                </select>
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
