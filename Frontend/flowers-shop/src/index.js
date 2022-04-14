import { StrictMode } from "react";
import { createRoot } from "react-dom/client";

import App from "./App";
import SignIn from "./SignIn";
import reportWebVitals from "./reportWebVitals";

const rootElement = document.getElementById("root");
const root = createRoot(rootElement);

root.render(
  <StrictMode>
    <SignIn />
  </StrictMode>
);

reportWebVitals();
