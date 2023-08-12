import React from "react";
import { Navbar } from "../Navbar/Navbar";
import { Outlet } from "react-router";
import classes from "./RootLayout.module.css";

const RootLayout = () => {
  return (
    <div className={classes.rootLayout}>
      <Navbar></Navbar>
      <main className={classes.main}>
        <div className={classes.outletContainer}>
          <Outlet></Outlet>
        </div>
      </main>
    </div>
  );
};

export default RootLayout;
