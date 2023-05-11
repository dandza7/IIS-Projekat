import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import { useRef, useContext } from "react";
import AuthContext from "./store/auth-context";

import {
  createBrowserRouter,
  RouterProvider,
  Route,
  Link,
  createRoutesFromElements,
} from "react-router-dom";
import RootLayout from "./pages/RootLayout";
import Register from "./pages/Register";
import { Login } from "./pages/Login";
import { Home } from "./pages/Home";
import AdminDashboard from "./pages/AdminDashboard";
import { Users } from "./pages/Users";
import { Welcome } from "./pages/Welcome";
import { PackagesPreview } from "./pages/PackagesPreview";
import MyProfile from "./pages/MyProfile";
import Profile from "./pages/Profile";
import ScrollToTop from "./components/ScrollToTop";
import { useLocation } from "react-router";
import { useEffect } from "react";
import PrivateRoutes from "./utils/LoginRoutes";
import AdminRoutes from "./utils/AdminRoutes";
import TrainingPlanRequest from "./pages/TrainingPlanRequest";
import NewExercise from "./pages/NewExercise";
import DiagnosesAndAllergies from "./pages/DiagnosesAndAllergies";
import Foods from "./pages/Foods";
import Food from "./pages/Food";
import TrainingPlanRequests from "./pages/TrainingPlanRequests";
import Exercises from "./pages/Exercises";
import NewFood from "./pages/NewFood";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route>
      <Route path="/register" element={<Register></Register>} />
      <Route path="/login" element={<Login></Login>} />
      <Route path="/" element={<RootLayout></RootLayout>}>
        {<Route path="/" index element={<Welcome></Welcome>}></Route>}
        <Route
          path="/packages-preview"
          element={<PackagesPreview></PackagesPreview>}
        ></Route>
        <Route element={<PrivateRoutes />}>
          <Route path="/home" element={<Home></Home>}></Route>
          <Route path="/profile" element={<MyProfile></MyProfile>}></Route>
          <Route
            path="/new-exercise"
            element={<NewExercise></NewExercise>}
          ></Route>
          <Route
            path="/diagnoses"
            element={<DiagnosesAndAllergies></DiagnosesAndAllergies>}
          ></Route>
          <Route path="/exercises" element={<Exercises></Exercises>}></Route>
          <Route path="/foods" element={<Foods></Foods>}></Route>
          <Route path="/food/:name" element={<Food></Food>}></Route>
          <Route path="/new-food" element={<NewFood></NewFood>}></Route>
          <Route
            path="/training-plan-request"
            element={<TrainingPlanRequest></TrainingPlanRequest>}
          ></Route>
          <Route
            path="/training-plan-requests"
            element={<TrainingPlanRequests></TrainingPlanRequests>}
          ></Route>
          <Route element={<AdminRoutes />}>
            <Route
              path="/admin-dashboard"
              element={<AdminDashboard></AdminDashboard>}
            ></Route>
            <Route path="/users" element={<Users></Users>}></Route>
            <Route path="/users/:userId" element={<Profile></Profile>}></Route>
          </Route>
        </Route>
      </Route>
    </Route>
  )
);

function App() {
  const authCtx = useContext(AuthContext);

  return (
    <>
      <RouterProvider router={router}></RouterProvider>
    </>
  );
}

export default App;
