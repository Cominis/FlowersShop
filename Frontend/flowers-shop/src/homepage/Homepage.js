import * as React from "react";
import Box from "@mui/material/Box";
import { Button, Grid } from "@mui/material";
import MainLogo from "./MainLogo";
import IntroTextItem from "./Intro";
const Homepage = (props) => {
  return (
    <Box
      sx={{
        width: "100%",
        height: "100vh",
        display: "flex",
        flex: 1,
        flexDirection: "column",
        justifyContent: "center",
        alignItems: "center",
        py: 2,
      }}
    >
      <Grid
        container
        direction="column"
        justifyContent="center"
        alignItems="center"
        spacing={1}
      >
        <Grid item>
          <MainLogo />
        </Grid>
        <Grid item>
          <IntroTextItem />
        </Grid>
        <Grid item>
          <Box component="div" sx={{ display: "inline" }}>
            <Button
              variant="contained"
              sx={{ mr: { xl: 25, lg: 20, md: 15, sm: 10, xs: 5 } }}
            >
              Buy
            </Button>
            <Button variant="outlined">Sell</Button>
          </Box>
        </Grid>
      </Grid>
    </Box>
  );
};

export default Homepage;
