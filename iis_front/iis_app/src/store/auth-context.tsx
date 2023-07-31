import React from "react";
import { useState, useEffect } from "react";

const AuthContext = React.createContext({
  token: "",
  role: "unauthorized",
  email: "",
  isLoggedIn: false,
  login: (role: any, email: any, token: any) => {},
  logout: () => {},
  notificationCount: null,
  updateNotifications: () => {},
});

export const AuthContextProvider = (props: any) => {
  const tokenn = localStorage.getItem("token");
  const [token, setToken] = useState(tokenn);
  const [role, setRole] = useState(localStorage.getItem("role"));
  const [email, setEmail] = useState(localStorage.getItem("email"));
  const userIsLoggedIn = token != null ? true : false;
  const [notificationCount, setNotificationCount] = useState(null);

  useEffect(() => {
    fetch("http://localhost:5041/api/notification/notifications/unread-count", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        setNotificationCount(actualData);
      });
  }, [token]);

  const loginHandler = (role: string, email: string, token: string) => {
    setToken(token);
    setRole(role);
    setEmail(email);
    localStorage.setItem("token", token);
    localStorage.setItem("role", role);
    localStorage.setItem("email", email);
  };
  const logoutHandler = () => {
    localStorage.removeItem("token");
    localStorage.removeItem("email");
    localStorage.removeItem("role");
    setEmail(null);
    setRole(null);
    setToken(null);
  };

  const updateNotificationsHandler = () => {
    fetch("http://localhost:5041/api/notification/notifications/unread-count", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        setNotificationCount(actualData);
      });
  };

  const contextValue = {
    token: token,
    role: role,
    email: email,
    isLoggedIn: userIsLoggedIn,
    login: loginHandler,
    logout: logoutHandler,
    notificationCount: notificationCount,
    updateNotifications: updateNotificationsHandler,
  };

  return (
    <AuthContext.Provider value={contextValue}>
      {props.children}
    </AuthContext.Provider>
  );
};

export default AuthContext;
