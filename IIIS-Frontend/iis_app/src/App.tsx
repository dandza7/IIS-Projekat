import "./App.css";
import {
  createBrowserRouter,
  RouterProvider,
  Route,
  Link,
  createRoutesFromElements,
} from "react-router-dom";
import Login from "./pages/Login";
import RootLayout from "./components/RootLayout/RootLayout";
import Home from "./pages/Home";
import Foods from "./pages/Nutritionist/Foods";
import { Recipes } from "./pages/Nutritionist/Recipes";
import Notifications from "./pages/Notifications";
import Exercises from "./pages/Trainer/Exercises";
import Food from "./pages/Nutritionist/Food";
import Recipe from "./pages/Nutritionist/Recipe";
import TrainingPlanRequests from "./pages/Trainer/TrainingPlanRequests";
import NewTrainingPlanRequest from "./pages/Customer/NewTrainingPlanRequest";
import MealPlan from "./pages/Nutritionist/MealPlan";
import NewRecipe from "./pages/Nutritionist/NewRecipe";
import { NewFood } from "./pages/Nutritionist/NewFood";
import Patients from "./pages/Nutritionist/Patients";
import NewExercise from "./pages/Trainer/NewExercise";
import NewTrainingPlan from "./pages/Trainer/NewTrainingPlan";
import TrainingPlan from "./pages/Trainer/TrainingPlan";
import TrainingPlans from "./pages/Trainer/TrainingPlans";
import MyTrainingPlan from "./pages/Customer/MyTrainingPlan";
import Session from "./pages/Customer/Session";
import TodaySession from "./pages/Customer/TodaysSession";
import MySessions from "./pages/Customer/MySessions";
import NewMeasurement from "./pages/Customer/NewMeasurement";
import Profile from "./pages/Profile";
import Progress from "./pages/Progress";
import Register from "./pages/Register";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route>
      <Route path="/login" element={<Login></Login>} />
      <Route path="/register" element={<Register></Register>} />
      <Route path="/" element={<RootLayout></RootLayout>}>
        {<Route path="/" index element={<Home></Home>}></Route>}
        {<Route path="/my-profile" index element={<Profile></Profile>}></Route>}
        {<Route path="/foods" index element={<Foods></Foods>}></Route>}
        {<Route path="/progress" index element={<Progress></Progress>}></Route>}
        {
          <Route
            path="/progress/:id"
            index
            element={<Progress></Progress>}
          ></Route>
        }
        {<Route path="/recipes" index element={<Recipes></Recipes>}></Route>}
        {
          <Route
            path="/notifications"
            index
            element={<Notifications></Notifications>}
          ></Route>
        }
        {
          <Route
            path="/exercises"
            index
            element={<Exercises></Exercises>}
          ></Route>
        }
        {<Route path="/food/:name" index element={<Food></Food>}></Route>}
        {<Route path="/recipe/:id" index element={<Recipe></Recipe>}></Route>}
        {
          <Route
            path="/my-training-plan"
            index
            element={<MyTrainingPlan></MyTrainingPlan>}
          ></Route>
        }
        {
          <Route
            path="/training-plan-request"
            index
            element={<NewTrainingPlanRequest></NewTrainingPlanRequest>}
          ></Route>
        }
        {
          <Route
            path="/training-plan-requests"
            index
            element={<TrainingPlanRequests></TrainingPlanRequests>}
          ></Route>
        }
        {<Route path="/new-food" index element={<NewFood></NewFood>}></Route>}
        {
          <Route
            path="/new-recipe"
            index
            element={<NewRecipe></NewRecipe>}
          ></Route>
        }
        {
          <Route
            path="/meal-plan/:id"
            index
            element={<MealPlan></MealPlan>}
          ></Route>
        }
        {<Route path="/patients" index element={<Patients></Patients>}></Route>}
        {
          <Route
            path="/new-exercise"
            index
            element={<NewExercise></NewExercise>}
          ></Route>
        }
        {
          <Route
            path="/new-training-plan/:id"
            index
            element={<NewTrainingPlan></NewTrainingPlan>}
          ></Route>
        }
        {
          <Route
            path="/training-plan/:id"
            index
            element={<TrainingPlan></TrainingPlan>}
          ></Route>
        }{" "}
        {
          <Route
            path="/training-plans"
            index
            element={<TrainingPlans></TrainingPlans>}
          ></Route>
        }
        {
          <Route
            path="/session"
            index
            element={<TodaySession></TodaySession>}
          ></Route>
        }
        {
          <Route
            path="/my-sessions"
            index
            element={<MySessions></MySessions>}
          ></Route>
        }
        {
          <Route
            path="/new-measurement"
            index
            element={<NewMeasurement></NewMeasurement>}
          ></Route>
        }
      </Route>
    </Route>
  )
);

function App() {
  return (
    <>
      <RouterProvider router={router}></RouterProvider>
    </>
  );
}

export default App;
