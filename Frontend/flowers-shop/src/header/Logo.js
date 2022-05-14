import * as React from "react";
import Typography from "@mui/material/Typography";
import Avatar from "@mui/material/Avatar";
import Box from "@mui/material/Box";
import logo from "../images/logo.png";

const Logo = () => {
  return (
    <Box
      component="div"
      sx={{
        display: "inline-flex",
        flexDirection: "row",
        alignItems: "center",
        mr: 2,
      }}
    >
      <Avatar alt="Bloom logo" src={logo} variant="square" />
      <Typography
        variant="body1"
        noWrap
        component="div"
        alignSelf="flex-end"
        sx={{ display: { xs: "none", md: "flex" } }}
      >
        Bloom
      </Typography>
    </Box>
  );
};

export default Logo;
