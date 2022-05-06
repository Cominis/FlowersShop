import * as React from "react";
import { useEffect, useState } from "react";
import Box from "@mui/material/Box";
import CardList from "./CardList";
import Path from "./Path";

const priceData = { products_price: 100, delivery_price: 10, total_price: 110 }

const Cart = () => {
    const [items, setItems] = useState([])

    useEffect(() => {
        fetch('http://localhost:8000/items')
            .then(res => res.json())
            .then(data => setItems(data))
    }, [])

    const handlDelete = async (id) => {
        await fetch('http://localhost:8000/items/' + id, {
            method: 'DELETE'
        })

        const newItems = items.filter(item => item.id != id)
        setItems(newItems)
    }

    const handleCountChange = async (id, counted) => {
        const updatedItem = items.filter(item => item.id == id)[0]

        await fetch('http://localhost:8000/items/' + id, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
                "id": updatedItem.id,
                "item": updatedItem.item,
                "item_url": updatedItem.item_url,
                "shop_name": updatedItem.shop_name,
                "additional_info": updatedItem.additional_info,
                "unit_price": updatedItem.unit_price,
                "units": counted
            })
        })
    }
    return (
        <Box justifyContent="center" alignItems="center">
            <Grid
                sx={{
                    display: 'flex',
                    marginBottom: 7,
                }}
            >
                <Box component="div"
                    sx={{
                        display: "flex",
                        flexDirection: 'column',
                    }}
                >
                    <CardList data={items} handleDelete={handlDelete} handleCountChange={handleCountChange} />
                </Box>
                <Box component="div"
                    sx={{
                        display: "flex",
                        flexDirection: 'column',
                    }}
                >
                    <CardList data={items} handleDelete={handlDelete} handleCountChange={handleCountChange} />
                </Box>
            </Grid>
        </Box>
    );
};


export default Cart;