import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import classes from "./Appointments.module.css";
import AddIcon from "@mui/icons-material/Add";
import utils from "./Utils.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import { useActionData } from "react-router-dom";
import AuthContext from "../store/auth-context";
import dayjs, { Dayjs } from "dayjs";

const AdminDashboard = () => {
  const authCtx = useContext(AuthContext);
  const [openExercises, setOpenExercises] = React.useState(false);
  const [selectedPlan, setSelectedPlan] = useState(null);
  const [selectedPlans, setSelectedPlans] = useState<number[]>([]);
  const fetchPlanDetails = (id: number) => {
    fetch("http://localhost:5041/api/nutritions/" + id, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setSelectedPlan(actualData);
      });
  };

  const handleViewDetailedPlan = (id: number) => {
    setOpenExercises(true);
    fetchPlanDetails(id);
  };
  const handleCloseExercises = () => {
    setOpenExercises(false);
  };

  const [mealPlans, setMealPlans] = useState<any>([]);

  const handleManageMealPlans = (id: number) => {
    console.log(id);
    const plans = selectedPlans;
    var newPlans = [];
    if (!plans.includes(id)) {
      console.log("nema");
      newPlans = plans;
      plans.push(id);
      newPlans = plans;
    } else {
      newPlans = plans.filter((plan) => plan !== id);
    }
    console.log(newPlans);
    setSelectedPlans(newPlans);
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/nutritions", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setMealPlans(actualData);
      });
  }, []);

  const styleEX = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 590,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  return (
    <div>
      <p className={utils.title}>Food Procurement</p>
      <div className={utils.buttonContainerRight}>
        <button className={utils.blackButton}>Calculate</button>
      </div>
      <table className={utils.styledTable}>
        <thead>
          <tr>
            <th>Meal plan Id</th>
            <th>Date</th>
            <th>Patient</th>
            <th></th>
            <th>Select</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {mealPlans.map((mp: any, index) => (
            <tr key={index}>
              <td>{mp.id}</td>
              <td> {dayjs(mp.date).format("ddd, MMM D, YYYY ")}</td>
              <td>{mp.userEmail}</td>
              <td></td>
              <td>
                {" "}
                <input
                  type="checkbox"
                  className={classes.checkBox}
                  onChange={() => handleManageMealPlans(mp.id)}
                />
              </td>
              <td>
                <button
                  className={utils.greenButton}
                  onClick={() => handleViewDetailedPlan(mp.id)}
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
                      <tbody>
                        {selectedPlan?.ingredients.map((ingredient, index) => (
                          <tr key={index}>
                            <td>{ingredient.name}</td>
                            <td>{ingredient.amount}</td>
                          </tr>
                        ))}
                      </tbody>
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
