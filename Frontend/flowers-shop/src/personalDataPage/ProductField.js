import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";
import * as React from "react";
import { Button } from "@mui/material";
import axios from "../net/axios";
import { useGlobalState } from "../App";
import MenuItem from '@mui/material/MenuItem';
import Select from '@mui/material/Select';

const ProductField = (props) => {
    const [globalState] = useGlobalState();
    const [shop, setShop] = props.useShop;

    const [status, setStatus] = React.useState('');
    const [title, setTitle] = React.useState('');
    const [description, setDescription] = React.useState('');
    const [category, setCategory] = React.useState('');
    const [price, setPrice] = React.useState('');
    const [quantity, setQuantity] = React.useState('');

    const handleSubmit = async (event) => {
        event.preventDefault();
        const payload = {
            ShopId : shop.id,
            Title: title,
            Description: description,
            Category: category,
            SubCategory : "", 
            Status : status,
            Price :price,
            Quantity: quantity
        };
        try {
                const response = await axios.post("Products", payload, {
                    headers: globalState.headers
                });
                console.log(response);
                const newShop = response.data.response.shop;
                newShop.products.push(response.data.response);
                setShop(newShop);
                alert("Product was created successfully");
        } catch (err) {
            alert(
                err.response?.data?.Error?.Message ||
                    "Unexpected error occured, try again"
            );
        }
        finally{
            setStatus("");
            setTitle("");
            setDescription("");
            setCategory("");
            setPrice("");
            setQuantity("");
        }
    };

    const settings = 
     (      <Box component="div" className="ShopField">

            <Box component="div" className="ShopField">
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{"product title"}
                </Typography>               
                <input
                    type="text"
                    value = {title}
                    onChange = {(e) => setTitle(e.target.value)}
                    inputprops={{
                        style: {
                            paddingBottom: "3px"
                        }
                    }}
                />
            </Box>
            <Box component="div" className="ShopField">
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{"product description"}
                </Typography>               
                <input
                    type="text"
                    value = {description}
                    onChange = {(e) => setDescription(e.target.value)}
                    inputprops={{
                        style: {
                            paddingBottom: "3px"
                        }
                    }}
                />
            </Box>
            <Box component="div" className="ShopField">
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{`product category`}
                </Typography>               
                <input
                    type="text"
                    value = {category}
                    onChange = {(e) => setCategory(e.target.value)}
                    inputprops={{
                        style: {
                            paddingBottom: "3px"
                        }
                    }}
                />
            </Box>
            <Box component="div" className="ShopField">
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{"product status"}
                </Typography>               
                <Select
                    value={status}
                    onChange={(e) => setStatus(e.target.value)}
                    sx={{width: "177px",
                        height: "30px"}}          
                >
                     <MenuItem value={"Available"}>Available</MenuItem>
                     <MenuItem value={"OutOfStock"}>Out Of Stock</MenuItem>
                </Select>
            </Box>
            <Box component="div" className="ShopField">
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{"product price"}
                </Typography>               
                <input
                    type="number"
                    value = {price}
                    onChange = {(e) => setPrice(e.target.value)}
                    inputprops={{
                        style: {
                            paddingBottom: "3px"
                        }
                    }}
                />
            </Box>
            <Box component="div" className="ShopField">
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{'product quantity'}
                </Typography>               
                <input
                    type="number"
                    value = {quantity}
                    onChange = {(e) => setQuantity(e.target.value)}
                    inputprops={{
                        style: {
                            paddingBottom: "3px"
                        }
                    }}
                />
            </Box>
        </Box>
        );
    return (
        <Box component="form" className="ProductField" onSubmit={handleSubmit}>
            {settings}
            <Button variant="outlined" type="submit">
                Create
            </Button>
        </Box>
    );
};

export default ProductField;