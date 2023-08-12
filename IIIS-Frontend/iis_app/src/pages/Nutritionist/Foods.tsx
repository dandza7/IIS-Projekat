import React from "react";
import classes from "./styles/Foods.module.css";
import { useState, useEffect, useContext } from "react";
import AuthContext from "../../store/auth-context";
import { useNavigate } from "react-router";
import Pagination from "../../components/Utils/Pagination";

const Foods = () => {
  const authCtx = useContext(AuthContext);
  const [foodList, setfoodList] = useState<any[]>([]);
  const [totalCount, setTotalCount] = useState(null);
  const [selectedPage, setSelectedPage] = useState(1);
  const pageSize = 10;
  const navigate = useNavigate();
  const changePage = (page: number) => {
    setSelectedPage(page);
    window.scrollTo({ top: 0, left: 0 });
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/food", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: pageSize,
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
        console.log(actualData);
        setfoodList(actualData.items);
        setTotalCount(actualData.totalCount);
      });
  }, [selectedPage]);

  const handleOpenFood = (name: string) => {
    navigate(`/food/${name}`);
  };

  return (
    <div className={classes.whiteContainer}>
      <h2>Foods</h2>
      <br></br>
      <div className={classes.leagues}>
        <table className={classes.foodTable}>
          <thead>
            <tr>
              <th>Name</th>
              <th>Calories (per 100 grams)</th>
            </tr>
          </thead>
          <tbody>
            {foodList?.map((food) => (
              <tr key={food.id} onClick={() => handleOpenFood(food.name)}>
                <td>
                  <span>{food.name}</span>
                </td>
                <td>
                  <span>{food.calories * 100}</span>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
      {totalCount > pageSize && (
        <Pagination
          change={changePage}
          totalCount={totalCount}
          pageSize={pageSize}
          currentPage={selectedPage}
        ></Pagination>
      )}
    </div>
  );
};

export default Foods;
