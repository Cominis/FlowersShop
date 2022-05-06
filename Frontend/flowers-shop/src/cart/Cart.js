import * as React from "react";
import Box from "@mui/material/Box";
import CardList from "./CardList";

const testData = [
    { id: "124234", item: "Tulip", item_url: "https://dy1yydbfzm05w.cloudfront.net/media/catalog/product/cache/39b52c4cabb46819553175347e38b212/t/u/tulips-dutch-webready-assets-persimmon-product-1000px-01_1.jpg", shop_name: "some shop 1", additional_info: "some additional info...", unit_price: (1.5).toFixed(2), units: "x5" },
    { id: "123514", item: "Rose", item_url: "https://www.collinsdictionary.com/images/full/rose_277351964.jpg", shop_name: "some shop 2", additional_info: "some additional info...", unit_price: (2.5).toFixed(2), units: "x3" },
    { id: "135143", item: "Sunflower", item_url: "https://www.shelf-edge.co.uk/wp-content/uploads/2019/02/Artificial-75cm-Giant-Single-Sunflower.jpg", shop_name: "some shop 3", additional_info: "some additional info...", unit_price: (3.1).toFixed(2), units: "x1" },
    { id: "112414", item: "Marigold", item_url: "https://d2gg9evh47fn9z.cloudfront.net/800px_COLOURBOX3269990.jpg", shop_name: "some shop 4", additional_info: "some additional info...", unit_price: (1).toFixed(2), units: "x10" },
    { id: "532314", item: "Orchids", item_url: "https://images.thdstatic.com/productImages/478c3fad-00ce-4e51-8f7d-2405e7f0a8c7/svn/just-add-ice-indoor-plants-215585-64_400.jpg", shop_name: "some shop 4", additional_info: "some additional info...", unit_price: (1).toFixed(2), units: "x10" },
    { id: "125214", item: "Peonies bouquet", item_url: "https://www.wineflowers.com/images/bouquet_peonie_rose.jpg", shop_name: "some shop 4", additional_info: "some additional info...", unit_price: (1).toFixed(2), units: "x10" },
    { id: "127534", item: "Dahlias", item_url: "https://image.posterlounge.com/images/l/1898260.jpg", shop_name: "some shop 4", additional_info: "some additional info...", unit_price: (1).toFixed(2), units: "x10" },
    { id: "198654", item: "Dandelion", item_url: "https://static.turbosquid.com/Preview/001230/852/6C/3D-realistic-dandelion-flower_600.jpg", shop_name: "some shop 4", additional_info: "some additional info...", unit_price: (1).toFixed(2), units: "x10" },
];

const priceData = { products_price: 100, delivery_price: 10, total_price: 110 }

const Cart = () => {
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
                    <CardList data={testData} />
                </Box>
            </Grid>
        </Box>
    );
};


export default Cart;