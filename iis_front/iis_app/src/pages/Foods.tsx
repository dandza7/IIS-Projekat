import React from "react";
import classes from "./Foods.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";
import utils from "./Utils.module.css";
import Paginations from "../components/Paginations";

const Food = () => {
  const navigate = useNavigate();

  const [foodList, setfoodList] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);

  const changePage = (page: number) => {
    setSelectedPage(page);
  };

  useEffect(() => {
    fetch("http://localhost:5041/api/food", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: 5,
        page: selectedPage,
        order: [
          {
            orderField: "ID",
            ordering: "ASC",
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        setfoodList(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  const selectFoodHandler = (name: any) => {
    navigate("/food/" + name);
  };

  const handleButtonClick = () => {
    navigate("/new-food");
  };

  return (
    <div className={classes.dal}>
      <div className={utils.title}>Food List</div>
      <div className={classes.filters}>
        <div className={classes.categories}>
          <span>Meat</span>
          <span>Fruit</span>
          <span>Vegetables</span>
          <span>Fish</span>
          <span>Dairy</span>
        </div>
        <button className={utils.blackButton} onClick={handleButtonClick}>
          Add Food
        </button>
      </div>

      <table className={utils.styledTable}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Calories (per 100 grams)</th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {foodList.map((user, index) => (
            <tr key={index}>
              <td>{user.name}</td>
              <td>{user.calories * 100}</td>
              <td></td>
              <td></td>
              <td></td>
              <td>
                <button
                  onClick={() => selectFoodHandler(user.name)}
                  className={utils.greenButton}
                >
                  Details
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
      <Paginations change={changePage} totalCount={totalCount}></Paginations>
    </div>
  );
};

export default Food;
