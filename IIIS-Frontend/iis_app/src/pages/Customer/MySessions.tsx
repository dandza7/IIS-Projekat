import React from "react";
import classes from "../Trainer/styles/TrainingPlan.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState, useRef, useContext } from "react";
import AuthContext from "../../store/auth-context";
import { useParams } from "react-router-dom";
import utils from "../styles/Utils.module.css";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import Modal from "@mui/material/Modal";
import AddIcon from "@mui/icons-material/Add";
import dayjs from "dayjs";

const style = {
  position: "absolute" as "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "background.paper",
  boxShadow: 24,
  p: 0.5,
  borderRadius: 3,
};

const MySessions = () => {
  const [sessions, setSessions] = useState<any[]>([]);
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const [selectedSession, setSelectedSession] = useState(null);
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
  useEffect(() => {
    fetch("http://localhost:5041/api/training-session", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + authCtx.token,
      },
      body: JSON.stringify({
        name: "Any",
        paginationQuery: {
          pageSize: 1,
          page: 1,
        },
      }),
    })
      .then((response) => response.json())
      .then((actualData) => {
        console.log(actualData);
        console.log(actualData.items);
        setSessions(actualData.items);
      });
  }, []);

  return (
    <div className={utils.whiteContainer}>
      <h2>My sessions</h2>
      {sessions?.length !== 0 ? (
        <div className={classes.trainingPlanRequests}>
          <table className={classes.tpTable}>
            <thead>
              <tr>
                <th>Name</th>
                <th>Date</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              {sessions?.map((session, index) => (
                <tr key={index}>
                  <td>{session.name}</td>
                  <td>{dayjs(session.date).format("DD.MM.YYYY")}</td>
                  <td>
                    <button
                      className={utils.greenMenuButton}
                      onClick={() => {
                        setSelectedSession(session);
                        handleOpen();
                      }}
                    >
                      View
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      ) : (
        <>
          <br></br>
          <span>You do not have any saved sessions.</span>
        </>
      )}
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <div className={classes.modal}>
            <div className={classes.modalTitle}>
              <h2>{selectedSession?.name}</h2>
              <div className={classes.modalClose} onClick={handleClose}>
                X
              </div>
            </div>

            <div className={classes.modalContainer}>
              <div className={classes.session_exerciseInfo}>
                <span className={classes.span}>
                  <h3>Date: </h3>
                  <h3>{dayjs(selectedSession?.date).format("DD.MM.YYYY")}</h3>
                </span>

                {selectedSession?.exerciseInfo.map((session, index) => (
                  <>
                    <h3>{session.name}</h3>
                    <table className={classes.tpTable}>
                      <thead>
                        <tr>
                          <th>Set</th>
                          <th>Weight</th>
                          <th>Repetitons</th>
                        </tr>
                      </thead>
                      <tbody>
                        {session?.setInfo.map((session, index) => (
                          <tr key={index}>
                            <td>{`Set ${index + 1}`}</td>
                            <td>{session.weight} kg</td>
                            <td>{session.repetitions}</td>
                          </tr>
                        ))}
                      </tbody>
                    </table>
                  </>
                ))}
              </div>
            </div>
          </div>
        </Box>
      </Modal>
    </div>
  );
};

export default MySessions;
