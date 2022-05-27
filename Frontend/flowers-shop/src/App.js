import { Container } from "@mui/material";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Header from "./header/Header";
import Homepage from "./homepage/Homepage";
import Cart from "./cart/Cart";
import SignIn from "./login/SignIn";
import SignUp from "./login/SignUp";
import TestApi from "./TestApi";
import ShopItems from "./shop-items/ShopItems";
import PersonalDataPage from "./personalDataPage/PersonalDataPage";
import MyShopPage from "./personalDataPage/MyShopPage";
import * as React from "react";

const defaultGlobalState = {
    isLoggedIn: true
};

const globalStateContext = React.createContext(defaultGlobalState);
const dispatchStateContext = React.createContext(undefined);

const GlobalStateProvider = ({ children }) => {
    const [state, dispatch] = React.useReducer(
        (state, newValue) => ({ ...state, ...newValue }),
        defaultGlobalState
    );
    return (
        <globalStateContext.Provider value={state}>
            <dispatchStateContext.Provider value={dispatch}>
                {children}
            </dispatchStateContext.Provider>
        </globalStateContext.Provider>
    );
};

export const useGlobalState = () => [
    React.useContext(globalStateContext),
    React.useContext(dispatchStateContext)
];

const App = () => {
    return (
        <Router>
            <Container>
                <GlobalStateProvider>
                    <Header />
                    <Routes>
                        <Route path="/" element={<Homepage />} />
                        <Route path="/cart" element={<Cart />} />
                        <Route path="/signIn" element={<SignIn />} />
                        <Route path="/signUp" element={<SignUp />} />
                        <Route path="/user" element={<PersonalDataPage />} />
                        <Route path="/myShop" element={<MyShopPage />} />
                        {/* <TestApi /> */}
                    </Routes>
                </GlobalStateProvider>
            </Container>
        </Router>
    );
};

export default App;
