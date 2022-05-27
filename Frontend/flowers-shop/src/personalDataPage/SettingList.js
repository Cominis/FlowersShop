import * as React from "react";
import List from "@mui/material/List";
import ListItem from "@mui/material/ListItem";
import ListItemText from "@mui/material/ListItemText";
import Divider from "@mui/material/Divider";
import { Link } from "react-router-dom";

const SettingList = (props) => {
    return (
        <List component="nav" aria-label="settings">
            <ListItem button component={Link} to="/user">
                <ListItemText primary="personal data" />
            </ListItem>
            <Divider />
            <ListItem button divider>
                <ListItemText primary="orders" />
            </ListItem>
            <ListItem button>
                <ListItemText primary="saved shops" />
            </ListItem>
            <Divider />
            <ListItem button component={Link} to="/myShop">
                <ListItemText primary="my e-shop" />
            </ListItem>
            <Divider />
            <ListItem button>
                <ListItemText primary="settings" />
            </ListItem>
            <Divider />
        </List>
    );
};

export default SettingList;
