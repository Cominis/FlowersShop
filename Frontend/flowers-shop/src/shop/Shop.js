import { Grid } from "@mui/material";
import { Box } from "@mui/system";
import { useEffect, useState } from "react";
import Breadcrumb from "../personalDataPage/Breadcrumb";
import FlowersContainer from "./flowers/FlowersContainer";
import ShopsContainer from "./shops/ShopsContainer";
import axios from "../net/axios";
import { useParams } from "react-router-dom";
import * as React from "react";

const Shop = (props) => {
    const routes = ["Flower E-shop", "SHOPS"];
    const [shops, setShops] = useState([]);
    const { query, priceStart, priceEnd, statusSearch } = useParams();
    const [opened, setOpened] = React.useState();
    useEffect(() => {
        const fetch = async () => {
            try {
                console.log(query);
                const response = await axios.get(
                    `Search/${query}/${priceStart}/${priceEnd}/${statusSearch}`
                );
                const shops = response.data.response;
                const status = statusSearch === "Available" ? [0] : statusSearch === "OutOfStock" ? [1] : [1,0];
                shops.forEach((shop) => shop.products = shop.products.filter(product => status.includes(product.status) && (product.price >= Number(priceStart) || Number(priceStart) === 0)  &&(Number(priceEnd) === 0 || product.price <= Number(priceEnd)) ));
                setShops(shops);
            } catch (err) {
                alert(
                    err.response?.data?.Error?.Message ||
                        "Unexpected error occured, try again"
                );
            }
        };

        fetch();
    }, [query, priceStart, priceEnd, statusSearch]);

    return (
        <Box>
            <Breadcrumb routes={routes} />
            <Grid container columnSpacing={20} margin={"0,0,0,0"}>
                <Grid item>
                    <ShopsContainer
                        shops={shops}
                        useOpened={[opened, setOpened]}
                    />
                </Grid>
                <Grid item>
                    {opened && (
                        <FlowersContainer
                            shop={shops.find(({ id }) => id === opened)}
                        />
                    )}
                </Grid>
            </Grid>
        </Box>
    );
};

export default Shop;
