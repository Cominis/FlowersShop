import { Container } from "@mui/material";
import Header from "./header/Header";
import Homepage from "./homepage/Homepage";
import Cart from "./cart/Cart";
import SignIn from "./login/SignIn";
import SignUp from "./login/SignUp";
import TestApi from "./TestApi";

const App = () => {
  return (
    <Container>
      {/* <TestApi /> */}
      <Header />
      <Homepage />
    </Container>
  );
};

export default App;
