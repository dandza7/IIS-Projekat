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
import { Chart as ChartJs, ArcElement, Tooltip, Legend } from "chart.js";
import { Doughnut } from "react-chartjs-2";
ChartJs.register(ArcElement, Tooltip, Legend);

function age(dateString: Date) {
  var today = new Date();
  var birthDate = new Date(dayjs(dateString).format("MMM D, YYYY"));
  var age = today.getFullYear() - birthDate.getFullYear();
  var m = today.getMonth() - birthDate.getMonth();
  if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
    age--;
  }
  return age;
}

type patient = {
  name: string;
  surname: string;
  birthDate: Date;
  gender: string;
  weight: number;
  height: number;
  sessionsPerWeek: number;
};

type nutrition = {
  protein: number;
  carbs: number;
  fat: number;
  energy: number;
  fiber: number;
  sugar: number;
  vitaminA: number;
  vitaminB1: number;
  vitaminB2: number;
  vitaminB3: number;
  vitaminC: number;
  vitaminD: number;
  vitaminE: number;
  calcium: number;
  iron: number;
  magnesium: number;
  potassium: number;
  sodium: number;
  zinc: number;
};
type recipe = {
  id: number;
  name: string;
  amount: number;
  calories: number;
  nutrientTable: nutrition[];
};
type recipeBE = {
  portionSize: number;
  recipe: {
    id: number;
    name: string;
    calories: number;
    nutrientTable: nutrition[];
    ingredients: { name: string; amount: number }[];
  };
};
const NewMealPlan = () => {
  const authCtx = useContext(AuthContext);
  const [allFood, setAllFood] = useState<any[]>([]);
  const [open, setOpen] = React.useState(false);
  const selectedFoodAmountRef = useRef(null);
  const [mealName, setMealName] = useState("");
  const [patient, setPatient] = useState<patient | null>(null);
  const handleOpen = (name: string) => {
    setOpen(true);
    setSelectedIngredient(null);
    setMealName(name);
  };
  const handleClose = () => setOpen(false);

  const [breakFast, setBreakfast] = useState<any[]>([]);
  const [lunch, setLunch] = useState<any[]>([]);
  const [dinner, setDinner] = useState<any[]>([]);
  const [snacks, setSnacks] = useState<any[]>([]);
  const [wholePlan, setWholePlan] = useState<any[]>([]);
  const [amount, setAmount] = useState(0);

  const [selectedIngredient, setSelectedIngredient] = useState<recipe | null>(
    null
  );
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

  useEffect(() => {
    const patientId = localStorage.getItem("patientId");
    console.log(patientId);
    fetch("http://localhost:5041/api/patients/" + patientId, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
    })
      .then((response) => response.json())
      .then((actualData) => {
        setPatient(actualData);
      });
  }, []);

  const fetchNutritionPlan = () => {
    const patientId = localStorage.getItem("patientId");
    fetch("http://localhost:5041/api/nutritions", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        userId: patientId,
        date: dayjs(value).format("YYYY-MM-D"),
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        setBreakfast(actualData.breakfasts);
        setLunch(actualData.lunches);
        setDinner(actualData.dinners);
        setSnacks(actualData.snacks);
        let plan: recipe[] = [];
        let plan1 = plan.concat(
          actualData.breakfasts,
          actualData.lunches,
          actualData.dinners,
          actualData.snacks
        );
        setWholePlan(plan1);
      });
  };
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

  useEffect(() => {
    fetchNutritionPlan();
  }, [value]);

  const fetchRecipes = () => {
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
        setAllFood(actualData.items);
      });
  };

  useEffect(() => {
    console.log(wholePlan);
    const totalT: nutrition = {
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
    };
    wholePlan.map((recipe) => {
      totalT.protein +=
        recipe?.recipe?.nutrientTable?.protein * recipe.portionSize;
      totalT.carbs +=
        recipe?.recipe?.nutrientTable?.carbohydrates * recipe.portionSize;
      totalT.fat += recipe?.recipe?.nutrientTable?.fat * recipe.portionSize;
      totalT.energy += recipe?.recipe?.calories * recipe.portionSize;
      totalT.fiber += recipe?.recipe?.nutrientTable?.fiber * recipe.portionSize;
      totalT.sugar += recipe?.recipe?.nutrientTable?.sugar * recipe.portionSize;
      totalT.vitaminA +=
        recipe?.recipe?.nutrientTable?.vitaminA * recipe.portionSize;
      totalT.vitaminB1 +=
        recipe?.recipe?.nutrientTable?.vitaminB1 * recipe.portionSize;
      totalT.vitaminB2 +=
        recipe?.recipe?.nutrientTable?.vitaminB2 * recipe.portionSize;
      totalT.vitaminB3 +=
        recipe?.recipe?.nutrientTable?.vitaminB3 * recipe.portionSize;
      totalT.vitaminC +=
        recipe?.recipe?.nutrientTable?.vitaminC * recipe.portionSize;
      totalT.vitaminD +=
        recipe?.recipe?.nutrientTable?.vitaminD * recipe.portionSize;
      totalT.vitaminE +=
        recipe?.recipe?.nutrientTable?.vitaminE * recipe.portionSize;
      totalT.calcium +=
        recipe?.recipe?.nutrientTable?.calcium * recipe.portionSize;
      totalT.iron += recipe?.recipe?.nutrientTable?.iron * recipe.portionSize;
      totalT.magnesium +=
        recipe?.recipe.nutrientTable?.magnesium * recipe.portionSize;
      totalT.potassium +=
        recipe?.recipe.nutrientTable?.potassium * recipe.portionSize;
      totalT.sodium +=
        recipe?.recipe.nutrientTable?.sodium * recipe.portionSize;
      totalT.zinc += recipe?.recipe.nutrientTable?.zinc * recipe.portionSize;
    });

    setTotal({
      protein: totalT.protein,
      carbs: totalT.carbs,
      fat: totalT.fat,
      sugar: totalT.sugar,
      fiber: totalT.fiber,
      energy: totalT.energy,
      vitaminA: totalT.vitaminA,
      vitaminB1: totalT.vitaminB1,
      vitaminB2: totalT.vitaminB2,
      vitaminB3: totalT.vitaminB3,
      vitaminC: totalT.vitaminC,
      vitaminD: totalT.vitaminD,
      vitaminE: totalT.vitaminE,
      calcium: totalT.calcium,
      magnesium: totalT.magnesium,
      iron: totalT.iron,
      potassium: totalT.potassium,
      sodium: totalT.sodium,
      zinc: totalT.zinc,
    });
  }, [wholePlan]);

  const addFoodHandler = () => {
    event?.preventDefault();
    console.log(breakFast);
    const si: recipeBE = {
      portionSize: 0,
      recipe: {
        id: 0,
        name: "",
        calories: 0,
        ingredients: [],
        nutrientTable: [],
      },
    };
    si.portionSize = selectedFoodAmountRef?.current?.value;
    si.recipe.id = selectedIngredient ? selectedIngredient?.id : -1;
    si.recipe.name = selectedIngredient ? selectedIngredient?.name : "";
    si.recipe.calories = selectedIngredient ? selectedIngredient?.calories : -1;
    si.recipe.ingredients = [];
    si.recipe.nutrientTable = selectedIngredient
      ? selectedIngredient?.nutrientTable
      : [];
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
    var updatedList = [...wholePlan];
    updatedList = [...wholePlan, si];
    setWholePlan(updatedList);
    handleClose();
  };

  const handleAmountChange = () => {
    setAmount(event?.target.value);
  };

  const removeFoodHandler = (recipeName: string, meal: string) => {
    let breakFast1 = breakFast.filter(
      (recipe) => recipe.recipe.name !== recipeName
    );
    let wholePlan1 = wholePlan.filter(
      (recipe) => recipe.recipe.name !== recipeName
    );
    setWholePlan(wholePlan1);
    switch (meal) {
      case "breakfast":
        setBreakfast(breakFast1);
      case "lunch":
        setLunch((current) =>
          current.filter((recipe) => recipe.recipe.name !== recipeName)
        );
      case "dinner":
        setDinner((current) =>
          current.filter((recipe) => recipe.recipe.name !== recipeName)
        );
      case "snack":
        setSnacks((current) =>
          current.filter((recipe) => recipe.recipe.name !== recipeName)
        );
    }
  };

  const addRecipeHandler = () => {
    event?.preventDefault();
    const selectedBreakfast: { recipeId: number; portionSize: number }[] = [];
    const selectedLunch: { recipeId: number; portionSize: number }[] = [];
    const selectedDinner: { recipeId: number; portionSize: number }[] = [];
    const selectedSnack: { recipeId: number; portionSize: number }[] = [];
    breakFast.forEach((recipe) => {
      selectedBreakfast.push({
        recipeId: recipe.recipe.id,
        portionSize: recipe.portionSize,
      });
    });
    lunch.forEach((recipe) => {
      selectedLunch.push({
        recipeId: recipe.recipe.id,
        portionSize: recipe.portionSize,
      });
    });
    dinner.forEach((recipe) => {
      selectedDinner.push({
        recipeId: recipe.recipe.id,
        portionSize: recipe.portionSize,
      });
    });
    snacks.forEach((recipe) => {
      selectedSnack.push({
        recipeId: recipe.recipe.id,
        portionSize: recipe.portionSize,
      });
    });
    console.log(selectedBreakfast);

    fetch("http://localhost:5041/api/nutritions/update", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        userId: localStorage.getItem("patientId"),
        date: dayjs(value).format("YYYY-MM-D"),
        breakfasts: selectedBreakfast,
        lunches: selectedLunch,
        dinners: selectedDinner,
        snacks: selectedSnack,
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        alert("Plan has been successfully updated!");
      });
  };

  let bmr =
    patient?.gender == "Male"
      ? Math.round(
          88.4 +
            13.4 * patient?.weight +
            4.8 * patient?.height -
            5.68 * age(patient?.birthDate)
        )
      : Math.round(
          447.6 +
            9.25 * patient?.weight +
            3.1 * patient?.height -
            4.33 * age(patient?.birthDate)
        );
  const optimal = {
    protein: Math.round((bmr * 0.24) / 4),
    carbs: Math.round((bmr * 0.52) / 4),
    fat: Math.round((bmr * 0.24) / 9),
    energy: bmr,
    fiber: 25,
    sugar: 33,
    vitaminA: 700,
    vitaminB1: 1.4,
    vitaminB2: 1.6,
    vitaminB3: 18,
    vitaminC: 75,
    vitaminD: 600,
    vitaminE: 10,
    calcium: 1000,
    iron: 15,
    magnesium: 350,
    potassium: 3500,
    sodium: 2400,
    zinc: 15,
  };
  const macrosDataPH = {
    labels: ["Carbs", "Protein", "Fat"],
    datasets: [
      {
        data: [1, 1, 1],
        backgroundColor: ["#42f5ce", "#12725d", "#2ac9aa"],
      },
    ],
  };

  const macrosData = {
    labels: ["Carbs", "Protein", "Fat"],
    datasets: [
      {
        data: [total.carbs, total.protein, total.fat],
        backgroundColor: ["#42f5ce", "#12725d", "#2ac9aa"],
      },
    ],
  };
  const bmrData = {
    labels: ["Consumed", "Remaining"],
    datasets: [
      {
        data: [total.energy, bmr - total.energy],
        backgroundColor: ["#42f5ce", "#12725d"],
      },
    ],
  };
  const options = {
    plugins: { legend: { position: "right" } },
  };

  return (
    <div className={classes.newRecipe}>
      <div className={utils.title}>Meal plan</div>
      <div>
        <div className={utils.form}>
          <div className={classes.nutrientsContainer2}>
            <div className={classes.container}>
              <div className={classes.dataContainer}>
                <div className={classes.infoContainer}>
                  <div className={classes.spanFlex}>
                    <label>Name: </label>
                    <span>
                      {patient?.name} {patient?.surname}
                    </span>
                  </div>
                  <div className={classes.spanFlex}>
                    <label>Gender: </label>
                    <span>{patient?.gender}</span>
                  </div>
                  <div className={classes.spanFlex}>
                    <label>Date of birth: </label>
                    <span>{age(patient?.birthDate)}</span>
                  </div>
                  <div className={classes.spanFlex}>
                    <label>Height: </label>
                    <span>{patient?.height} cm</span>
                  </div>
                  <div className={classes.spanFlex}>
                    <label>Weight: </label>
                    <span>{patient?.weight} kg</span>
                  </div>

                  <div className={classes.spanFlex}>
                    <label>Activity level: </label>
                    <span>
                      {patient?.sessionsPerWeek > 5
                        ? "Very active"
                        : patient?.sessionsPerWeek < 2
                        ? "Not active"
                        : "Active"}
                    </span>
                  </div>
                </div>
              </div>
            </div>
            <div className={classes.nutrientsContainer}>
              <div className={classes.container}>
                <div className={classes.nutrientsContainer}>
                  <LocalizationProvider dateAdapter={AdapterDayjs}>
                    <DatePicker
                      value={value}
                      onChange={(newValue) => {
                        setValue(newValue);
                        setBreakfast([]);
                        setLunch([]);
                        setDinner([]);
                        setSnacks([]);
                        setTotal({
                          protein: 1,
                          carbs: 1,
                          fat: 1,
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
                      }}
                    />
                  </LocalizationProvider>
                  <button
                    className={utils.blackButton}
                    onClick={addRecipeHandler}
                  >
                    Save
                  </button>
                </div>
                <div className={classes.chartsContainer}>
                  <span className={classes.smallTitle}>Nutrients </span>
                  <div className={classes.chartsContainer_}>
                    {wholePlan.length > 0 && (
                      <div className={classes.chartContainer}>
                        <Doughnut
                          data={macrosData}
                          options={options}
                        ></Doughnut>
                      </div>
                    )}
                    {wholePlan.length == 0 && (
                      <div className={classes.chartContainer}>
                        <Doughnut
                          data={macrosDataPH}
                          options={options}
                        ></Doughnut>
                      </div>
                    )}
                    <div className={classes.chartContainer}>
                      <Doughnut data={bmrData} options={options}></Doughnut>
                    </div>
                  </div>
                  <div className={classes.calorieIntakeContainer}>
                    <span className={classes.smallTitle}>Calorie intake: </span>
                    <span
                      className={
                        total?.energy <= bmr
                          ? classes.smallTitle
                          : classes.smallTitleRed
                      }
                    >
                      {total.energy}
                    </span>
                    <span className={classes.smallTitle}>/ {bmr}</span>
                  </div>
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
                          onClick={() => {
                            handleOpen("Breakfast");
                            fetchRecipes();
                          }}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {breakFast?.map((recipe, index) => (
                      <tr key={index}>
                        <td>{recipe?.recipe?.name}</td>
                        <td>{recipe?.portionSize}</td>
                        <td>
                          {recipe?.recipe?.calories * recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.protein *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.carbohydrates *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.fat *
                            recipe?.portionSize}
                        </td>
                        <td>
                          <button
                            className={classes.deleteButton}
                            onClick={() =>
                              removeFoodHandler(
                                recipe?.recipe?.name,
                                "breakfast"
                              )
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
                          onClick={() => {
                            handleOpen("Lunch");
                            fetchRecipes();
                          }}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {lunch.map((recipe, index) => (
                      <tr key={index}>
                        <td>{recipe?.recipe?.name}</td>
                        <td>{recipe?.portionSize}</td>
                        <td>
                          {recipe?.recipe?.calories * recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.protein *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.carbohydrates *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.fat *
                            recipe?.portionSize}
                        </td>
                        <td>
                          <button
                            className={classes.deleteButton}
                            onClick={() =>
                              removeFoodHandler(recipe?.recipe?.name, "lunch")
                            }
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
                          onClick={() => {
                            handleOpen("Dinner");
                            fetchRecipes();
                          }}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {dinner.map((recipe, index) => (
                      <tr key={index}>
                        <td>{recipe?.recipe?.name}</td>
                        <td>{recipe?.portionSize}</td>
                        <td>
                          {recipe?.recipe?.calories * recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.protein *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.carbohydrates *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.fat *
                            recipe?.portionSize}
                        </td>
                        <td>
                          <button
                            className={classes.deleteButton}
                            onClick={() =>
                              removeFoodHandler(recipe?.recipe?.name, "dinner")
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
                          onClick={() => {
                            handleOpen("Snack");
                            fetchRecipes();
                          }}
                        ></AddIcon>
                      </th>
                    </tr>
                  </thead>
                  <tbody>
                    {snacks.map((recipe, index) => (
                      <tr key={index}>
                        <td>{recipe?.recipe?.name}</td>
                        <td>{recipe?.portionSize}</td>
                        <td>
                          {recipe?.recipe?.calories * recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.protein *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.carbohydrates *
                            recipe?.portionSize}
                        </td>
                        <td>
                          {recipe?.recipe?.nutrientTable?.fat *
                            recipe?.portionSize}
                        </td>
                        <td>
                          <button
                            className={classes.deleteButton}
                            onClick={() =>
                              removeFoodHandler(recipe?.recipe?.name, "snack")
                            }
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
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Energy</td>
                          <td>
                            <span>{total?.energy}</span>
                          </td>
                          <td>
                            <span>kcal</span>
                          </td>
                          <td>
                            <span>{optimal?.energy}</span>
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
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Total</td>
                          <td>
                            <span>{total?.carbs}</span>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                          <td>
                            <span>{optimal?.carbs}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Fiber</td>
                          <td>
                            <span>{total?.fiber}</span>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                          <td>
                            <span>{optimal?.fiber}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Sugars</td>
                          <td>
                            <span>{total?.sugar}</span>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                          <td>
                            <span>{optimal?.sugar}</span>
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
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Total Protein</td>
                          <td>
                            <span>{total?.protein}</span>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                          <td>
                            <span>{optimal?.protein}</span>
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
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Total Fat</td>
                          <td>
                            <span>{total?.fat}</span>
                          </td>
                          <td>
                            <span>g</span>
                          </td>
                          <td>
                            <span>{optimal?.fat}</span>
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
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Vitamin A</td>
                          <td>
                            <span>{total?.vitaminA}</span>
                          </td>
                          <td>
                            <span>mcg</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminA}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin B1</td>
                          <td>
                            <span>{total?.vitaminB1}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminB1}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin B2</td>
                          <td>
                            <span>{total?.vitaminB2}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminB2}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin B3</td>
                          <td>
                            <span>{total?.vitaminB3}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminB3}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin C</td>
                          <td>
                            <span>{total?.vitaminC}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminC}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin D</td>
                          <td>
                            <span>{total?.vitaminD}</span>
                          </td>
                          <td>
                            <span>IU</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminD}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Vitamin E</td>
                          <td>
                            <span>{total?.vitaminE}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.vitaminE}</span>
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
                          <th></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>Calcium</td>
                          <td>
                            <span>{total?.calcium}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.calcium}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Iron</td>
                          <td>
                            <span>{total?.iron}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.iron}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Magnesium</td>
                          <td>
                            <span>{total?.magnesium}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.magnesium}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Potassium</td>
                          <td>
                            <span>{total?.potassium}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.potassium}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Sodium</td>
                          <td>
                            <span>{total?.sodium}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.sodium}</span>
                          </td>
                        </tr>
                        <tr>
                          <td>Zinc</td>
                          <td>
                            <span>{total?.zinc}</span>
                          </td>
                          <td>
                            <span>mg</span>
                          </td>
                          <td>
                            <span>{optimal?.zinc}</span>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
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
                            <td>{food?.name}</td>
                            <td>{food?.calories}</td>
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
                                  ?.carbohydrates * amount}
                              </span>
                            </div>
                            <div>
                              <span>Protein: </span>
                              <span>
                                {selectedIngredient?.nutrientTable?.protein *
                                  amount}
                              </span>
                            </div>
                            <div>
                              <span>Fat: </span>
                              <span>
                                {selectedIngredient?.nutrientTable?.fat *
                                  amount}
                              </span>
                            </div>
                          </div>
                          <div className={classes.amountContainer}>
                            <span>Portion size :</span>
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

export default NewMealPlan;
