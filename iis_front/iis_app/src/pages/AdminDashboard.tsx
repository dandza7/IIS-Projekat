import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import classes from "./Orders.module.css";
import AddIcon from "@mui/icons-material/Add";
import utils from "./Utils.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import { useActionData } from "react-router-dom";
import AuthContext from "../store/auth-context";
import dayjs, { Dayjs } from "dayjs";
import JsPDF from "jspdf";
import html2canvas from "html2canvas";

const AdminDashboard = () => {
  const authCtx = useContext(AuthContext);
  const [openExercises, setOpenExercises] = React.useState(false);
  const [openOrder, setOpenOrder] = React.useState(false);
  const [selectedPlan, setSelectedPlan] = useState(null);
  const [selectedPlans, setSelectedPlans] = useState<number[]>([]);
  const [orders, setOrders] = useState<any>({});

  const fetchPlanDetails = (id: number) => {
    fetch("http://localhost:5041/api/nutritions/detailed/" + id, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        setSelectedPlan(actualData);
      });
  };

  const fetchOrders = () => {
    console.log(selectedPlans);
    fetch("http://localhost:5041/api/food-ordering/new", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({ nutritionPlansIds: selectedPlans }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setOrders(actualData);
      });
  };

  const handleViewDetailedPlan = (id: number) => {
    setOpenExercises(true);
    fetchPlanDetails(id);
  };

  const handleViewOrder = () => {
    setOpenOrder(true);
    fetchOrders();
  };

  const handleCloseExercises = () => {
    setOpenExercises(false);
  };
  const handleCloseOrder = () => {
    setOpenOrder(false);
  };
  const [mealPlans, setMealPlans] = useState<any>([]);

  const handleManageMealPlans = (id: number) => {
    const plans = selectedPlans;
    var newPlans = [];
    if (!plans.includes(id)) {
      newPlans = plans;
      plans.push(id);
      newPlans = plans;
    } else {
      newPlans = plans.filter((plan) => plan !== id);
    }
    setSelectedPlans(newPlans);
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/nutritions/1", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        setMealPlans(actualData.items);
      });
  }, []);

  const orderHandler = (toOrder: boolean) => {
    fetch("http://localhost:5041/api/food-ordering/confirm", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        id: orders.reportId,
        plansIds: orders.plansIds,
        toConfirm: toOrder,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        alert("Success!");
      });
  };

  const generatePDF = () => {
    const input = document.getElementById("report");
    html2canvas(input).then((canvas) => {
      const imgData = canvas.toDataURL("image/png");
      const pdf = new JsPDF();
      pdf.addImage(imgData, "PNG", 0, 0, 210, 90);
      pdf.save("download.pdf");
    });
  };

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
  const styleOrder = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 1350,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  return (
    <div>
      <p className={utils.title}>Food Procurement</p>
      <div className={utils.buttonContainerRight}>
        <button className={utils.blackButton} onClick={handleViewOrder}>
          Calculate
        </button>
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
          <div>
            <div className={utils.modal}>
              <div className={classes.form}>
                <div className={utils.modalTitle}>
                  <h2>Meal plan</h2>
                </div>

                <div className={utils.modalContainer}>
                  <div className={classes.dalContainer}>
                    <div className={classes.tableContainer}>
                      <table className={classes.styledTable}>
                        <thead>
                          <tr>
                            <th>Name</th>
                            <th>Amount</th>
                          </tr>
                        </thead>
                        <tbody>
                          {selectedPlan?.ingredients.map(
                            (ingredient, index) => (
                              <tr key={index}>
                                <td>{ingredient.name}</td>
                                <td>{ingredient.amount}</td>
                              </tr>
                            )
                          )}
                        </tbody>
                      </table>
                      <div className={classes.exerciseContainer}></div>
                    </div>
                  </div>
                  <br></br>
                  <div className={utils.buttonContainerRight}>
                    <button
                      className={classes.lightGreyButton}
                      onClick={handleCloseExercises}
                    >
                      Close
                    </button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
      <Modal
        open={openOrder}
        onClose={handleCloseOrder}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={styleOrder}>
          <div>
            <div className={utils.modal}>
              <div className={classes.form}>
                <div className={utils.modalTitle}>
                  <h2>Order details</h2>
                </div>

                <div className={utils.modalContainer}>
                  <div className={classes.dalContainer}>
                    <div className={classes.tableContainer}>
                      <div id="report">
                        <table className={classes.styledTable}>
                          <thead>
                            <tr>
                              <th>Name</th>
                              <th>Amount</th>
                              <th>Supplier</th>
                              <th>Price</th>
                              <th>Total Price</th>
                            </tr>
                          </thead>
                          <tbody>
                            {orders?.foodOrders?.map((ingredient, index) => (
                              <tr key={index}>
                                <td>{ingredient.foodName}</td>
                                <td>{ingredient.amount}</td>
                                <td>{ingredient.supplier}</td>
                                <td>{ingredient.price}</td>
                                <td>{ingredient.price * ingredient.amount}</td>
                              </tr>
                            ))}
                          </tbody>
                        </table>
                        <div className={classes.orderContainer}>
                          <div className={utils.span}>
                            <span>Delivery date:</span>
                            <span>
                              {dayjs(orders?.deliveryDate).format("DD-MM-YYYY")}
                            </span>
                          </div>
                          <div className={utils.span}>
                            <span>Total price:</span>
                            <span>{orders?.totalPrice}</span>
                          </div>
                        </div>
                      </div>
                      <div className={classes.buttonContainer}>
                        <button
                          className={utils.redButton}
                          onClick={() => orderHandler(false)}
                        >
                          Cancel
                        </button>
                        <button
                          className={utils.greenButton}
                          onClick={() => orderHandler(true)}
                        >
                          Order
                        </button>
                        <button
                          onClick={generatePDF}
                          type="button"
                          className={utils.blackButton}
                        >
                          Export PDF
                        </button>
                      </div>
                    </div>
                  </div>
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
