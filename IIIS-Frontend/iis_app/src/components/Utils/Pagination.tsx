import React from "react";
import classes from "./styles/Pagination.module.css";
import { useEffect, useState, useRef, useContext } from "react";
import NavigateNextIcon from "@mui/icons-material/NavigateNext";
import NavigateBeforeIcon from "@mui/icons-material/NavigateBefore";

const Pagination = (props) => {
  const pag = props.currentPage;
  const [selectedPage, setSelectedPage] = useState(pag);
  const numberOfPages = Math.ceil(props.totalCount / props.pageSize);
  const [selectedPageGo, setSelectedPageGo] = useState("");

  useEffect(() => {
    setSelectedPage(props.currentPage);
  }, [props.currentPage]);

  useEffect(() => {
    if (selectedPage <= 0 || !selectedPage) {
    } else {
      props.change(selectedPage);
    }
    setSelectedPageGo("");
  }, [selectedPage]);

  return (
    <div className={classes.pagination}>
      <div className={classes.pages}>
        {selectedPage > 1 && (
          <span
            className={classes.backPageButton}
            onClick={() => {
              setSelectedPage((prevState) => prevState - 1);
            }}
          >
            <NavigateBeforeIcon></NavigateBeforeIcon>
          </span>
        )}
        {selectedPage > 2 && (
          <span
            className={classes.page}
            onClick={() => {
              setSelectedPage(1);
            }}
          >
            1
          </span>
        )}
        {selectedPage > 3 && <span>...</span>}
        {selectedPage > 1 && (
          <span
            className={selectedPage == 2 ? classes.page : classes.page}
            onClick={() => {
              setSelectedPage((prevState) => prevState - 1);
            }}
          >
            {selectedPage - 1}
          </span>
        )}
        <span className={classes.selectedPage}>{selectedPage}</span>

        {selectedPage + 1 < numberOfPages && (
          <span
            className={classes.page}
            onClick={() => {
              setSelectedPage((prevState) => prevState + 1);
            }}
          >
            {selectedPage + 1}
          </span>
        )}
        {selectedPage + 2 < numberOfPages && <span>...</span>}
        {selectedPage < numberOfPages && (
          <span
            className={classes.page}
            onClick={() => {
              setSelectedPage(numberOfPages);
            }}
          >
            {numberOfPages}
          </span>
        )}
        {selectedPage < numberOfPages && (
          <span
            className={classes.nextPageButton}
            onClick={() => {
              setSelectedPage((prevState) => prevState + 1);
            }}
          >
            <NavigateNextIcon></NavigateNextIcon>
          </span>
        )}
      </div>
      <div className={classes.goTo}>
        <div className={classes.goToInputContainer}>
          <input
            value={selectedPageGo}
            className={classes.inputNumber}
            onChange={() => {
              console.log(event?.target.value);
              if (event?.target.value > numberOfPages) {
                setSelectedPageGo(numberOfPages);
              } else if (event?.target.value <= 0) {
                setSelectedPageGo(1);
              } else {
                setSelectedPageGo(event?.target.value);
              }
            }}
          ></input>
          <button
            className={classes.goButton}
            onClick={() => {
              if (selectedPageGo === "") {
              } else {
                setSelectedPage(parseInt(selectedPageGo));
              }
            }}
          >
            <NavigateNextIcon></NavigateNextIcon>
          </button>
        </div>
      </div>
    </div>
  );
};

export default Pagination;
