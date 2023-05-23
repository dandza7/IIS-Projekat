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
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { DatePicker } from "@mui/x-date-pickers/DatePicker";
import dayjs, { Dayjs } from "dayjs";

const NewMealPlan = () => {
  const navigate = useNavigate();

  type patientT = {
    name: string;
  };

  const [foodList, setfoodList] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [allFood, setAllFood] = useState<any[]>([]);
  const [open, setOpen] = React.useState(false);
  const selectedFoodAmountRef = useRef();
  const [mealName, setMealName] = useState("");
  const [patient, setPatient] = useState<patientT>();
  const nameRef = useRef();
  const handleOpen = (name: string) => {
    setOpen(true);
    setSelectedIngredient(null);
    setMealName(name);
  };
  const handleClose = () => setOpen(false);
  const [selectedFood, setSelectedFood] = useState<any[]>([]);
  const [breakFast, setBreakfast] = useState<any[]>([]);
  const [lunch, setLunch] = useState<any[]>([]);
  const [dinner, setDinner] = useState<any[]>([]);
  const [snacks, setSnacks] = useState<any[]>([]);
  const [amount, setAmount] = useState(0);
  const [selectedIngredient, setSelectedIngredient] = useState(null);
  const [value, setValue] = React.useState<Dayjs | null>(dayjs(Date.now()));
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
    if (mealName == "Breakfast") {
      var updatedList = [...breakFast];
      updatedList = [...breakFast, si];
      setBreakfast(updatedList);
    } else if (mealName == "Lunch") {
      var updatedList = [...lunch];
      updatedList = [...lunch, si];
      setLunch(updatedList);
    } else if (mealName == "Dinner") {
      var updatedList = [...dinner];
      updatedList = [...dinner, si];
      setDinner(updatedList);
    } else if (mealName == "Snack") {
      var updatedList = [...snacks];
      updatedList = [...snacks, si];
      setSnacks(updatedList);
    }
    handleClose();
  };

  const handleAmountChange = () => {
    setAmount(event?.target.value);
  };

  const removeFoodHandler = (foodId: number, meal: string) => {
    switch (meal) {
      case "breakfast":
        setBreakfast((current) => current.filter((food) => food.id !== foodId));
      case "lunch":
        setLunch((current) => current.filter((food) => food.id !== foodId));
      case "dinner":
        setDinner((current) => current.filter((food) => food.id !== foodId));
      case "snack":
        setSnacks((current) => current.filter((food) => food.id !== foodId));
    }
  };

  const addRecipeHandler = () => {
    event?.preventDefault();
    const selectedFood: { foodId: number; amount: number }[] = [];
    const enteredName = nameRef.current.value;
    breakFast.forEach((food) => {
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
    fetch("http://localhost:5041/api/profiles", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        pageSize: 0,
        page: 0,
        order: [
          {
            orderField: "ID",
            ordering: "ASC",
          },
        ],
        filters: [
          {
            property: "Email",
            connecting: 0,
            filterValues: [
              {
                value: localStorage.getItem("patientEmail"),
                operation: 1,
              },
            ],
          },
        ],
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData.items);
        setPatient(actualData.items[0]);
      });

    fetch("http://localhost:5041/api/recipes/detailed", {
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
      <div className={utils.title}>Meal plan</div>
      <div>
        <form className={utils.form}>
          <div className={classes.nutrientsContainer}>
            <div className={classes.container}>
              <div className={classes.dataContainer}>
                <div className={utils.spanFlex}>
                  <label>Name: </label>
                  <span>{patient?.name}</span>
                </div>
                <div className={utils.spanFlex}>
                  <label>Surname: </label>
                  <span>{patient?.surname}</span>
                </div>
                <div className={utils.spanFlex}>
                  <label>Gender: </label>
                  <span>{patient?.gender}</span>
                </div>
                <div className={utils.spanFlex}>
                  <label>Date of birth: </label>
                  <span>{dayjs(patient?.birthDate).format("MMM D, YYYY")}</span>
                </div>

                <div className={utils.spanFlex}>
                  <label>Weight: </label>
                  <span>50</span>
                </div>
                <div className={utils.spanFlex}>
                  <label>Height: </label>
                  <span>170</span>
                </div>
              </div>
            </div>
            <div className={classes.nutrientsContainer}>
              <div className={classes.container}>
                <div className={classes.nutrientsContainer}>
                  <LocalizationProvider dateAdapter={AdapterDayjs}>
                    <DatePicker
                      renderInput={(props) => <TextField {...props} />}
                      value={value}
                      onChange={(newValue) => {
                        setValue(newValue);
                        setBreakfast([]);
                        setLunch([]);
                        setDinner([]);
                        setSnacks([]);
                      }}
                    />
                  </LocalizationProvider>
                  <button className={utils.blackButton}>Save</button>
                </div>
                <span className={classes.smallTitle}>Breakfast</span>
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
                        <AddIcon
                          fontSize="small"
                          onClick={() => handleOpen("Breakfast")}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {breakFast.map((food, index) => (
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
                            onClick={() =>
                              removeFoodHandler(food?.id, "breakfast")
                            }
                          >
                            X
                          </button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
                <span className={classes.smallTitle}>Lunch</span>
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
                        <AddIcon
                          fontSize="small"
                          onClick={() => handleOpen("Lunch")}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {lunch.map((food, index) => (
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
                            onClick={() => removeFoodHandler(food?.id, "lunch")}
                          >
                            X
                          </button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
                <span className={classes.smallTitle}>Dinner</span>
                <table className={classes.styledTableFoods} id="dinner">
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Amount</th>
                      <th>Calories</th>
                      <th>Protein</th>
                      <th>Total Carbs</th>
                      <th>Total Fat</th>
                      <th>
                        <AddIcon
                          fontSize="small"
                          onClick={() => handleOpen("Dinner")}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {dinner.map((food, index) => (
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
                            onClick={() =>
                              removeFoodHandler(food?.id, "dinner")
                            }
                          >
                            X
                          </button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
                <span className={classes.smallTitle}>Snack</span>
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
                        <AddIcon
                          fontSize="small"
                          onClick={() => handleOpen("Snack")}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {snacks.map((food, index) => (
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
                            onClick={() => removeFoodHandler(food?.id, "snack")}
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
                <h2>Add to meal plan</h2>
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

export default NewMealPlan;
