import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import { useParams } from "react-router-dom";
import AuthContext from "../store/auth-context";
import classes from "./Profile.module.css";
import EditIcon from "@mui/icons-material/Edit";
import utils from "./Utils.module.css";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { DatePicker } from "@mui/x-date-pickers/DatePicker";
import dayjs, { Dayjs } from "dayjs";

const Profile = () => {
  const [user, setUser] = useState<User>({});
  const authCtx = useContext(AuthContext);
  const [toggleEdit, setToggleEdit] = useState<any>(false);
  const [saved, setSaved] = useState<any>(false);
  const nameInputRef = useRef<any>(null);
  const surnameInputRef = useRef<any>(null);
  const genderInputRef = useRef<any>(null);
  const roleRef = useRef(null);
  const genderRef = useRef<any>(null);
  const [value, setValue] = React.useState<Dayjs | null>(dayjs("2023-05-14"));

  type User = {
    email: string;
    name: string;
    surname: string;
    birthDate: Date;
    gender: string;
    role: string;
  };
  const genders = ["Female", "Male"];
  const roleOptions = [
    "ADMIN",
    "CUSTOMER",
    "NUTRITIONIST",
    "TRAINER",
    "PHYSIOTHERAPIST",
  ];

  const handleToggleEdit = () => {
    setToggleEdit(true);
  };
  const handleCloseEdit = () => {
    setSaved(false);
    setToggleEdit(false);
  };
  const params = useParams();

  useEffect(() => {
    const userId = params.userId;
    fetch("http://localhost:5041/api/profiles/" + userId, {
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

  const handleSaveChanges = () => {
    const enteredName = nameInputRef.current.value;
    const enteredSurname = surnameInputRef.current.value;
    const enteredGender = genderRef.current.value;
    event?.preventDefault();
    fetch("http://localhost:5041/api/profiles/update", {
      method: "PUT",
      body: JSON.stringify({
        userId: params.userId,
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
  const handleChangeRole = () => {
    console.log(roleRef);
    const newRole = roleRef.current.value;
    fetch("http://localhost:5041/api/users/role-update", {
      method: "POST",
      body: JSON.stringify({
        id: params.userId,
        role: newRole,
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

  return (
    <>
      {!toggleEdit && (
        <div className={classes.myProfile}>
          <div className={utils.title}>User Profile</div>
          <div className={classes.inputContainerVertical}>
            <div className={classes.inputContainer}>
              <div className={classes.avatar}></div>
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
                  <span>{dayjs(user.birthDate).format("DD.MM.YYYY")}</span>
                </div>
              </div>
            </div>
            <button className={utils.blackButton} onClick={handleToggleEdit}>
              Edit Profile
            </button>
          </div>
        </div>
      )}
      {toggleEdit && (
        <div className={classes.myProfile}>
          <div className={utils.title}>Edit User Profile</div>
          <div className={classes.inputContainerVertical}>
            <div className={classes.span}>
              <span>Name: </span>
              <input
                ref={nameInputRef}
                defaultValue={user.name}
                className={classes.input}
              ></input>
            </div>
            <div className={classes.span}>
              <span>Surname: </span>
              <input
                ref={surnameInputRef}
                defaultValue={user.surname}
                className={classes.input}
              ></input>
            </div>
            <div className={classes.span}>
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
            <div className={classes.span}>
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
              <button className={utils.blackButton}>Change avatar</button>
              <button className={utils.blackButton} onClick={handleChangeRole}>
                Change role
              </button>
              <button className={utils.greenButton} onClick={handleSaveChanges}>
                Save
              </button>
              <button className={utils.redButton} onClick={handleCloseEdit}>
                Close
              </button>
            </div>
          </div>
        </div>
      )}
    </>
  );
};

export default Profile;
