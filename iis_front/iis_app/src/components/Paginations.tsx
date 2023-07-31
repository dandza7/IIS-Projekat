import React from "react";
import classes from "../pages/Foods.module.css";
import utils from "../pages/Utils.module.css";
import { useEffect, useState, useRef, useContext } from "react";

const Paginations = (props) => {
  const [selectedPage, setSelectedPage] = useState(1);
  const numberOfPages = Math.ceil(props.totalCount / 5);
  const [selectedPageGo, setSelectedPageGo] = useState(1);

  useEffect(() => {
    props.change(selectedPage);
  }, [selectedPage]);

  return (
    <div className={classes.pagination}>
      <div className={classes.pages}>
        {selectedPage > 1 && (
          <span
            className={classes.page}
            onClick={() => {
              setSelectedPage((prevState) => prevState - 1);
            }}
          >
            Back
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
        {selectedPage > 2 && <span>...</span>}
        {selectedPage > 1 && (
          <span
            className={classes.page}
            onClick={() => {
              setSelectedPage((prevState) => prevState - 1);
            }}
          >
            {selectedPage - 1}
          </span>
        )}
        <span className={classes.selectedPage}>{selectedPage}</span>

        {selectedPage < numberOfPages && (
          <span
            className={classes.page}
            onClick={() => {
              setSelectedPage((prevState) => prevState + 1);
            }}
          >
            {selectedPage + 1}
          </span>
        )}
        {selectedPage + 1 < numberOfPages && <span>...</span>}
        {selectedPage + 1 < numberOfPages && (
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
            className={classes.page}
            onClick={() => {
              setSelectedPage((prevState) => prevState + 1);
            }}
          >
            Next
          </span>
        )}
      </div>
      <div className={classes.goTo}>
        <label>Go to</label>
        <div>
          <input
            className={utils.inputNumber}
            onChange={() => {
              if (event?.target.value <= numberOfPages) {
                setSelectedPageGo(event?.target.value);
              } else {
                setSelectedPageGo(numberOfPages);
              }
            }}
          ></input>
          <button
            className={classes.goButton}
            onClick={() => setSelectedPage(parseInt(selectedPageGo))}
          >
            Go
          </button>
        </div>
      </div>
    </div>
  );
};

export default Paginations;
