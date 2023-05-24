import React from "react";
import classes from "./Appointments.module.css";
import AddIcon from "@mui/icons-material/Add";
import utils from "./Utils.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";

const mealPlans = [
  { id: 1, userEmail: "email@gm.com", date: Date.now() },
  { id: 2, userEmail: "email@gm.com", date: Date.now() },
  { id: 3, userEmail: "email@gm.com", date: Date.now() },
];
const AdminDashboard = () => {
  const [openExercises, setOpenExercises] = React.useState(false);
  const handleOpenExercises = () => setOpenExercises(true);
  const handleCloseExercises = () => setOpenExercises(false);

  const styleEX = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 570,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  return (
    <div>
      <p className={utils.title}>Food Procurement</p>
      <table className={utils.styledTable}>
        <thead>
          <tr>
            <th>Meal plan Id</th>
            <th>Date</th>
            <th>Patient</th>
            <th></th>
            <th></th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {mealPlans.map((mg: any, index) => (
            <tr key={index}>
              <td>{mg.id}</td>
              <td>{mg.date}</td>
              <td>{mg.userEmail}</td>
              <td></td>
              <td></td>
              <td>
                <button
                  className={utils.greenButton}
                  onClick={handleOpenExercises}
                >
                  Details
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
      <Modal
        open={openExercises}
        onClose={handleCloseExercises}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={styleEX}>
          <div className={utils.modal}>
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Meal plan</h2>
              </div>

              <div className={utils.modalContainer}>
                <div className={classes.dalContainer}>
                  <div></div>
                  <div className={classes.tableContainer}>
                    <table className={classes.styledTable}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                        </tr>
                      </thead>
                      <tbody></tbody>
                    </table>
                    <div className={classes.exerciseContainer}></div>
                  </div>
                </div>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleCloseExercises}
                  >
                    Close
                  </button>
                  <button className={utils.greenButton}>Save</button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default AdminDashboard;
