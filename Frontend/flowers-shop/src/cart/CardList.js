import * as React from 'react';
import List from '@mui/material/List';
import { Scrollbars } from 'react-custom-scrollbars-2';
import ItemCard from "./ItemCard";


const CardList = (props) => (
    <List
        sx={{
            width: 600,
            height: 600,
            mt: 3,
            position: 'relative',
        }}
    >
        <Scrollbars>
            {props.data.map(item => <ItemCard item={item} handleDelete={props.handleDelete} handleCountChange={props.handleCountChange} />)}
        </Scrollbars>
    </List>
);

export default CardList;
