import { Container } from "@mui/material";
import Header from "./header/Header";
import Homepage from "./homepage/Homepage";
import Cart from "./cart/Cart";
import SignIn from "./login/SignIn";
import SignUp from "./login/SignUp";
import TestApi from "./TestApi";
import ShopItems from "./shop-items/ShopItems";

const App = () => {
  return (
    <Container>
      {/* <TestApi /> */}
      <Header />
          <Cart />
    </Container>
  );
};

export default App;
