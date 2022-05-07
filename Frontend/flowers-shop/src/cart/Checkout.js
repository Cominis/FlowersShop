import * as React from "react";
import { Container } from "@mui/material";
import Box from "@mui/material/Box";
import Typography from '@mui/material/Typography';
import Button from "@material-ui/core/Button";
import { makeStyles } from '@material-ui/core';


const buttonStyle = makeStyles({
    btn: {
        color: 'white',
        backgroundColor: 'rgb(0,150,0)',
        '&:hover': {
            backgroundColor: 'rgb(0,110,0)'
        }
    }
})

const Checkout = (props) => {
    const classes = buttonStyle()

    return (
        <Container>
            <Box
                sx={{
                    mb: 3,
                    mt: 4,
                    display: 'flex',
                    position: 'relative',
                    width: 400,
                    height: 180,
                    boxShadow: '0px 0px 5px 1px rgba(0, 0, 0, 0.5)',
                    borderRadius: '5px',
                }}
            >
                <Box
                    sx={{
                        display: 'flex',
                        flexDirection: 'column',
                        mt: 4,
                        ml: 4,
                    }}
                >
                    <Typography component="div">
                        Products price
                    </Typography>
                    <Typography component="div">
                        Delivery
                    </Typography>
                    <Typography component="div" mt={5} variant="h6">
                        Total
                    </Typography>
                </Box>
                <Box
                    sx={{
                        display: 'flex',
                        flexDirection: 'column',
                        marginLeft: 'auto',
                        mt: 4,
                        mr: 4,
                    }}
                >
                    <Typography component="div" color="text.secondary" align="right">
                        {props.products_price.toFixed(2)} EUR
                    </Typography>
                    <Typography component="div" color="text.secondary" align="right">
                        {props.delivery_price.toFixed(2)} EUR
                    </Typography>
                    <Typography component="div" color="text.secondary" align="right" mt={5} variant="h6">
                        {props.total_price.toFixed(2)} EUR
                    </Typography>
                </Box>
            </Box>
            <Box component="div"
                sx={{
                    display: "flex",
                    flexDirection: 'column',
                    width: 170,
                    marginLeft: 'auto',
                }}
            >
                <Button className={classes.btn} type="submit" variant="contained">
                    Purchase
                </Button>
            </Box>
        </Container>
    );
}

export default Checkout;
