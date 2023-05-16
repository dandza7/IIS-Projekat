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
import utils from "./Utils.module.css";

export const Patients = () => {
  const [users, setUsers] = useState<any[]>([]);
  const [selected, setSelected] = useState(null);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const typeRef = useRef();

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/profiles", {
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
    width: 500,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  const [open, setOpen] = React.useState(false);
  const handleOpen = (email: any) => {
    setOpen(true);
    setSelected(email);
  };
  const handleClose = () => setOpen(false);

  const [value, setValue] = React.useState<Dayjs | null>(dayjs("2023-05-14"));

  const scheduleAppointmentHandler = () => {
    const type = typeRef.current.value;
    let beginning = dayjs(value).format("YYYY-MM-DDTHH:mm:ss.sss[Z]");
    let ending1 = value?.add(1, "hour");
    let ending = dayjs(ending1).format("YYYY-MM-DDTHH:mm:ss.sss[Z]");
    event?.preventDefault();
    console.log(selected);
    console.log(value);
    fetch("http://localhost:5041/api/appointments/new", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        patientEmail: selected,
        reportMessage: type,
        beginning: beginning,
        ending: ending,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("Success");
      });
  };

  return (
    <div className={classes.users}>
      <p className={utils.title}>Patients</p>
      {users && (
        <div className={utils.tableContainer}>
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
                <th></th>
              </tr>
            </thead>
            <tbody>
              {users.map((patient, index) => (
                <tr key={index}>
                  <td>{patient.name}</td>
                  <td>{patient.surname}</td>
                  <td>{dayjs(patient.birthDate).format("MMM D, YYYY")}</td>
                  <td>{patient.gender}</td>
                  <td></td>
                  <td></td>
                  <td>
                    <button className={utils.greenButton}>
                      Medical Record
                    </button>
                  </td>
                  <td>
                    <button
                      className={utils.blackButton}
                      onClick={() => handleOpen(patient.email)}
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
          <div className={utils.modal}>
            <div className={utils.modalTitle}>
              <h2>New appointment</h2>
            </div>
            <div className={utils.modalContainer}>
              <form
                className={classes.form}
                onSubmit={scheduleAppointmentHandler}
              >
                <span>Date: </span>
                <div className={classes.container}>
                  <LocalizationProvider dateAdapter={AdapterDayjs}>
                    <DateTimePicker
                      renderInput={(props) => <TextField {...props} />}
                      value={value}
                      onChange={(newValue) => {
                        setValue(newValue);
                      }}
                    />
                  </LocalizationProvider>
                </div>
                <span>Type: </span>
                <select className={utils.selectType} ref={typeRef}>
                  <option>Regular</option>
                  <option>Spa</option>
                </select>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleClose}
                  >
                    Cancel
                  </button>
                  <button type="submit" className={utils.greenButton}>
                    Schedule
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
