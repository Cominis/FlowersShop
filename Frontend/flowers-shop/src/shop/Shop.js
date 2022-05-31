import { Grid, Typography } from "@mui/material";
import { Box } from "@mui/system";
import Breadcrumb from "../personalDataPage/Breadcrumb";
import FlowersContainer from "./flowers/FlowersContainer";
import ShopsContainer from "./shops/ShopsContainer";
import ShopItems from "../shop-items/ShopItems";

const Shop = (props) => {
    const routes = ["Flower E-shop", "SHOP"];

    return (
        <Box>
            <Breadcrumb routes={routes} />
            <Typography>Test</Typography>
            <Grid container columnSpacing={20}>
                <Grid item>
                    <ShopsContainer />
                </Grid>
                <Grid item>
                    <FlowersContainer />
                </Grid>
            </Grid>
        </Box>
    );
};

export default Shop;
