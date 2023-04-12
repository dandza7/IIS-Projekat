import React from "react";
import classes from "./Welcome.module.css";

export const Welcome = () => {
  return (
    <div className={classes.welcome}>
      <div className={classes.banner}>
        <div className={classes.bannerDiv}>
          <h1>Lorem ipsum dolor sit</h1>
          <h2>
            Lorem ipsum dolor sit, amet consectetur adipisicing elit. Suscipit
            quos libero temporibus unde molestiae et pariatur labore delectus,
            odio necessitatibus tempore harum eveniet fugit earum alias?
            Possimus vero maxime deserunt assumenda debitis tenetur fugiat modi
            provident sed? Minus, eaque iste.
          </h2>
          <button className={classes.bannerButton}>View packages</button>
        </div>
        <div className={classes.bannerImg}></div>
      </div>

      <div className={classes.banner}>
        <div className={classes.ImgNutrition}></div>
        <div className={classes.bannerDiv}>
          <div className={classes.bgbannerDiv}>
            <h1>Lorem ipsum dolor sit</h1>
            <h2>
              Lorem ipsum dolor sit, amet consectetur adipisicing elit. Suscipit
              quos libero temporibus unde molestiae et pariatur labore delectus,
              odio necessitatibus tempore harum eveniet fugit earum alias?
              Possimus vero maxime deserunt assumenda debitis tenetur fugiat
              modi provident sed? Minus, eaque iste.
            </h2>
          </div>
        </div>
      </div>
      <div className={classes.banner}>
        <div className={classes.bannerDiv}>
          <div className={classes.bgbannerDiv}>
            <h1>Lorem ipsum dolor sit</h1>
            <h2>
              Lorem ipsum dolor sit, amet consectetur adipisicing elit. Suscipit
              quos libero temporibus unde molestiae et pariatur labore delectus,
              odio necessitatibus tempore harum eveniet fugit earum alias?
              Possimus vero maxime deserunt assumenda debitis tenetur fugiat
              modi provident sed? Minus, eaque iste.
            </h2>
          </div>
        </div>
        <div className={classes.imgSpa}></div>
      </div>
      <div className={classes.banner}>
        <div className={classes.imgGym}></div>
        <div className={classes.bannerDiv}>
          <div className={classes.bgbannerDiv}>
            <h1>Lorem ipsum dolor sit</h1>
            <h2>
              Lorem ipsum dolor sit, amet consectetur adipisicing elit. Suscipit
              quos libero temporibus unde molestiae et pariatur labore delectus,
              odio necessitatibus tempore harum eveniet fugit earum alias?
              Possimus vero maxime deserunt assumenda debitis tenetur fugiat
              modi provident sed? Minus, eaque iste.
            </h2>
          </div>
        </div>
      </div>
      <br></br>
    </div>
  );
};
