import * as React from "react";
import { useEffect, useState } from "react";
import { Grid } from "@mui/material";
import Box from "@mui/material/Box";
import CardList from "./CardList";
import Path from "./Path";
import Checkout from "./Checkout";
import axios from "../net/axios";

const priceData = { products_price: 100, delivery_price: 10, total_price: 110 };
const deliveryPrice = 5;

const Cart = () => {
    const [cart, setCart] = useState(
        JSON.parse(localStorage.getItem("cart")) || []
    );
    const [items, setItems] = useState([]);
    const [price, setPrice] = useState(0);

    useEffect(() => {
        const fetch = async () => {
            try {
                const ids = [...new Set(cart)];
                const responses = await Promise.all(
                    ids.map((productId) => axios.get(`products/${productId}`))
                );

                console.log(responses);

                const products = responses.map(
                    (response) => response.data.response
                );

                const prices = cart.map(
                    (productId) =>
                        products.find(({ id }) => id === productId).price
                );
                setPrice(
                    prices.reduce(function (acc, val) {
                        return acc + val;
                    }, 0)
                );
                setItems(products);
            } catch (err) {
                console.log(err);
                alert(
                    err.response?.data?.Error?.Message ||
                        "Unexpected error occured, try again"
                );
            }
        };
        fetch();
    }, [cart]);

    return (
        <Box justifyContent="center" alignItems="center">
            <Grid>
                <Path path={"Shopping Cart"} />
            </Grid>
            <Grid
                sx={{
                    display: "flex",
                    marginBottom: 7
                }}
            >
                <Box
                    component="div"
                    sx={{
                        display: "flex",
                        flexDirection: "column"
                    }}
                >
                    <CardList
                        cartItems={items}
                        useCart={[cart, setCart]}
                        shops={[]}
                        data={cart}
                        handleDelete={undefined}
                        handleCountChange={undefined}
                    />
                </Box>
                <Box
                    component="div"
                    sx={{
                        display: "flex",
                        flexDirection: "column",
                        marginLeft: "auto",
                        marginTop: 4
                    }}
                >
                    <Checkout
                        useCart={[cart, setCart]}
                        products_price={price}
                        delivery_price={deliveryPrice}
                        total_price={price + deliveryPrice}
                    />
                </Box>
            </Grid>
        </Box>
    );
};

export default Cart;
