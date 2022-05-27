import * as React from "react";
import List from "@mui/material/List";
import { Scrollbars } from "react-custom-scrollbars-2";
import ItemCard from "./ItemCard";

const CardList = (props) => {
    return (
        <List
            sx={{
                width: 600,
                height: 600,
                mt: 3,
                position: "relative"
            }}
        >
            <Scrollbars>
                {props.cartItems.map((item) => (
                    <ItemCard
                        key={item.id}
                        item={item}
                        useCart={props.useCart}
                        shop={item.shop}
                        handleDelete={props.handleDelete}
                        handleCountChange={props.handleCountChange}
                    />
                ))}
            </Scrollbars>
        </List>
    );
};

export default CardList;
