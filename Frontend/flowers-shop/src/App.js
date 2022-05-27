import { Container } from "@mui/material";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Header from "./header/Header";
import Homepage from "./homepage/Homepage";
import Cart from "./cart/Cart";
import SignIn from "./login/SignIn";
import SignUp from "./login/SignUp";
import TestApi from "./TestApi";
import PersonalDataPage from "./personalDataPage/PersonalDataPage";

const App = () => {
    return (
        <Router>
            <Container>
                <Header />
                <Routes>
                    <Route path="/" element={<Homepage />} />
                    <Route path="/cart" element={<Cart />} />
                    <Route path="/signIn" element={<SignIn />} />
                    <Route path="/signUp" element={<SignUp />} />
                    <Route path="/user" element={<PersonalDataPage />} />
                    {/* <TestApi /> */}
                </Routes>
            </Container>
        </Router>
    );
};

export default App;
