import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";

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

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route>
      <Route path="/register" element={<Register></Register>} />
      <Route path="/login" element={<Login></Login>} />
      <Route path="/" element={<RootLayout></RootLayout>}>
        <Route index element={<Home></Home>}></Route>
      </Route>
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
