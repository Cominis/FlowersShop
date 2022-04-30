import * as React from 'react';
import {useEffect, useState} from 'react';
import {Grid} from '@mui/material';
import Box from '@mui/material/Box';
import ItemList from './ItemList';
import SortBy from './SortBy';
import useMediaQuery from '@mui/material/useMediaQuery';

const ShopItems = () => {
  const [items, setItems] = useState ([]);

  useEffect (() => {
    fetch ('http://localhost:8001/products')
      .then (res => res.json ())
      .then (data => setItems (data));
  }, []);

  const [cart, setCart] = useState ([]);

  useEffect (() => {
    fetch ('http://localhost:8000/cart')
      .then (res => res.json ())
      .then (data => setCart (data));
  }, []);

  const handleAdd = async (item, counted) => {
    const addedCartItem = cart.filter (x => x.id === item.id)[0];
    console.log (addedCartItem);

    if (typeof addedCartItem !== 'undefined') {
      await fetch ('http://localhost:8000/cart/' + item.id, {
        method: 'PUT',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify ({
          id: addedCartItem.id,
          userId: addedCartItem.userId,
          quantity: counted + addedCartItem.quantity,
        }),
      });
    } else {
      await fetch ('http://localhost:8000/cart', {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify ({
          id: item.id,
          userId: 'USER2',
          quantity: counted,
        }),
      });
    }
  };

  const [shops, setShops] = useState ([]);

  useEffect (() => {
    fetch ('http://localhost:8002/shop')
      .then (res => res.json ())
      .then (data => setShops (data));
  }, []);

  return (
    <Box justifyContent="center" alignItems="center">
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
            mt: 20,
          }}
        >
          <SortBy />
        </Box>
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
            mt: 25,
          }}
        >
          <ItemList data={items} shops={shops} handleAdd={handleAdd} />
        </Box>
      </Grid>
    </Box>
  );
};

export default ShopItems;
