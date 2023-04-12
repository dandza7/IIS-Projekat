import React from "react";
import Navbar from "../components/Navbar";
import { Outlet } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext } from "react";
import { Sidebar } from "../components/Sidebar";
import classes from "./RootLayout.module.css";
import Footer from "../components/Footer";

const RootLayout = () => {
  const authCtx = useContext(AuthContext);
  return (
    <>
      {!authCtx.isLoggedIn && (
        <div className={classes.nav}>
          <Navbar></Navbar>
          <main>
            <Outlet></Outlet>
          </main>
          <Footer></Footer>
        </div>
      )}
      {authCtx.isLoggedIn && (
        <>
          <div className={classes.side}>
            <Sidebar></Sidebar>
            <main className={classes.sideMain}>
              <Outlet></Outlet>
            </main>
          </div>
        </>
      )}
    </>
  );
};

export default RootLayout;
