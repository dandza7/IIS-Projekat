import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";

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
    width: 400,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
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
        <div className={utils.title}>Diagnoses and allergies</div>
        <div className={utils.buttonContainerRight}>
          {!toggleAllergies && (
            <>
              <button
                className={utils.blackButton}
                onClick={toggleAllergiesHandler}
              >
                View allergies
              </button>
              <button className={utils.blackButton}>Add Diagnose</button>
            </>
          )}
          {toggleAllergies && (
            <>
              <button
                className={utils.blackButton}
                onClick={toggleAllergiesHandler}
              >
                View Diagnoses
              </button>
              <button className={utils.blackButton} onClick={handleOpen}>
                Add Allergy
              </button>
            </>
          )}
        </div>
        {!toggleAllergies && (
          <div className={classes.dalContainer}>
            <table className={utils.styledTable}>
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
            <table className={utils.styledTable}>
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
          <div className={utils.modal}>
            <div className={utils.modalTitle}>
              <h2>Add allergy</h2>
            </div>
            <div className={utils.modalContainer}>
              <form className={classes.form} onSubmit={addAllergyHandler}>
                <span className={classes.span}>
                  <label>Name </label>
                  <input
                    ref={nameRef}
                    type="text"
                    className={classes.input}
                  ></input>
                </span>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleClose}
                  >
                    Cancel
                  </button>
                  <button type="submit" className={utils.greenButton}>
                    Add
                  </button>
                </div>
              </form>
            </div>
          </div>
        </Box>
      </Modal>
    </>
  );
};

export default DiagnosesAndAllergies;
