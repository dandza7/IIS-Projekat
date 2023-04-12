import React from "react";
import { useState } from "react";

const AuthContext = React.createContext({
  role: "unauthorized",
  email: "",
  isLoggedIn: false,
  login: (role: any, email: any, token: any) => {},
  logout: () => {},
});

export const AuthContextProvider = (props: any) => {
  const tokenn = localStorage.getItem("token");
  const [token, setToken] = useState(tokenn);
  const [role, setRole] = useState("unauthorized");
  const [email, setEmail] = useState(null);
  const userIsLoggedIn = token != null ? true : false;

  const loginHandler = (role: string, email: string, token: string) => {
    setToken(token);
    setRole(role);
    localStorage.setItem("token", token);
  };
  const logoutHandler = () => {
    localStorage.removeItem("token");
    setToken(null);
  };

  const contextValue = {
    role: role,
    email: email,
    isLoggedIn: userIsLoggedIn,
    login: loginHandler,
    logout: logoutHandler,
  };

  return (
    <AuthContext.Provider value={contextValue}>
      {props.children}
    </AuthContext.Provider>
  );
};

export default AuthContext;
