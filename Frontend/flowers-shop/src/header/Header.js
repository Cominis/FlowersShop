import * as React from "react";
import AppBar from "@mui/material/AppBar";
import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import Container from "@mui/material/Container";
import Logo from "./Logo";
import SearchBar from "./SearchBar";
import LoginUser from "./LoginUser";
import Hamburger from "./Hamburger";

const Header = () => {
    return (
        <AppBar position="absolute" sx={{ bgcolor: "green" }}>
            <Container maxWidth={false}>
                <Toolbar disableGutters>
                    <Logo />
                    <Box sx={{ flexGrow: 1 }} />
                    <SearchBar />
                    <Box sx={{ flexGrow: 1 }} />
                    <Hamburger />
                    <LoginUser />
                </Toolbar>
            </Container>
        </AppBar>
    );
};

export default Header;
