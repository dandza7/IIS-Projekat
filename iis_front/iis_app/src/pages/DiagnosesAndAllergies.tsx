import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";

const DiagnosesAndAllergies = () => {
  const diagnosisList = [
    { code: 50, name: "Ulcerative Colitis" },
    { code: 150, name: "Gastritis" },
    { code: 300, name: "Diabetes" },
  ];

  const allergies = ["Gluten", "Grain", "Nuts", "Walnut"];

  return (
    <div className={classes.dal}>
      <div className={classes.dalTitle}>Diagnoses and allergies</div>
      <div className={classes.dalContainer}>
        <div className={classes.item1}>
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
        <div>
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
      </div>
    </div>
  );
};

export default DiagnosesAndAllergies;
