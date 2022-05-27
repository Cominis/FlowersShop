import React, {useState} from 'react';
import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import DeleteOutlinedIcon from '@mui/icons-material/DeleteOutlined';
import {IconButton} from '@material-ui/core';
import RemoveCircleIcon from '@mui/icons-material/RemoveCircle';
import AddCircleIcon from '@mui/icons-material/AddCircle';

function importAll (r) {
  let images = {};
  r.keys ().map ((item, index) => {
    images[item.replace ('./', '')] = r (item);
  });
  return images;
}
const imgs = importAll (
  require.context ('../images', false, /\.(png|jpe?g|svg)$/)
);
const imgsNames = ['btulpe.jpg', 'mtulpe.jpg', 'otulpe.jpg', 'rtulpe.jpg'];

const ItemCard = props => {
  const [cart, setCart] = props.useCart;

  const incrementCounter = () => {
    const cartCopy = [...cart];
    cartCopy.push (props.item.id);
    localStorage.setItem ('cart', JSON.stringify (cartCopy));
    setCart (cartCopy);
  };
  const decrementCounter = () => {
    const idx = cart.findIndex (id => id === props.item.id);
    const cartCopy = [...cart];
    cartCopy.splice (idx, 1);
    localStorage.setItem ('cart', JSON.stringify (cartCopy));
    setCart (cartCopy);
  };

  const handleDelete = () => {
    const cartCopy = cart.filter (id => id !== props.item.id);
    localStorage.setItem ('cart', JSON.stringify (cartCopy));
    setCart (cartCopy);
  };

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
        sx={{width: 100, height: 100, m: 2}}
        src={imgs[imgsNames[Math.floor (Math.random () * imgsNames.length)]]}
        alt={props.item.title}
      />
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
        }}
      >
        <CardContent
          sx={{
            flex: '1 0 auto',
          }}
        >
          <Typography component="div" fontWeight="bold">
            {props.item.title}
          </Typography>
          <Typography
            variant="subtitle2"
            color="text.secondary"
            component="div"
            mt={-1}
          >
            {props.shop.name}
          </Typography>
          <Typography
            variant="subtitle1"
            color="text.secondary"
            component="div"
          >
            {props.item.description}
          </Typography>
        </CardContent>
      </Box>
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
          marginLeft: 'auto',
        }}
      >
        <CardContent sx={{flex: '1 0 auto'}} align="right">
          <Typography width={100} component="div" fontWeight="bold">
            {props.item.price.toFixed (2)} EUR
          </Typography>
          <Typography
            marginRight={2.5}
            width={29}
            align="center"
            color="text.secondary"
            component="div"
          >
            {cart.filter (id => props.item.id === id).length}
          </Typography>
          <Box
            sx={{
              position: 'absolute',
              mt: -4.2,
              ml: 2.3,
            }}
          >
            <IconButton onClick={() => decrementCounter ()}>
              <RemoveCircleIcon fontSize="small" />
            </IconButton>
          </Box>
          <Box
            sx={{
              position: 'absolute',
              mt: -4.2,
              ml: 8.5,
            }}
          >
            <IconButton onClick={() => incrementCounter ()}>
              <AddCircleIcon fontSize="small" />
            </IconButton>
          </Box>
          <Box
            sx={{
              position: 'absolute',
              mt: 2,
              ml: 8.5,
            }}
          >
            <IconButton onClick={() => handleDelete ()}>
              <DeleteOutlinedIcon />
            </IconButton>
          </Box>
        </CardContent>
      </Box>
    </Card>
  );
};

export default ItemCard;
