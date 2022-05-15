import axios from "axios";

const updatedAxios = axios.create({
  baseURL: "https://localhost:7158/api/",
  headers: {
    "Access-Control-Allow-Origin": "*",
    "Access-Control-Allow-Methods": "*",
  },
});

export default updatedAxios;
