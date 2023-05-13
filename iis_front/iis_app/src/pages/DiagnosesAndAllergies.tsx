import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";

const DiagnosesAndAllergies = () => {
  const [toggleAllergies, setToggleAllergies] = useState(false);
  const [allergies, setAllergies] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/allergies", {
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
        setAllergies(actualData.items);
      });
  }, []);

  const diagnosisList = [
    { code: 50, name: "Ulcerative Colitis" },
    { code: 150, name: "Gastritis" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
    { code: 300, name: "Diabetes" },
  ];

  const allergiesPlaceholder = [
    "Gluten",
    "Grain",
    "Nuts",
    "Walnut",
    "Gluten",
    "Grain",
    "Nuts",
    "Walnut",
    "Gluten",
    "Grain",
    "Nuts",
    "Walnut",
  ];

  const toggleAllergiesHandler = () => {
    setToggleAllergies(!toggleAllergies);
  };

  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 300,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 4,
  };

  const nameRef = useRef(null);

  const addAllergyHandler = () => {
    event?.preventDefault();
    const name = nameRef.current.value;

    fetch("http://localhost:5041/api/allergies/new", {
      method: "POST",
      body: JSON.stringify({
        name: name,
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
        alert("You have succesfully added allergy!");
      });
  };

  return (
    <>
      <div className={classes.dal}>
        <div className={classes.dalTitle}>Diagnoses and allergies</div>
        <div className={classes.addDiagnosebuttonContainer}>
          {!toggleAllergies && (
            <>
              <button
                className={classes.addButton}
                onClick={toggleAllergiesHandler}
              >
                View allergies
              </button>
              <button className={classes.addDiagnoseButton}>
                Add Diagnose
              </button>
            </>
          )}
          {toggleAllergies && (
            <>
              <button
                className={classes.addButton}
                onClick={toggleAllergiesHandler}
              >
                View Diagnoses
              </button>
              <button
                className={classes.addDiagnoseButton}
                onClick={handleOpen}
              >
                Add Allergy
              </button>
            </>
          )}
        </div>
        {!toggleAllergies && (
          <div className={classes.dalContainer}>
            <table className={classes.styledTable}>
              <thead>
                <tr>
                  <th>Code</th>
                  <th>Name</th>
                </tr>
              </thead>
              <tbody>
                {diagnosisList.map((user) => (
                  <tr key={user.code}>
                    <td>{user.code}</td>
                    <td>{user.name}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        )}
        {toggleAllergies && (
          <div className={classes.dalContainer}>
            <table className={classes.styledTable}>
              <thead>
                <tr>
                  <th>Name</th>
                </tr>
              </thead>
              <tbody>
                {allergies.map((user, index) => (
                  <tr key={index}>
                    <td>{user.name}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        )}
      </div>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <form className={classes.modal} onSubmit={addAllergyHandler}>
            <div>
              <label>Name </label>
              <input ref={nameRef} type="text"></input>
            </div>
            <div className={classes.buttonContainer}>
              <button type="submit" className={classes.detailsButton}>
                Add
              </button>
            </div>
          </form>
        </Box>
      </Modal>
    </>
  );
};

export default DiagnosesAndAllergies;
