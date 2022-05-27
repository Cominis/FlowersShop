import * as React from 'react';
import List from '@mui/material/List';
import Item from "./Item";
import Box from '@mui/material/Box';
import { Button, Grid } from "@mui/material";
import MobileStepper from '@mui/material/MobileStepper';
import Paper from '@mui/material/Paper';
import Typography from '@mui/material/Typography';
import KeyboardArrowLeft from '@mui/icons-material/KeyboardArrowLeft';
import KeyboardArrowRight from '@mui/icons-material/KeyboardArrowRight';
import SwipeableViews from 'react-swipeable-views';
import { autoPlay } from 'react-swipeable-views-utils';
import { useTheme } from '@mui/material/styles';
import useMediaQuery from '@mui/material/useMediaQuery';

const AutoPlaySwipeableViews = autoPlay(SwipeableViews);

const ItemList = (props) => {
    const theme = useTheme();
    const [activeStep, setActiveStep] = React.useState(0);
    const itemsPerPage = 12;
    const maxSteps = Math.ceil(props.data.length / itemsPerPage);

    const handleNext = () => {
        setActiveStep((prevActiveStep) => prevActiveStep + 1);
    };

    const handleBack = () => {
        setActiveStep((prevActiveStep) => prevActiveStep - 1);
    };

    const handleStepChange = (step) => {
        setActiveStep(step);
    };

    const chunk = (arr, size) => arr.reduce((acc, e, i) => (i % size ? acc[acc.length - 1].push(e) : acc.push([e]), acc), []);

    const dataSliced = chunk(props.data, itemsPerPage);

    const matches = useMediaQuery('(min-width:600px)');

    return (
        <Box sx={{ maxWidth: 1200, flexGrow: 1 }}>
            <Box>
                <Paper
                    square
                    elevation={0}
                    sx={{
                        display: 'flex',
                        alignItems: 'center',
                        height: 50,
                        pl: 2,
                        bgcolor: 'background.default',
                    }}
                >
                    <Grid container rowSpacing={1} columnSpacing={2}>
                        {dataSliced[activeStep].map(item => <Grid margin={1}><Item item={item} shop={props.shops.find(x => x.id === item.shopId)} handleAdd={props.handleAdd} /></Grid>)}
                    </Grid>
                </Paper>
            </Box>

            <Box sx={{ width: '100%', position: 'flex', mt: 30 }}>
                    <MobileStepper
                        steps={maxSteps}
                        position="static"
                        activeStep={activeStep}
                        nextButton={
                            <Button
                                size="small"
                                onClick={handleNext}
                                disabled={activeStep === maxSteps - 1}
                            >
                                Next
                                {theme.direction === 'rtl' ? (
                                    <KeyboardArrowLeft />
                                ) : (
                                    <KeyboardArrowRight />
                                )}
                            </Button>
                        }
                        backButton={
                            <Button size="small" onClick={handleBack} disabled={activeStep === 0}>
                                {theme.direction === 'rtl' ? (
                                    <KeyboardArrowRight />
                                ) : (
                                    <KeyboardArrowLeft />
                                )}
                                Back
                            </Button>
                        }
                    />
            </Box>
        </Box>
    );
};

export default ItemList;