import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { Users } from "./Users";
import classes from "./Profile.module.css";
import utils from "./Utils.module.css";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { DatePicker } from "@mui/x-date-pickers/DatePicker";
import dayjs, { Dayjs } from "dayjs";
import EditIcon from "@mui/icons-material/Edit";

const MyProfile = () => {
  const [user, setUser] = useState<User>({});
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
        birthDate: "2023-04-12T21:01:31.611Z",
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
        console.log(data);
        setSaved(true);
      });
  };

  useEffect(() => {
    console.log(authCtx.token);
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
        <div className={classes.myProfile}>
          <div className={utils.title}>My Profile</div>
          <div className={classes.inputContainerVertical}>
            <div className={classes.inputContainer}>
              <div>
                <div className={utils.avatarProfile}></div>
              </div>

              <div>
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
                  <span>{user.birthDate}</span>
                </div>
              </div>
            </div>
            <button className={utils.whiteButton} onClick={handleToggleEdit}>
              <EditIcon></EditIcon>
              Edit Profile
            </button>
          </div>
        </div>
      )}
      {toggleEdit && (
        <div className={classes.myProfile}>
          <div className={utils.title}>Edit Profile</div>
          <div className={classes.inputContainerVerticalEdit}>
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
                className={classes.select}
              >
                {genders.map((gender, index) => {
                  return <option key={index}>{gender}</option>;
                })}
              </select>
            </div>
            <div className={classes.spanEdit}>
              <span>Birthdate: </span>
              <div className={classes.container}>
                <LocalizationProvider dateAdapter={AdapterDayjs}>
                  <DatePicker
                    renderInput={(props) => <TextField {...props} />}
                    value={value}
                    onChange={(newValue) => {
                      setValue(newValue);
                    }}
                  />
                </LocalizationProvider>
              </div>
            </div>
            <div className={utils.buttonContainer}>
              <button className={utils.redButton} onClick={handleCloseEdit}>
                Close
              </button>
              <button className={utils.greenButton} onClick={handleSaveChanges}>
                Save
              </button>
            </div>
          </div>
        </div>
      )}
    </>
  );
};

export default MyProfile;
