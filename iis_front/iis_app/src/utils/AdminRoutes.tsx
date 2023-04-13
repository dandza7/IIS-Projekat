import { Outlet, Navigate } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext } from "react";

const AdminRoutes = () => {
  const authCtx = useContext(AuthContext);

  return authCtx.role == "ADMIN" ? <Outlet /> : <Navigate to="/home" />;
};

export default AdminRoutes;
