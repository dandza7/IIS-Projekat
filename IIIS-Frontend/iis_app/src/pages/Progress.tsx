import React from "react";
import classes from "./Trainer/styles/TrainingPlan.module.css";
import { useEffect, useState, useRef, useContext } from "react";
import utils from "./styles/Utils.module.css";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
} from "chart.js";
import { Line } from "react-chartjs-2";
import faker from "faker";
import AuthContext from "../store/auth-context";
import dayjs from "dayjs";
import Select from "react-select";

const Progress = () => {
  const authCtx = useContext(AuthContext);
  const [statistics, setStatistics] = React.useState(null);
  const [selectedRange, setSelectedRange] = React.useState({
    value: "Month",
    label: "Month",
  });
  const [dates, setDates] = React.useState([]);
  const [bicep, setBicep] = React.useState([]);
  const [isBicep, setIsBicep] = useState(true);
  const [isChest, setIsChest] = useState(true);
  const [isForearm, setIsForearm] = useState(true);
  const [isWaist, setIsWaist] = useState(true);
  const [isCalf, setIsCalf] = useState(true);
  const [isThigh, setIsThigh] = useState(true);
  const [isWeight, setIsWeight] = useState(true);
  const [calf, setCalf] = React.useState([]);
  const [chest, setChest] = React.useState([]);
  const [forearm, setForearm] = React.useState([]);
  const [thigh, setThigh] = React.useState([]);
  const [waist, setWaist] = React.useState([]);
  const [weight, setWeight] = React.useState([]);
  const [reload, setReload] = useState(false);
  const periodOptions = [
    { label: "Month", value: "Month" },
    { label: "Year", value: "Year" },
  ];

  useEffect(() => {
    fetch("http://localhost:5041/api/measurement/getStatistics/" + 19, {
      method: "POST",
      body: JSON.stringify({
        timePeriod: selectedRange?.value,
        wantsWeight: true,
        wantsBicep: true,
        wantsForearm: true,
        wantsChest: true,
        wantsWaist: true,
        wantsThigh: true,
        wantsCalf: true,
        exerciseName: "False",
      }),
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setStatistics(actualData);
        let bicep = [];
        let calf = [];
        let forearm = [];
        let chest = [];
        let waist = [];
        let weight = [];
        let thigh = [];
        let dates = [];
        actualData.bicepStatistics.map((stat) => {
          bicep.push(stat.statistic);
          dates.push(dayjs(stat.date).format("DD.MM"));
        });
        actualData.calfStatistics.map((stat) => {
          calf.push(stat.statistic);
        });
        actualData.chestStatistics.map((stat) => {
          chest.push(stat.statistic);
        });
        actualData.forearmStatistics.map((stat) => {
          forearm.push(stat.statistic);
        });
        actualData.waistStatistics.map((stat) => {
          waist.push(stat.statistic);
        });
        actualData.weightStatistics.map((stat) => {
          weight.push(stat.statistic);
        });
        actualData.thighStatistics.map((stat) => {
          thigh.push(stat.statistic);
        });
        isBicep ? setBicep(bicep) : setBicep([]);
        setForearm(forearm);
        setCalf(calf);
        setThigh(thigh);
        setWeight(weight);
        setWaist(waist);
        setChest(chest);
        setDates(dates);
      });
  }, [selectedRange]);

  ChartJS.register(
    CategoryScale,
    LinearScale,
    PointElement,
    LineElement,
    Title,
    Tooltip,
    Legend
  );

  const options = {
    responsive: true,
    plugins: {
      legend: {
        display: false,
        position: "top" as const,
      },
    },
  };

  const labels = dates;

  const data = {
    labels,
    datasets: [
      isBicep && {
        label: "Bicep",
        data: bicep,
        borderColor: "#6600CC",
        backgroundColor: "rgba(255, 255, 255)",
      },
      isChest && {
        label: "Chest",

        data: chest,
        borderColor: "#0080FF",
        backgroundColor: "rgba(255, 255, 255)",
      },
      isForearm && {
        label: "Forearm",
        data: forearm,
        borderColor: "#00CC66",
        backgroundColor: "rgba(255, 255, 255)",
      },
      isWaist && {
        label: "Waist",
        data: waist,
        borderColor: "#9999FF",
        backgroundColor: "rgba(255, 255, 255)",
      },
      isCalf && {
        label: "Calf",
        data: calf,
        borderColor: "#FF9933",
        backgroundColor: "rgba(255, 255, 255)",
      },
      isThigh && {
        label: "Thigh",
        data: thigh,
        borderColor: "#FF3333",
        backgroundColor: "rgba(255, 255, 255)",
      },
      isWeight && {
        label: "Weight",
        data: weight,
        borderColor: "#FF3399",
        backgroundColor: "rgba(255, 255, 255)",
      },
    ],
  };

  return (
    <div className={utils.whiteContainer}>
      <div className={classes.titleBox}>
        <h2>My Progress</h2>
        <div className={utils.rightContainer}>
          <Select
            className={classes.selectRange}
            name="name"
            isClearable
            defaultValue={{ label: "Month", value: "Month" }}
            options={periodOptions}
            onChange={setSelectedRange}
            placeholder={"Select period..."}
          />
        </div>
      </div>
      <br></br>
      <div className={classes.optionsMuscle}>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#6600CC", fontWeight: 600 }}>
            <input
              type="checkbox"
              defaultChecked
              value={isBicep}
              onChange={() => {
                setIsBicep(!isBicep);
              }}
            ></input>
            Bicep
          </label>
        </div>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#0080FF", fontWeight: 600 }}>
            <input
              type="checkbox"
              value={isChest}
              defaultChecked
              onChange={() => {
                setIsChest(!isChest);
              }}
            ></input>
            Chest
          </label>
        </div>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#00CC66", fontWeight: 600 }}>
            <input
              type="checkbox"
              value={isForearm}
              defaultChecked
              onChange={() => {
                setIsForearm(!isForearm);
              }}
            ></input>
            Forearm
          </label>
        </div>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#9999FF", fontWeight: 600 }}>
            <input
              type="checkbox"
              value={isWaist}
              defaultChecked
              onChange={() => {
                setIsWaist(!isWaist);
              }}
            ></input>
            Waist
          </label>
        </div>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#FF9933", fontWeight: 600 }}>
            <input
              type="checkbox"
              value={isCalf}
              defaultChecked
              onChange={() => {
                setIsCalf(!isCalf);
              }}
            ></input>
            Calf
          </label>
        </div>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#FF3333", fontWeight: 600 }}>
            <input
              type="checkbox"
              value={isThigh}
              defaultChecked
              onChange={() => {
                setIsThigh(!isThigh);
              }}
            ></input>
            Thigh
          </label>
        </div>
        <div className={classes.optionMuscle}>
          <label style={{ color: "#FF3399", fontWeight: 600 }}>
            <input
              type="checkbox"
              value={isWeight}
              defaultChecked
              onChange={() => {
                setIsWeight(!isWeight);
              }}
            ></input>
            Weight
          </label>
        </div>
      </div>
      <br></br>
      <Line options={options} data={data} />
    </div>
  );
};

export default Progress;
