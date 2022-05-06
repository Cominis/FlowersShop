import * as React from 'react';import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import DeleteOutlinedIcon from '@mui/icons-material/DeleteOutlined';
import { IconButton } from '@material-ui/core';
import RemoveCircleIcon from '@mui/icons-material/RemoveCircle';
import AddCircleIcon from '@mui/icons-material/AddCircle';

const ItemCard = (props) => {
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
                image={props.item_url}
                alt={props.item}
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
                        {props.item}
                    </Typography>
                    <Typography variant="subtitle2" color="text.secondary" component="div" mt={-1}>
                        {props.shop_name}
                    </Typography>
                    <Typography variant="subtitle1" color="text.secondary" component="div">
                        {props.additional_info}
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
                        {props.unit_price.toFixed(2)} EUR
                    </Typography>
                    <Typography marginRight={2.5} width={29} align='center' color="text.secondary" component="div">
                        {props.units}
                    </Typography>
                    <Box sx={{
                        position: 'absolute',
                        mt: -4.2,
                        ml: 2.3,
                    }}>
                        <IconButton>
                            <RemoveCircleIcon fontSize='small' />
                        </IconButton>
                    </Box>
                    <Box sx={{
                        position: 'absolute',
                        mt: -4.2,
                        ml: 8.5,
                    }}>
                        <IconButton>
                            <AddCircleIcon fontSize='small' />
                        </IconButton>
                    </Box>
                    <Box sx={{
                        position: 'absolute',
                        mt: 2,
                        ml: 8.5,
                    }}>
                        <IconButton>
                            <DeleteOutlinedIcon />
                        </IconButton>
                    </Box>
                </CardContent>
            </Box>
        </Card>
    );
}

export default ItemCard;