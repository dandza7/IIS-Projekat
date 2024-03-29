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
import { useParams } from "react-router";

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
  const [exercise, setExercise] = React.useState([]);
  const [exerciseDates, setExerciseDates] = React.useState([]);
  const [reload, setReload] = useState(false);
  const [exercises, setExercises] = React.useState([]);
  const [selectedExercise, setSelectedExercise] = React.useState({
    label: "False",
    value: "False",
  });
  const periodOptions = [
    { label: "Month", value: "Month" },
    { label: "Year", value: "Year" },
  ];
  let params = useParams();
  let patientId = params.id;
  if (!patientId) {
    patientId = "-1";
  }
  useEffect(() => {
    fetch("http://localhost:5041/api/measurement/getStatistics/" + patientId, {
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
        exerciseName: selectedExercise?.value,
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
        let exDates = [];
        let ex = [];
        actualData.bicepStatistics.map((stat) => {
          bicep.push(stat.statistic);
          dates.push(dayjs(stat.date).format("DD.MM"));
        });
        actualData.exerciseStatistics.map((stat) => {
          exDates.push(dayjs(stat.date).format("DD.MM"));
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
        actualData.exerciseStatistics.map((stat) => {
          ex.push(stat.statistic);
        });
        setBicep(bicep);
        setForearm(forearm);
        setCalf(calf);
        setThigh(thigh);
        setWeight(weight);
        setWaist(waist);
        setChest(chest);
        setDates(dates);
        setExercise(ex);
        setExerciseDates(exDates);
      });
  }, [selectedRange, selectedExercise]);

  useEffect(() => {
    fetch("http://localhost:5041/api/exercise/prescribed/" + patientId, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({}),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        let ex = [];
        actualData.items.map((item) =>
          ex.push({ label: item.name, value: item.name })
        );
        setExercises(ex);
      });
  }, []);

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
  const labelsEx = exerciseDates;
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

  const dataEx = {
    labels: labelsEx,
    datasets: [
      {
        label: selectedExercise?.value,
        data: exercise,
        borderColor: "black",
        backgroundColor: "rgba(255, 255, 255)",
      },
    ],
  };

  const setSelectedExerciseHandler = (selected) => {
    if (!selected) {
      setSelectedExercise({ label: "False", value: "False" });
    } else {
      setSelectedExercise(selected);
    }
  };

  return (
    <div className={utils.whiteContainer}>
      <div className={classes.titleBox}>
        <h2>{patientId == "-1" ? "My " : "Client's "}Progress</h2>
        <div className={utils.rightContainer}>
          <Select
            className={classes.selectRange}
            name="name"
            defaultValue={{ label: "Month", value: "Month" }}
            options={periodOptions}
            onChange={setSelectedRange}
            placeholder={"Select period..."}
          />
        </div>
      </div>
      <div className={utils.leftContainer}>
        Choose exercise:
        {exercises && (
          <Select
            className={classes.selectRange}
            name="name"
            isClearable
            options={exercises}
            onChange={setSelectedExerciseHandler}
            placeholder={"Select exercise..."}
          />
        )}
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
      {selectedExercise.value !== "False" && (
        <>
          <br></br>
          <h2>{selectedExercise?.value}</h2>
          <Line options={options} data={dataEx} />
        </>
      )}
    </div>
  );
};

export default Progress;
