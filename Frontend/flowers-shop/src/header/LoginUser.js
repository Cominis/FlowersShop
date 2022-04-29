import * as React from "react";
import Box from "@mui/material/Box";
import IconButton from "@mui/material/IconButton";
import Typography from "@mui/material/Typography";
import Menu from "@mui/material/Menu";
import Avatar from "@mui/material/Avatar";
import Tooltip from "@mui/material/Tooltip";
import MenuItem from "@mui/material/MenuItem";
import LoginButton from "./LoginButton";
import { useNavigate } from "react-router-dom";
import { useGlobalState } from "../App";

const settings = {
    Profile: "user",
    Account: "",
    Dashboard: "",
    Logout: "logout"
};

const LoginUser = () => {
    const navigate = useNavigate();

    const onNavClick = (path) => {
        handleCloseUserMenu();
        if (path === "logout") {
            setGlobalState({ isLoggedIn: false });
            localStorage.removeItem("token");
            navigate(`/`);
        } else {
            navigate(`/${path}`);
        }
    };

    const [anchorElUser, setAnchorElUser] = React.useState(null);
    // const [isLoggedIn, setIsLoggedIn] = React.useState(true);
    const [globalState, setGlobalState] = useGlobalState();

    const handleOpenUserMenu = (event) => {
        setAnchorElUser(event.currentTarget);
    };

    const handleCloseUserMenu = () => {
        setAnchorElUser(null);
    };

    return globalState.isLoggedIn ? (
        <Box sx={{ flexGrow: 0 }}>
            <Tooltip title="Open settings">
                <IconButton onClick={handleOpenUserMenu} sx={{ p: 0 }}>
                    <Avatar alt="Remy Sharp" src="" />
                </IconButton>
            </Tooltip>
            <Menu
                sx={{ mt: "45px" }}
                id="menu-appbar"
                anchorEl={anchorElUser}
                anchorOrigin={{
                    vertical: "top",
                    horizontal: "right"
                }}
                keepMounted
                transformOrigin={{
                    vertical: "top",
                    horizontal: "right"
                }}
                open={Boolean(anchorElUser)}
                onClose={handleCloseUserMenu}
            >
                {Object.entries(settings).map(([setting, route]) => (
                    <MenuItem key={setting} onClick={() => onNavClick(route)}>
                        <Typography textAlign="center">{setting}</Typography>
                    </MenuItem>
                ))}
            </Menu>
        </Box>
    ) : (
        <LoginButton />
    );
};

export default LoginUser;
