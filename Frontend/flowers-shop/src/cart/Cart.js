import * as React from "react";
import Box from "@mui/material/Box";
import CardList from "./CardList";

const priceData = { products_price: 100, delivery_price: 10, total_price: 110 }

const Cart = () => {
    const [items, setItems] = useState([])

    useEffect(() => {
        fetch('http://localhost:8000/items')
            .then(res => res.json())
            .then(data => setItems(data))
    }, [])
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
                    <CardList data={items} />
                </Box>
            </Grid>
        </Box>
    );
};


export default Cart;