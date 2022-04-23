import * as React from "react";
import Box from "@mui/material/Box";
import Typography from "@mui/material/Typography";
import logo from "../images/logo.png";
import Avatar from "@mui/material/Avatar";

const MainLogo = (props) => {
  return (
    <Box
      component="div"
      sx={{
        display: "inline-flex",
        flexDirection: "row",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <Avatar
        alt="Bloom logo"
        src={logo}
        variant="square"
        sx={{
          width: { xl: "auto", md: "50%", xm: "40%", xs: "35%" },
          height: "auto",
        }}
      />
      <Typography
        textAlign="center"
        sx={{ typography: { xl: "h1", md: "h2", sm: "h3", xs: "h4" } }}
      >
        Bloom
      </Typography>
    </Box>
  );
};

export default MainLogo;
