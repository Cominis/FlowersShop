import * as React from "react";
import Box from "@mui/material/Box";
import IconButton from "@mui/material/IconButton";
import Typography from "@mui/material/Typography";
import Menu from "@mui/material/Menu";
import MenuIcon from "@mui/icons-material/Menu";
import Button from "@mui/material/Button";
import MenuItem from "@mui/material/MenuItem";
import { useNavigate } from "react-router-dom";

const pages = { Shop: "myShop", About: "", Contacts: "" };

const Hamburger = (props) => {
    const navigate = useNavigate();

    const [anchorElNav, setAnchorElNav] = React.useState(null);

    const onCategoryClick = (path) => {
        setAnchorElNav(null);
        navigate(`/${path}`);
    };

    const handleOpenNavMenu = (event) => {
        setAnchorElNav(event.currentTarget);
    };

    const handleCloseNavMenu = () => {
        setAnchorElNav(null);
    };

    return (
        <Box display="flex" flexDirection="row">
            <Box sx={{ flexGrow: 1, display: { xs: "flex", md: "none" } }}>
                <IconButton
                    size="large"
                    aria-label="account of current user"
                    aria-controls="menu-appbar"
                    aria-haspopup="true"
                    onClick={handleOpenNavMenu}
                    color="inherit"
                >
                    <MenuIcon />
                </IconButton>
                <Menu
                    id="menu-appbar"
                    anchorEl={anchorElNav}
                    anchorOrigin={{
                        vertical: "bottom",
                        horizontal: "left"
                    }}
                    keepMounted
                    transformOrigin={{
                        vertical: "top",
                        horizontal: "left"
                    }}
                    open={Boolean(anchorElNav)}
                    onClose={handleCloseNavMenu}
                    sx={{
                        display: { xs: "block", md: "none" }
                    }}
                >
                    {Object.entries(pages).map(([page, route]) => (
                        <MenuItem
                            key={page}
                            onClick={() => onCategoryClick(route)}
                        >
                            <Typography textAlign="center">{page}</Typography>
                        </MenuItem>
                    ))}
                </Menu>
            </Box>
            <Box sx={{ flexGrow: 1, display: { xs: "none", md: "flex" } }}>
                {Object.entries(pages).map(([page, route]) => (
                    <Button
                        key={page}
                        onClick={() => onCategoryClick(route)}
                        sx={{ my: 2, color: "white", display: "block" }}
                    >
                        {page}
                    </Button>
                ))}
            </Box>
        </Box>
    );
};

export default Hamburger;
