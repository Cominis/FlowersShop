import * as React from 'react';
import {useEffect, useState} from 'react';
import {Grid} from '@mui/material';
import Box from '@mui/material/Box';
import CardList from './CardList';
import Path from './Path';
import Checkout from './Checkout';

const priceData = {products_price: 100, delivery_price: 10, total_price: 110};
const deliveryPrice = 5;

const Cart = () => {
  const [cart, setCart] = useState ([]);

  useEffect (() => {
    fetch ('http://localhost:8000/cart')
      .then (res => res.json ())
      .then (data => setCart (data));
  }, []);

  const handlDelete = async id => {
    await fetch ('http://localhost:8000/cart/' + id, {
      method: 'DELETE',
    });

    const newItems = cart.filter (item => item.id !== id);
    setCart (newItems);
  };

  const handleCountChange = async (id, counted) => {
    const updatedItem = cart.filter (item => item.id === id)[0];

    await fetch ('http://localhost:8000/cart/' + id, {
      method: 'PUT',
      headers: {'Content-Type': 'application/json'},
      body: JSON.stringify ({
        id: updatedItem.id,
        userId: updatedItem.userId,
        quantity: counted,
      }),
    });
  };

  const [shops, setShops] = useState ([]);

  useEffect (() => {
    fetch ('http://localhost:8002/shop')
      .then (res => res.json ())
      .then (data => setShops (data));
  }, []);

  const [items, setItems] = useState ([]);
  var cartItems = [];
  var price = 0;

  useEffect (() => {
    fetch ('http://localhost:8001/products')
      .then (res => res.json ())
      .then (data => setItems (data));
  }, []);

  cart.map (item => cartItems.push (items.find (x => x.id === item.id)));

  cartItems.map (
    item =>
      (price +=
        items.find (x => x.id === item.id).price *
        cart.find (x => x.id === item.id).quantity)
  );

  return (
    <Box justifyContent="center" alignItems="center">
      <Grid>
        <Path path={'Shopping Cart'} />
      </Grid>
      <Grid
        sx={{
          display: 'flex',
          marginBottom: 7,
        }}
      >
        <Box
          component="div"
          sx={{
            display: 'flex',
            flexDirection: 'column',
          }}
        >
          <CardList
            cartItems={cartItems}
            shops={shops}
            data={cart}
            handleDelete={handlDelete}
            handleCountChange={handleCountChange}
          />
        </Box>
        <Box
          component="div"
          sx={{
            display: 'flex',
            flexDirection: 'column',
            marginLeft: 'auto',
            marginTop: 4,
          }}
        >
          <Checkout
            products_price={price}
            delivery_price={deliveryPrice}
            total_price={price + deliveryPrice}
          />
        </Box>
      </Grid>
    </Box>
  );
};

export default Cart;
