import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";
import * as React from "react";
import { Button } from "@mui/material";
import axios from "../net/axios";
import { useGlobalState } from "../App";

const ShopField = (props) => {
    const [globalState] = useGlobalState();
    const shopKeys = ["shop name", "shop description", "shop location"];
    const [shop, setShop] = props.useShop;
    const values = [
        shop?.name || "",
        shop?.description || "",
        shop?.location || ""
    ];

    const handleClick = async () => {

        try{
            if(shop){
            const response = await axios.delete(`Shops/${shop.id}`,{
                headers: globalState.headers
            });
            setShop(null);
            alert(response.data.response);
            }
        }
        catch(err){
            alert(
                err.response?.data?.Error?.Message ||
                    "Unexpected error occured, try again"
            );
        }
    };

    const handleSubmit = async (event) => {
        event.preventDefault();
        const payload = {
            Name: event.target[0].value,
            Description: event.target[1].value,
            Location: event.target[2].value
        };
        try {
            if (shop) {
                const response = await axios.put(`Shops/${shop.id}`, payload, {
                    headers: globalState.headers
                });
                setShop(response.data.response);
                alert("Shop was updated successfully");
            } else {
                const response = await axios.post("Shops", payload, {
                    headers: globalState.headers
                });
                setShop(response.data.response);
                alert("Shop was created successfully");
            }
        } catch (err) {
            alert(
                err.response?.data?.Error?.Message ||
                    "Unexpected error occured, try again"
            );
        }
    };

    const settings = shopKeys.map((key, idx) => {
        return (
            <Box component="div" className="ShopField" key={key}>
                <Typography
                    sx={{ width: "150px" }}
                    display="inline-block"
                >{`${key}:`}</Typography>
                <input
                    type="text"
                    defaultValue={values[idx]}
                    inputprops={{
                        style: {
                            paddingBottom: "3px"
                        }
                    }}
                />
            </Box>
        );
    });
    return (
        <Box component="form" className="ShopField" onSubmit={handleSubmit}>
            {settings}
            <Button variant="outlined" type="submit">
                Create/Update
            </Button>
            <Button variant="outlined" onClick = {handleClick}>
                Delete
            </Button>
        </Box>
    );
};

export default ShopField;
