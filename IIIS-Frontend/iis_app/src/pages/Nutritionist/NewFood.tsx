import React from "react";
import utils from "../styles/Utils.module.css";
import AuthContext from "../../store/auth-context";
import { useEffect, useState, useRef, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { useParams } from "react-router-dom";
import classes from "./styles/Food.module.css";
import Box from "@mui/material/Box";
import AddIcon from "@mui/icons-material/Add";
import Modal from "@mui/material/Modal";

export const NewFood = () => {
  const navigate = useNavigate();
  const [foodList, setfoodList] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const [allAllergies, setAllAllergies] = useState<any[]>([]);
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  const [selectedAllergies, setselectedAllergies] = useState<any[]>([]);
  const [allergies, setAllergies] = useState<any[]>([]);

  const style = {
    position: "absolute" as "absolute",
    top: "50%",
    left: "50%",
    transform: "translate(-50%, -50%)",
    bgcolor: "background.paper",
    boxShadow: 24,
    borderRadius: 3,
  };

  useEffect(() => {
    console.log(authCtx.token);
    fetch("http://localhost:5041/api/allergies", {
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
        setAllAllergies(actualData.items);
      });
  }, []);

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

  const addAllergyHandler = (allergy: any) => {
    var updatedList = [...selectedAllergies];
    updatedList = [...selectedAllergies, allergy];
    setselectedAllergies(updatedList);
  };

  const removeAllergyHandler = (allergen: any) => {
    setselectedAllergies((current) =>
      current.filter((allergy) => allergy.id !== allergen.id)
    );
  };

  const saveAllergiesHandler = () => {
    setAllergies(selectedAllergies);
  };

  return (
    <div>
      <div className={utils.whiteContainer}>
        <div className={classes.categoryContainer}>
          <h3>Food name: </h3>
          <input
            type="text"
            className={classes.nameInput}
            ref={nameRef}
          ></input>
        </div>
        <div className={classes.categoryContainer}>
          <h3>Category: </h3>
          <select ref={categoryRef} className={utils.select}>
            <option>Grains</option>
            <option>Meat</option>
            <option>Fish</option>
            <option>Oil</option>
            <option>Fruit</option>
            <option>Vegetables</option>
            <option>Drink</option>
            <option>Eggs</option>
            <option>Nuts</option>
          </select>
        </div>
        <div className={classes.nutrientContainer}>
          <div className={classes.macros}>
            <h3>General</h3>
            <table className={classes.nutrientTable}>
              <thead>
                <tr>
                  <th>Name</th>
                  <th>Amount</th>
                  <th>Unit</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>Energy</td>
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
            <h3>Carbohydrates</h3>
            <table className={classes.nutrientTable}>
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
                    <span>
                      <input
                        className={classes.nutrientInput}
                        ref={carbsRef}
                      ></input>
                    </span>
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
            <h3>Protein</h3>
            <table className={classes.nutrientTable}>
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
                    <span>
                      <input
                        className={classes.nutrientInput}
                        ref={proteinRef}
                      ></input>
                    </span>
                  </td>
                  <td>
                    <span>g</span>
                  </td>
                </tr>
              </tbody>
            </table>
            <h3>Lipids</h3>
            <table className={classes.nutrientTable}>
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
            <h3>Allergens</h3>
            <table className={classes.nutrientTable}>
              <thead>
                <tr>
                  <th>Allergen</th>
                  <th>
                    <AddIcon fontSize="small" onClick={handleOpen}></AddIcon>
                  </th>
                </tr>
              </thead>
              <tbody>
                {allergies?.map((allergy, index) => (
                  <tr key={index}>
                    <td>{allergy?.name}</td>
                    <td></td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
          <div className={classes.micros}>
            <h3>Vitamins</h3>
            <table className={classes.nutrientTable}>
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
                    <span>mcg</span>
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
            <h3>Minerals</h3>
            <table className={classes.nutrientTable}>
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
                  <td>Potassium</td>
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
      </div>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>Add allergen</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.tableContainer}>
                <table className={classes.allergenTable}>
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th></th>
                    </tr>
                  </thead>
                  <tbody>
                    {allAllergies?.map((allergy, index) => (
                      <tr key={index}>
                        <td>{allergy?.name}</td>
                        <td>
                          <button
                            className={classes.addAllergyButton}
                            onClick={() => {
                              addAllergyHandler(allergy);
                            }}
                          >
                            +
                          </button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
                <div className={classes.allergyContainer}>
                  {selectedAllergies?.map((allergy, index) => (
                    <button
                      className={classes.removeAllergyButton}
                      onClick={() => removeAllergyHandler(allergy)}
                    >
                      {allergy.name}
                    </button>
                  ))}
                </div>
              </div>

              <div className={utils.rightContainer}>
                <button
                  className={utils.greenButton}
                  onClick={saveAllergiesHandler}
                >
                  Save
                </button>
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};
