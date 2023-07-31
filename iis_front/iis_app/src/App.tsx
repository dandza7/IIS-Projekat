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
import Recipes from "./pages/Recipes";
import Appointments from "./pages/Appointments";
import SpaAppointments from "./pages/SpaAppointments";
import { Patients } from "./pages/Patients";
import NewTrainingPlan from "./pages/NewTrainingPlan";
import NewRecipe from "./pages/NewRecipe";
import Recipe from "./pages/Recipe";
import TrainingPlans from "./pages/TrainingPlans";
import { TrainingPlan } from "./pages/TrainingPlan";
import MyExercisePlan from "./pages/MyExercisePlan";
import NewMealPlan from "./pages/NewMealPlan";
import MealPlanPatients from "./pages/MealPlanPatients";
import Appointment from "./pages/Appointment";
import { TrainingPlanOverview } from "./pages/TrainingPlanOverview";
import MyMealPlan from "./pages/MyMealPlan";
import Notifications from "./pages/Notifications";

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
            path="/notifications"
            element={<Notifications></Notifications>}
          ></Route>
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
          <Route path="/recipes" element={<Recipes></Recipes>}></Route>
          <Route path="/new-recipe" element={<NewRecipe></NewRecipe>}></Route>
          <Route path="/recipes/:name" element={<Recipe></Recipe>}></Route>
          <Route path="/food/:name" element={<Food></Food>}></Route>
          <Route
            path="/meal-plan"
            element={<NewMealPlan></NewMealPlan>}
          ></Route>
          <Route path="/patients" element={<Patients></Patients>}></Route>
          <Route
            path="/meal-plans"
            element={<MealPlanPatients></MealPlanPatients>}
          ></Route>
          <Route
            path="/my-meal-plan"
            element={<MyMealPlan></MyMealPlan>}
          ></Route>
          <Route
            path="/new-training-plan"
            element={<NewTrainingPlan></NewTrainingPlan>}
          ></Route>
          <Route
            path="/appointments"
            element={<Appointments></Appointments>}
          ></Route>
          <Route
            path="/appointments/:id"
            element={<Appointment></Appointment>}
          ></Route>
          <Route path="/exercises" element={<Exercises></Exercises>}></Route>
          <Route
            path="/spa-appointments"
            element={<SpaAppointments></SpaAppointments>}
          ></Route>
          <Route path="/new-food" element={<NewFood></NewFood>}></Route>
          <Route
            path="/training-plan-request"
            element={<TrainingPlanRequest></TrainingPlanRequest>}
          ></Route>
          <Route
            path="/my-training-plan"
            element={<MyExercisePlan></MyExercisePlan>}
          ></Route>
          <Route
            path="/training-plan-requests"
            element={<TrainingPlanRequests></TrainingPlanRequests>}
          ></Route>
          <Route
            path="/training-plans"
            element={<TrainingPlans></TrainingPlans>}
          ></Route>
          <Route
            path="/training-plans/:id"
            element={<TrainingPlanOverview></TrainingPlanOverview>}
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
