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

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route>
      <Route path="/register" element={<Register></Register>} />
      <Route path="/login" element={<Login></Login>} />
      <Route path="/" element={<RootLayout></RootLayout>}>
        <Route index element={<Welcome></Welcome>}></Route>
        <Route
          path="/admin-dashboard"
          element={<AdminDashboard></AdminDashboard>}
        ></Route>
        <Route path="/home" element={<Home></Home>}></Route>
        <Route
          path="/packages-preview"
          element={<PackagesPreview></PackagesPreview>}
        ></Route>
        <Route path="/users" element={<Users></Users>}></Route>
      </Route>
    </Route>
  )
);

function App() {
  const authCtx = useContext(AuthContext);

  return <RouterProvider router={router} />;
}

export default App;
