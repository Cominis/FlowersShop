import React, { useState } from "react";
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import DeleteOutlinedIcon from '@mui/icons-material/DeleteOutlined';
import { IconButton } from '@material-ui/core';
import RemoveCircleIcon from '@mui/icons-material/RemoveCircle';
import AddCircleIcon from '@mui/icons-material/AddCircle';
import { CardActionArea } from '@mui/material';
import { useEffect } from "react";

const ItemCard = (props) => {
    const [units, setUnits] = useState(props.cart.quantity);

    const incrementCounter = (unit) => {
        setUnits(unit + 1); props.handleCountChange(props.cart.id, unit + 1); props.cart.quantity = unit + 1;
    }
    const decrementCounter = (unit) => {
        if (unit !== 0) {
            setUnits(unit - 1); props.handleCountChange(props.cart.id, unit - 1); props.cart.quantity = unit - 1;
        }
    }

    return (
        <Card
            sx={{
                display: 'flex',
                height: 132,
                margin: 1,
                overflow: 'hidden',
            }}
        >
            <CardMedia
                component="img"
                sx={{ width: 100, height: 100, m: 2 }}
                image={props.item.item_url}
                alt={props.item.title}
            />
            <Box
                sx={{
                    display: 'flex',
                    flexDirection: 'column'
                }}
            >
                <CardContent
                    sx={{
                        flex: '1 0 auto'
                    }}
                >
                    <Typography component="div" fontWeight="bold">
                        {props.item.title}
                    </Typography>
                    <Typography variant="subtitle2" color="text.secondary" component="div" mt={-1}>
                        {props.shop.name}
                    </Typography>
                    <Typography variant="subtitle1" color="text.secondary" component="div">
                        {props.item.description}
                    </Typography>
                </CardContent>
            </Box>
            <Box
                sx={{
                    display: 'flex',
                    flexDirection: 'column',
                    marginLeft: 'auto'
                }}
            >
                <CardContent sx={{ flex: '1 0 auto' }} align="right">
                    <Typography width={100} component="div" fontWeight="bold">
                        {props.item.price.toFixed(2)} EUR
                    </Typography>
                    <Typography marginRight={2.5} width={29} align='center' color="text.secondary" component="div">
                        {props.cart.quantity}
                    </Typography>
                    <Box sx={{
                        position: 'absolute',
                        mt: -4.2,
                        ml: 2.3,
                    }}>
                        <IconButton onClick={() => decrementCounter(props.cart.quantity)}>
                            <RemoveCircleIcon fontSize='small' />
                        </IconButton>
                    </Box>
                    <Box sx={{
                        position: 'absolute',
                        mt: -4.2,
                        ml: 8.5,
                    }}>
                        <IconButton onClick={() => incrementCounter(props.cart.quantity)}>
                            <AddCircleIcon fontSize='small' />
                        </IconButton>
                    </Box>
                    <Box sx={{
                        position: 'absolute',
                        mt: 2,
                        ml: 8.5,
                    }}>
                        <IconButton onClick={() => props.handleDelete(props.cart.id)}>
                            <DeleteOutlinedIcon />
                        </IconButton>
                    </Box>
                </CardContent>
            </Box>
        </Card>
    );
}

export default ItemCard;