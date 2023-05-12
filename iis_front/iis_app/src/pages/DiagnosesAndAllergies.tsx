import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";
import { useState } from "react";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";

const DiagnosesAndAllergies = () => {
  const [toggleAllergies, setToggleAllergies] = useState(false);

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

  const allergies = [
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
    width: 1000,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 4,
  };

  return (
    <>
      <div className={classes.dal}>
        <div className={classes.dalTitle}>Diagnoses and allergies</div>
        <span>Diagnoses</span>
        <div className={classes.addDiagnosebuttonContainer}>
          {!toggleAllergies && (
            <>
              <button
                className={classes.addButton}
                onClick={toggleAllergiesHandler}
              >
                View allergies
              </button>
              <button
                className={classes.addDiagnoseButton}
                onClick={handleOpen}
              >
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
              <button className={classes.addDiagnoseButton}>Add Allergy</button>
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
                    <td>{user}</td>
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
          <div>
            <label>Name </label>
            <input></input>
            <label>Name </label>
            <input></input>
          </div>
        </Box>
      </Modal>
    </>
  );
};

export default DiagnosesAndAllergies;
