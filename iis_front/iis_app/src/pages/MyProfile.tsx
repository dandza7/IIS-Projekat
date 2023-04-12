import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import { Users } from "./Users";

const MyProfile = () => {
  const [user, setUser] = useState<User>({});
  const authCtx = useContext(AuthContext);

  type User = {
    email: string;
    name: string;
    surname: string;
    birthDate: Date;
    gender: string;
    role: string;
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/profiles", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setUser(actualData);
      });
  }, []);

  return (
    <div>
      <div>MyProfile</div>
      <span>Name:</span>
      <span>{user.name}</span>
      <span>Email:</span>
      <span>{user.email}</span>
      <span>Gender:</span>
      <span>{user.gender}</span>
    </div>
  );
};

export default MyProfile;
