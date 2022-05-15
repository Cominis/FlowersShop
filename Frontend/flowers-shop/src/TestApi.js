import { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import axios from "./net/axios"; //importuoti reikia custom axios komponenta!!!!

//POST'o example
const createPost = async () => {
  const payload = {
    userid: 42,
    firstName: "John",
    lastName: "Doe",
  };

  try {
    // axios automatically serializes the payload to JSON.
    // no need to JSON.stringify({ userid: 42, ...})
    const res = await axios.post("url", payload);
  } catch (error) {
    console.log(error);
  }
};

//GET'o example su uzloadinimu (viena karta!) atidarius sita psl
const TestApi = (props) => {
  const [user, setUser] = useState(null);
  const [error, setError] = useState(null);

  useEffect(() => {
    const PATH = "Users/d9a0a3cc-427e-4d4f-299f-08da36898730";

    const getData = async () => {
      try {
        const response = await axios.get(PATH);
        console.log(response);
        setUser(response.data.response);
      } catch (err) {
        console.log(err);
        setError(err);
      }
    };

    getData();
  }, []); // del '[]' bus loadinama tik viena karta

  let text = null;
  if (error) text = `Error: ${error.message}`;
  if (!user) text = "No user!";

  //printins visus values kurie yra string'ai
  const printStrings = (user) => {
    return Object.keys(user).map((el, i) => {
      const value = user[el];
      if (typeof value != "string") return null;
      else return <Typography key={i}>{value}</Typography>;
    });
  };

  return (
    <Box
      sx={{
        width: "100%",
        height: "100vh",
        display: "flex",
        flex: 1,
        flexDirection: "column",
        justifyContent: "center",
        alignItems: "center",
        py: 2,
      }}
    >
      {user ? printStrings(user) : text}
    </Box>
  );
};

export default TestApi;
