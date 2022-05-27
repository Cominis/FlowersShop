import * as React from "react";
import { Container } from "@mui/material";
import Box from "@mui/material/Box";
import Typography from '@mui/material/Typography';
import Button from "@material-ui/core/Button";
import { makeStyles } from '@material-ui/core';


const styles = makeStyles({
    btn: {
        color: 'white',
        backgroundColor: 'rgb(0,150,0)',
        '&:hover': {
            backgroundColor: 'rgb(0,110,0)'
        }
    },
    checkout: {
        display: 'flex',
        position: 'relative',
        width: 400,
        height: 180,
    }
})

const Checkout = (props) => {
    const classes = styles()

    return (
        <Container>
            <Typography borderTop={1} borderColor="rgb(0, 0, 0, 0.2)" />
            <Box className={classes.checkout}>
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
            <Typography borderTop={1} borderColor="rgb(0, 0, 0, 0.2)" />
            <Box component="div"
                sx={{
                    display: "flex",
                    flexDirection: 'column',
                    width: 170,
                    marginLeft: 'auto',
                    mt: 2
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
