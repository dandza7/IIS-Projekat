import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import classes from "./Users.module.css";
import utils from "./Utils.module.css";
import { useNavigate } from "react-router-dom";
import dayjs, { Dayjs } from "dayjs";
import JsPDF from "jspdf";
import html2canvas from "html2canvas";

const MyMealPlan = () => {
  const [users, setUsers] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const [wholePlan, setWholePlan] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5041/api/nutritions/weekly", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setWholePlan(actualData);
      });
  }, []);

  const generatePDF = () => {
    const input = document.getElementById("report");
    html2canvas(input).then((canvas) => {
      const imgData = canvas.toDataURL("image/png");
      const pdf = new JsPDF();
      pdf.addImage(imgData, "PNG", 5, 5, 200, 80);
      pdf.save("download.pdf");
    });
  };

  return (
    <div>
      <div className={classes.users} id="report">
        <p className={utils.title}>Weekly meal plan</p>
        <div className={utils.userTableContainer}>
          <table className={utils.styledTable}>
            <thead>
              <tr>
                <th>Date</th>
                <th>Breakfast</th>
                <th>Lunch</th>
                <th>Dinner</th>
                <th>Snack</th>
              </tr>
            </thead>
            <tbody>
              {wholePlan.map((plan, index) => (
                <tr key={index}>
                  <td>{dayjs(plan.date).format("DD.MM.YYYY")}</td>
                  <td>
                    {plan.breakfasts.map((meal: any) => (
                      <span>{meal.recipe.name + ", "}</span>
                    ))}
                  </td>
                  <td>
                    {plan.lunches.map((meal: any) => (
                      <span>{meal.recipe.name + ", "}</span>
                    ))}
                  </td>
                  <td>
                    {plan.dinners.map((meal: any) => (
                      <span>{meal.recipe.name + ", "} </span>
                    ))}
                  </td>
                  <td>
                    {plan.snacks.map((meal: any) => (
                      <span>{meal.recipe.name + ", "}</span>
                    ))}
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>
      <br></br>
      <div className={utils.buttonContainerRight}>
        <button
          onClick={generatePDF}
          type="button"
          className={utils.blackButton}
        >
          Export PDF
        </button>
      </div>
    </div>
  );
};

export default MyMealPlan;
