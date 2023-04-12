import React from "react";
import { useEffect, useState, useRef, useContext } from "react";
import { useParams } from "react-router-dom";
import AuthContext from "../store/auth-context";

const Profile = () => {
  const [name, setName] = useState("");
  const authCtx = useContext(AuthContext);
  const params = useParams();
  useEffect(() => {
    const userId = params.userId;
    fetch("http://localhost:5041/api/profiles/" + userId, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setName(actualData);
      });
  }, []);

  return <div>Profile</div>;
};

export default Profile;
