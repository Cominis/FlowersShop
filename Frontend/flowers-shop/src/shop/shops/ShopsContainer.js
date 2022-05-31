import { Button, Typography } from "@mui/material";
import { Box } from "@mui/system";
import * as React from "react";
import List from "@mui/material/List";
import ListItem from "@mui/material/ListItem";
import ListItemText from "@mui/material/ListItemText";
import ListSubheader from "@mui/material/ListSubheader";
import ShopsItem from "./ShopItem";
const ShopsContainer = (props) => {
    const shops = [
        { id: "0", name: "nulis", location: "Vilnius" },
        { id: "1", name: "vienas", location: "Vilnius" },
        { id: "2", name: "du", location: "Vilnius" },
        { id: "3", name: "trys", location: "Vilnius" },
        { id: "4", name: "keturi", location: "Vilnius" },
        { id: "5", name: "penki", location: "Vilnius" },
        { id: "6", name: "sesi", location: "Vilnius" }
    ];
    return (
        <Box sx={{ display: "flex", width: "50%" }}>
            <List
                sx={{
                    width: "100%",
                    minWidth: "500px",
                    bgcolor: "background.paper",
                    position: "relative",
                    overflow: "auto",
                    maxHeight: 300,
                    "& ul": { padding: 0 }
                }}
                subheader={<li />}
            >
                <ListSubheader>Shops</ListSubheader>
                {shops.map((shop) => (
                    <ShopsItem shop={shop} />
                ))}
            </List>
        </Box>
    );
};

export default ShopsContainer;
