import React from "react";
import classes from "./Recipes.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../store/auth-context";
import utils from "./Utils.module.css";
import AddIcon from "@mui/icons-material/Add";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";

const NewRecipe = () => {
  const navigate = useNavigate();

  const [foodList, setfoodList] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [allFood, setAllFood] = useState<any[]>([]);
  const [open, setOpen] = React.useState(false);
  const selectedFoodAmountRef = useRef();
  const nameRef = useRef();
  const handleOpen = () => {
    setOpen(true);
    setSelectedIngredient(null);
  };
  const handleClose = () => setOpen(false);
  const [selectedFood, setSelectedFood] = useState<any[]>([]);
  const [food, setFood] = useState<any[]>([]);
  const [amount, setAmount] = useState(0);
  const [selectedIngredient, setSelectedIngredient] = useState(null);
  const [total, setTotal] = useState({
    protein: 0,
    carbs: 0,
    fat: 0,
    energy: 0,
    fiber: 0,
    sugar: 0,
    vitaminA: 0,
    vitaminB1: 0,
    vitaminB2: 0,
    vitaminB3: 0,
    vitaminC: 0,
    vitaminD: 0,
    vitaminE: 0,
    calcium: 0,
    iron: 0,
    magnesium: 0,
    potassium: 0,
    sodium: 0,
    zinc: 0,
  });

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    width: 800,
    bgcolor: "background.paper",
    boxShadow: 24,
    p: 0.5,
    borderRadius: 3,
  };

  const addFoodHandler = () => {
    const si = selectedIngredient;
    si.amount = selectedFoodAmountRef?.current?.value;
    var updatedList = [...food];
    updatedList = [...food, si];
    setFood(updatedList);
    setTotal({
      protein: total.protein + si.amount * si.nutrientTable.protein,
      carbs: total.carbs + si.amount * si.nutrientTable.carbohydrates,
      fat: total.fat + si.amount * si.nutrientTable.fat,
      sugar: total.sugar + si.amount * si.nutrientTable.sugar,
      fiber: total.fiber + si.amount * si.nutrientTable.fiber,
      energy: total.energy + si.amount * si.calories,
      vitaminA: total.vitaminA + si.amount * si.nutrientTable.vitaminA,
      vitaminB1: total.vitaminB1 + si.amount * si.nutrientTable.vitaminB1,
      vitaminB2: total.vitaminB2 + si.amount * si.nutrientTable.vitaminB2,
      vitaminB3: total.vitaminB3 + si.amount * si.nutrientTable.vitaminB3,
      vitaminC: total.vitaminC + si.amount * si.nutrientTable.vitaminC,
      vitaminD: total.vitaminE + si.amount * si.nutrientTable.vitaminD,
      vitaminE: total.vitaminE + si.amount * si.nutrientTable.vitaminE,
      calcium: total.calcium + si.amount * si.nutrientTable.calcium,
      magnesium: total.magnesium + si.amount * si.nutrientTable.magnesium,
      iron: total.iron + si.amount * si.nutrientTable.iron,
      potassium: total.potassium + si.amount * si.nutrientTable.potassium,
      sodium: total.sodium + si.amount * si.nutrientTable.sodium,
      zinc: total.zinc + si.amount * si.nutrientTable.zinc,
    });
    handleClose();
  };

  const handleAmountChange = () => {
    setAmount(event?.target.value);
  };

  const removeFoodHandler = (foodId: number) => {
    setFood((current) => current.filter((food) => food.id !== foodId));
  };

  const addRecipeHandler = () => {
    event?.preventDefault();
    const selectedFood: { foodId: number; amount: number }[] = [];
    const enteredName = nameRef.current.value;
    food.forEach((food) => {
      selectedFood.push({ foodId: food.id, amount: food.amount });
    });
    console.log(selectedFood);

    fetch("http://localhost:5041/api/recipes/new", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        name: enteredName,
        ingredients: selectedFood,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("Recipe has been successfully added!");
      });
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/food", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({}),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setAllFood(actualData.items);
      });
  }, []);

  return (
    <div className={classes.newRecipe}>
      <div className={utils.title}>New recipe</div>
      <div>
        <form className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.nameContainer}>
                <div className={utils.spanFlex}>
                  <label>Name:</label>
                  <input
                    type="text"
                    className={utils.input}
                    ref={nameRef}
                  ></input>
                </div>
                <button
                  className={utils.greenButton}
                  onClick={addRecipeHandler}
                >
                  Add recipe
                </button>
              </div>
              <span className={classes.smallTitle}>Ingredients</span>
              <table className={classes.styledTableFoods}>
                <thead>
                  <tr>
                    <th>Name</th>
                    <th>Amount</th>
                    <th>Calories</th>
                    <th>Protein</th>
                    <th>Total Carbs</th>
                    <th>Total Fat</th>
                    <th>
                      <AddIcon fontSize="small" onClick={handleOpen}></AddIcon>
                    </th>
                  </tr>
                </thead>
                <tbody>
                  {food.map((food, index) => (
                    <tr key={index}>
                      <td>{food?.name}</td>
                      <td>{food?.amount}</td>
                      <td>{food?.calories * food?.amount}</td>
                      <td>{food?.nutrientTable?.protein * food?.amount}</td>
                      <td>
                        {food?.nutrientTable?.carbohydrates * food?.amount}
                      </td>
                      <td>{food?.nutrientTable?.fat * food?.amount}</td>
                      <td>
                        <button
                          className={classes.deleteButton}
                          onClick={() => removeFoodHandler(food?.id)}
                        >
                          X
                        </button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
              <div className={classes.nutrientsContainer}>
                <div className={classes.nutrientContainer}>
                  <span className={classes.smallTitle}>General</span>
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
                          <span>{total.energy}</span>
                        </td>
                        <td>
                          <span>kcal</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                  <span className={classes.smallTitle}>Carbohydrates</span>
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
                          <span>{total.carbs}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Fiber</td>
                        <td>
                          <span>{total.fiber}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Sugars</td>
                        <td>
                          <span>{total.sugar}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                  <span className={classes.smallTitle}>Protein</span>
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
                          <span>{total.protein}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                  <span className={classes.smallTitle}>Lipids</span>
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
                          <span>{total.fat}</span>
                        </td>
                        <td>
                          <span>g</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </div>
                <div className={classes.nutrientContainer}>
                  <span className={classes.smallTitle}>Vitamins</span>
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
                          <span>{total.vitaminA}</span>
                        </td>
                        <td>
                          <span>IU</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin B1</td>
                        <td>
                          <span>{total.vitaminB1}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin B2</td>
                        <td>
                          <span>{total.vitaminB2}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin B3</td>
                        <td>
                          <span>{total.vitaminB3}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin C</td>
                        <td>
                          <span>{total.vitaminC}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin D</td>
                        <td>
                          <span>{total.vitaminD}</span>
                        </td>
                        <td>
                          <span>IU</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Vitamin E</td>
                        <td>
                          <span>{total.vitaminE}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                  <span className={classes.smallTitle}>Minerals</span>
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
                          <span>{total.calcium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Iron</td>
                        <td>
                          <span>{total.iron}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Magnesium</td>
                        <td>
                          <span>{total.magnesium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Potassium</td>
                        <td>
                          <span>{total.potassium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Sodium</td>
                        <td>
                          <span>{total.sodium}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                      <tr>
                        <td>Zinc</td>
                        <td>
                          <span>{total.zinc}</span>
                        </td>
                        <td>
                          <span>mg</span>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
          </div>
        </form>
      </div>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={utils.modal}>
            <div className={classes.form}>
              <div className={utils.modalTitleDark}>
                <h2>Add ingredient to recipe</h2>
              </div>

              <div className={utils.modalContainer}>
                <div className={classes.dalContainer}>
                  <div>
                    <input
                      type="text"
                      placeholder="Search all foods..."
                      className={classes.allergySearchInput}
                    ></input>
                  </div>
                  <div className={classes.tableContainer}>
                    <table className={classes.styledTable}>
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Calories</th>
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        {allFood.map((food, index) => (
                          <tr key={index}>
                            <td>{food.name}</td>
                            <td>{food.calories}</td>
                            <td>
                              <button
                                className={classes.blackButton}
                                onClick={() => {
                                  setSelectedIngredient(food);
                                  setAmount(0);
                                }}
                              >
                                +
                              </button>
                            </td>
                          </tr>
                        ))}
                      </tbody>
                    </table>

                    {selectedIngredient && (
                      <div className={classes.selectedIngredientContainer}>
                        <span>{selectedIngredient?.name}</span>
                        <div className={classes.selectedIngredient}>
                          <div
                            className={
                              classes.selectedIngredientNutrientsContainer
                            }
                          >
                            <div>
                              <span>Calories: </span>
                              <span>
                                {selectedIngredient?.calories * amount}
                              </span>
                            </div>
                            <div>
                              <span>Carbohydrates: </span>
                              <span>
                                {selectedIngredient?.nutrientTable
                                  .carbohydrates * amount}
                              </span>
                            </div>
                            <div>
                              <span>Protein: </span>
                              <span>
                                {selectedIngredient?.nutrientTable.protein *
                                  amount}
                              </span>
                            </div>
                            <div>
                              <span>Fat: </span>
                              <span>
                                {selectedIngredient?.nutrientTable.fat * amount}
                              </span>
                            </div>
                          </div>
                          <div className={classes.amountContainer}>
                            <span>Amount :</span>
                            <input
                              ref={selectedFoodAmountRef}
                              value={amount}
                              onChange={handleAmountChange}
                              className={classes.amountInput}
                            ></input>
                          </div>
                        </div>
                      </div>
                    )}
                  </div>
                </div>
                <br></br>
                <div className={utils.buttonContainerRight}>
                  <button
                    className={utils.lightGreyButton}
                    onClick={handleClose}
                  >
                    Close
                  </button>
                  <button
                    className={utils.greenButton}
                    onClick={addFoodHandler}
                  >
                    Add
                  </button>
                </div>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default NewRecipe;
