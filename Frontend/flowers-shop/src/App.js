import { Container } from "@mui/material";
import Header from "./header/Header";
import Homepage from "./homepage/Homepage";
import Cart from "./cart/Cart";


const App = () => {
  return (
    <Container>
      <Header />
      <Homepage />
    </Container>
  );
};

export default App;
