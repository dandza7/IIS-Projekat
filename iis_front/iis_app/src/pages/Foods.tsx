import React from "react";
import classes from "./DiagnosesAndAllergies.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";

const Food = () => {
  const navigate = useNavigate();

  const [foodList, setfoodList] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/food", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        paginationQuery: {},
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setfoodList(actualData.items);
      });
  }, []);

  const selectFoodHandler = (name: any) => {
    navigate("/food/" + name);
  };

  const handleButtonClick = () => {
    navigate("/new-food");
  };

  const nameRef = useRef(null);
  const categoryRef = useRef("Grains");
  const energyRef = useRef(0);
  const proteinRef = useRef(0);
  const carbsRef = useRef(0);
  const fiberRef = useRef(0);
  const sugarRef = useRef(0);
  const fatRef = useRef(0);
  const vitaminARef = useRef(0);
  const vitaminB1Ref = useRef(0);
  const vitaminB2Ref = useRef(0);
  const vitaminB3Ref = useRef(0);
  const vitaminCRef = useRef(0);
  const vitaminDRef = useRef(0);
  const vitaminERef = useRef(0);
  const calciumRef = useRef(0);
  const ironRef = useRef(0);
  const magnesiumRef = useRef(0);
  const potassiumRef = useRef(0);
  const sodiumRef = useRef(0);
  const zinkRef = useRef(0);

  const addFoodHandler = () => {
    event?.preventDefault();
    const foodName = nameRef.current.value;
    const category = categoryRef.current.value;
    const energy = energyRef.current.value;
    const protein = proteinRef.current.value;
    const carbs = carbsRef.current.value;
    const fiber = fiberRef.current.value;
    const sugar = sugarRef.current.value;
    const fat = fatRef.current.value;
    const vitaminA = vitaminARef.current.value;
    const vitaminB1 = vitaminB1Ref.current.value;
    const vitaminB2 = vitaminB2Ref.current.value;
    const vitaminB3 = vitaminB3Ref.current.value;
    const vitaminC = vitaminCRef.current.value;
    const vitaminD = vitaminDRef.current.value;
    const vitaminE = vitaminERef.current.value;
    const calcium = calciumRef.current.value;
    const iron = ironRef.current.value;
    const magnesium = magnesiumRef.current.value;
    const potassium = potassiumRef.current.value;
    const sodium = sodiumRef.current.value;
    const zink = zinkRef.current.value;

    console.log(foodName.length);
    if (!nameRef.current.value) {
      alert("You must specify food name");
      return;
    } else {
      fetch("http://localhost:5041/api/food/new", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: "Bearer " + authCtx.token,
        },
        body: JSON.stringify({
          name: foodName,
          category: category,
          calories: energy,
          allergyIds: [],
          nutrientTable: {
            protein: protein,
            fat: fat,
            carbohydrates: carbs,
            fiber: fiber,
            sugar: sugar,
            vitaminA: vitaminA,
            vitaminB1: vitaminB1,
            vitaminB2: vitaminB2,
            vitaminB3: vitaminB3,
            vitaminC: vitaminC,
            vitaminD: vitaminD,
            vitaminE: vitaminE,
            calcium: calcium,
            iron: iron,
            magnesium: magnesium,
            potassium: potassium,
            sodium: sodium,
            zinc: zink,
          },
        }),
      })
        .then((response) => response.json())
        .then((actualData) => {
          alert("Food has been successfully added!");
        });
    }
  };

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 1000,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 4,
  };

  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  return (
    <div className={classes.dal}>
      <div className={classes.dalTitle}>Food List</div>
      <div className={classes.filters}>
        <div className={classes.categories}>
          <span>Meat</span>
          <span>Fruit</span>
          <span>Vegetables</span>
          <span>Fish</span>
          <span>Dairy</span>
        </div>
        <button className={classes.addButton} onClick={handleOpen}>
          Add Food
        </button>
      </div>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div>
            <div className={classes.title}>Add new food</div>
            <div>
              <form className={classes.form} onSubmit={addFoodHandler}>
                <div className={classes.nutrientsContainer}>
                  <div className={classes.macros}>
                    <div>
                      <label>Name </label>
                      <input type="text" ref={nameRef}></input>
                    </div>
                    <div>
                      <label>Category </label>
                      <select ref={categoryRef}>
                        <option>Grains</option>
                        <option>Meat</option>
                        <option>Fish</option>
                      </select>
                    </div>
                    <span>General</span>
                    <table className={classes.styledTableNutrients}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                          <th>Unit</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Energy(kcal)</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={energyRef}
                            ></input>
                          </td>
                          <td>
                            <span>kcal</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                    <span>Carbohydrates</span>
                    <table className={classes.styledTableNutrients}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                          <th>Unit</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Total</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={carbsRef}
                            ></input>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Fiber</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={fiberRef}
                            ></input>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Sugars</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={sugarRef}
                            ></input>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                    <span>Protein</span>
                    <table className={classes.styledTableNutrients}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                          <th>Unit</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Total Protein</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={proteinRef}
                            ></input>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                    <span>Lipids</span>
                    <table className={classes.styledTableNutrients}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                          <th>Unit</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Total Fat</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={fatRef}
                            ></input>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                  <div className={classes.micros}>
                    <span>Vitamins</span>
                    <table className={classes.styledTableNutrients}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                          <th>Unit</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Vitamin A</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminARef}
                            ></input>
                          </td>
                          <td>
                            <span>IU</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin B1</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminB1Ref}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin B2</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminB2Ref}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin B3</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminB3Ref}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin C</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminCRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin D</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminDRef}
                            ></input>
                          </td>
                          <td>
                            <span>IU</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin E</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={vitaminERef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                    <span>Minerals</span>
                    <table className={classes.styledTableNutrients}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Amount</th>
                          <th>Unit</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Calcium</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={calciumRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Iron</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={ironRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Magnesium</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={magnesiumRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Pottasium</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={potassiumRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Sodium</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={sodiumRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Zink</td>
                          <td>
                            <input
                              className={classes.nutrientInput}
                              ref={zinkRef}
                            ></input>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
                <div className={classes.buttonContainer}>
                  <button type="submit" className={classes.addButton}>
                    Add Food
                  </button>
                </div>
              </form>
            </div>
          </div>
        </Box>
      </Modal>
      <table className={classes.styledTable}>
        <thead>
          <tr>
            <th>Name</th>
            <th>Calories (per 100 grams)</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {foodList.map((user, index) => (
            <tr key={index}>
              <td>{user.name}</td>
              <td>{user.calories}</td>
              <td>
                <button
                  onClick={() => selectFoodHandler(user.name)}
                  className={classes.detailsButton}
                >
                  Details
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Food;
