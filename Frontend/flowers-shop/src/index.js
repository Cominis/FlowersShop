import { StrictMode } from "react";
import { createRoot } from "react-dom/client";

import App from "./App";
import SignIn from "./SignIn";
import SignUp from "./SignUp";
import reportWebVitals from "./reportWebVitals";
import { AppRegistrationRounded } from "@mui/icons-material";

const rootElement = document.getElementById("root");
const root = createRoot(rootElement);

root.render(
  <StrictMode>
    {/*<SignIn />*/}
    <SignUp />
  </StrictMode>
);

reportWebVitals();
