import React, { useState } from "react";
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { IconButton } from '@material-ui/core';
import Button from "@material-ui/core/Button";
import { makeStyles } from '@material-ui/core';
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown';
import ArrowDropUpIcon from '@mui/icons-material/ArrowDropUp';

const buttonStyle = makeStyles({
    btn: {
        color: 'white',
        fontSize: 10,
        height: 18,
        backgroundColor: 'rgb(0,150,0)',
        '&:hover': {
            backgroundColor: 'rgb(0,110,0)'
        }
    }
})

const Item = (props) => {
    const [units, setUnits] = useState(0);

    const incrementCounter = () => {
        if (units <= props.item.quantity) {
            setUnits(units + 1);
        }
    }
    const decrementCounter = () => {
        if (units !== 0)
        {
            setUnits(units - 1);
        }
    }

    const handleAdd = (id, units) => {
        if (units !== 0) {
            props.handleAdd(id, units);
            setUnits(0);
        }
    }

    const classes = buttonStyle()
    return (
        <Card
            sx={{
                height: 240,
                width: 175,
            }}
        >
            <CardMedia
                component="img"
                sx={{
                    width: 130,
                    height: 130,
                    margin: 'auto',
                    marginTop: 1,
                    display: 'flex',
                }}
                image={props.item.item_url}
                alt={props.item.title}
            />
            <CardContent>
                <Typography borderTop={1} borderColor="rgb(0, 0, 0, 0.2)"/>
                <Typography component="div" fontSize={10} fontWeight="bold" textAlign="right">
                    {props.item.price.toFixed(2)} EUR
                </Typography>
                <Typography gutterBottom fontSize={12} component="div">
                    {props.item.title}
                </Typography>
                <Typography fontSize={12} color="text.secondary" component="div" mt={-1}>
                    {props.shop.name}
                </Typography>
                <Box sx={{
                    display: 'flex',
                    mt: 1,
                }}>
                    <Typography width={45} align='center' color="text.secondary" component="div">
                        {units}
                    </Typography>
                </Box>
                <Box sx={{
                    position: 'absolute',
                    mt: -4.3,
                    ml: -2.2,
                }}>
                    <IconButton onClick={() => decrementCounter()} marginTop={10}>
                        <ArrowDropDownIcon fontSize='small' />
                    </IconButton>
                </Box>
                <Box sx={{
                    position: 'absolute',
                    mt: -4.3,
                    ml: 2.5,
                }}>
                    <IconButton onClick={() => incrementCounter()}>
                        <ArrowDropUpIcon fontSize='small' />
                    </IconButton>
                </Box>
                <Box sx={{
                    position: 'absolute',
                    mt: -3,
                    ml: 10,
                }}>
                    <Button className={classes.btn} type="submit" variant="contained" onClick={() => handleAdd(props.item, units)}>
                        Add
                    </Button>
                </Box>
            </CardContent>
        </Card>
    );
}

export default Item;