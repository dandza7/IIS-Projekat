import { Outlet, Navigate } from "react-router-dom";
import AuthContext from "../store/auth-context";
import { useContext } from "react";

const PrivateRoutes = () => {
  const authCtx = useContext(AuthContext);

  return authCtx.isLoggedIn ? <Outlet /> : <Navigate to="/login" />;
};

export default PrivateRoutes;
