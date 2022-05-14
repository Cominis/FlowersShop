import * as React from "react";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import LoginIcon from "@mui/icons-material/Login";

const LoginButton = () => {
  return (
    <Box sx={{ display: "flex", noWrap: true, flexDirection: "row" }}>
      <LoginIcon />
      <Typography
        variant="body1"
        sx={{ display: { xs: "none", md: "flex" }, ml: 1 }}
      >
        Login
      </Typography>
    </Box>
  );
};

export default LoginButton;
