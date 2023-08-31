import React from "react";
import classes from "./styles/Profile.module.css";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./styles/Utils.module.css";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { DatePicker } from "@mui/x-date-pickers/DatePicker";
import dayjs, { Dayjs } from "dayjs";
import EditIcon from "@mui/icons-material/Edit";
import EmailIcon from "@mui/icons-material/Email";
import Modal from "@mui/material/Modal";
import Box from "@mui/material/Box";

const style = {
  position: "absolute" as "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "background.paper",
  boxShadow: 24,
  p: 0.5,
  borderRadius: 3,
};

const Profile = () => {
  const [user, setUser] = useState<User>({});
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const authCtx = useContext(AuthContext);
  const [toggleEdit, setToggleEdit] = useState<any>(false);
  const [saved, setSaved] = useState<any>(false);
  const nameInputRef = useRef<any>(null);
  const surnameInputRef = useRef<any>(null);
  const genderRef = useRef<any>(null);
  const [value, setValue] = React.useState<Dayjs | null>(dayjs("2023-05-14"));
  const genders = ["Female", "Male"];

  type User = {
    email: string;
    name: string;
    surname: string;
    birthDate: Date;
    gender: string;
    role: string;
    isEmailSubsribed: boolean;
  };

  const handleToggleEdit = () => {
    setToggleEdit(true);
  };
  const handleCloseEdit = () => {
    setSaved(false);
    setToggleEdit(false);
  };
  const handleSaveChanges = () => {
    const enteredName = nameInputRef.current.value;
    const enteredSurname = surnameInputRef.current.value;
    const enteredGender = genderRef.current.value;
    event?.preventDefault();
    fetch("http://localhost:5041/api/profiles/update/own", {
      method: "PUT",
      body: JSON.stringify({
        name: enteredName,
        gender: enteredGender,
        surname: enteredSurname,
        birthDate: user.birthDate,
        biography: "",
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((res) => {
        if (res.ok) {
          console.log(res);
          return res;
        }
      })
      .then((data) => {
        setSaved(true);
      });
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/profiles", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setUser(actualData);
      });
  }, [saved]);

  return (
    <>
      {!toggleEdit && (
        <div className={classes.whiteContainer}>
          <h2>My Profile</h2>

          <div className={classes.fields}>
            <div className={classes.span}>
              <span>Name: </span>
              <span>{user.name}</span>
            </div>
            <div className={classes.span}>
              <span>Surname: </span>
              <span>{user.surname}</span>
            </div>
            <div className={classes.span}>
              <span>Email: </span>
              <span>{user.email}</span>
            </div>
            <div className={classes.span}>
              <span>Gender: </span>
              <span>{user.gender}</span>
            </div>
            <div className={classes.span}>
              <span>Birthdate: </span>
              <span>{dayjs(user.birthDate).format("DD.MM.YYYY")}</span>
            </div>
          </div>
          <br></br>
          <div className={utils.leftContainer}>
            <button className={utils.greenButton} onClick={handleToggleEdit}>
              Edit
            </button>
            {!user.isEmailSubsribed ? (
              <button
                className={utils.greenButton}
                onClick={() => {
                  handleOpen();
                }}
              >
                Verify email
              </button>
            ) : (
              <button className={utils.redButton} onClick={() => {}}>
                Unsubscribe
              </button>
            )}
          </div>
        </div>
      )}
      {toggleEdit && (
        <div className={classes.whiteContainer}>
          <h2>My Profile</h2>
          <div className={classes.fields}>
            <div className={classes.spanEdit}>
              <span>Name: </span>
              <input
                ref={nameInputRef}
                defaultValue={user.name}
                className={classes.input}
              ></input>
            </div>
            <div className={classes.spanEdit}>
              <span>Surname: </span>
              <input
                ref={surnameInputRef}
                defaultValue={user.surname}
                className={classes.input}
              ></input>
            </div>
            <div className={classes.spanEdit}>
              <span>Gender: </span>
              <select
                defaultValue={user.gender}
                ref={genderRef}
                className={utils.select}
              >
                {genders.map((gender, index) => {
                  return <option key={index}>{gender}</option>;
                })}
              </select>
            </div>
          </div>
          <br></br>
          <div className={utils.leftContainer}>
            <button className={utils.redButton} onClick={handleCloseEdit}>
              Close
            </button>
            <button className={utils.greenButton} onClick={handleSaveChanges}>
              Save
            </button>
          </div>
        </div>
      )}
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Verify email</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.form}>
                <h3>Check your email for code.</h3>
                <br></br>
                <label>Code: </label>
                <input className={classes.input}></input>
              </div>
              <br></br>
              <div className={utils.centerContainer}>
                <button className={utils.greenButton}>Send</button>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </>
  );
};

export default Profile;
