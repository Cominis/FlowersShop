import * as React from "react";
import Typography from "@mui/material/Typography";
import { Box } from "@mui/material";

const IntroTextItem = (props) => {
  return (
    <Box>
      <Typography
        textAlign="center"
        sx={{ typography: { xl: "h2", md: "h3", sm: "h4", xs: "h5" } }}
      >
        The E-Shop of Flowers
      </Typography>
      <Typography
        sx={{
          typography: { xl: "h5", md: "h6", sm: "body1", xs: "body2" },
        }}
      >
        {"Be our customer by being our merchant".toUpperCase()}
      </Typography>
    </Box>
  );
};

export default IntroTextItem;
