import * as React from "react";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import LoginIcon from "@mui/icons-material/Login";
import { useGlobalState } from "../App";
import { Button, MenuItem } from "@mui/material";
import { useNavigate } from "react-router-dom";
const LoginButton = () => {
    const [globalState, setGlobalState] = useGlobalState();
    const navigate = useNavigate();
    return (
        <MenuItem
            onClick={() => {
                navigate(`/signin`);
            }}
        >
            <Box sx={{ display: "flex", noWrap: true, flexDirection: "row" }}>
                <LoginIcon />
                <Typography
                    variant="body1"
                    sx={{ display: { xs: "none", md: "flex" }, ml: 1 }}
                >
                    Login
                </Typography>
            </Box>
        </MenuItem>
    );
};

export default LoginButton;
