import Typography from '@mui/material/Typography';
import Box from '@mui/material/Box';
import * as React from 'react';
import {useGlobalState} from '../App';
import RemoveCircleIcon from '@mui/icons-material/RemoveCircle';
import PauseIcon from '@mui/icons-material/Pause';
import axios from "../net/axios";

const DisplayProducts = (props) => {
  const [globalState] = useGlobalState();
  const [shop, setShop] = props.useShop;

  const handleClick = async (id) => {  
    try {
      const response = await axios.delete(`Products/${id}`, {
          headers: globalState.headers
      });
      const products = shop?.products?.filter(({id : productId}) => productId !== id);
      setShop({...shop,products});
      alert(response.data.response);
  } catch (err) {
      alert(
          err.response?.data?.Error?.Message ||
              "Unexpected error occured, try again"
      );
  }
  };

  const handleClickUpdate = async (id,title, description, status, category, price, quantity) => {  
    const payload = {
      ShopId : shop.id,
      Title : title,
      Description : description,
      Category : category,
      SubCategory: "",
      Status : status === 0 ? "OutOfStock" : "Available",
      Price : price,
      Quantity : status === 0 ? 0 : 10
    }
    
    try {
      const response = await axios.put(`Products/${id}`,payload, {
          headers: globalState.headers
      });
      console.log(response);
      const newShop = response.data.response.shop;
      newShop.products.push(response.data.response);
      setShop(newShop);
      alert("Product updated");
  } catch (err) {
      alert(
          err.response?.data?.Error?.Message ||
              "Unexpected error occured, try again"
      );
  }
  };

  return shop?.products?.map (
    ({title, description, status, category, price, quantity, id}) => (
    <Box component="div" key={id} sx = {{border : 1, "borderRadius" : "10px"}}>
      <Box component = "div">
      <RemoveCircleIcon sx={{color : "red", cursor : "pointer"}} onClick = {() => handleClick(id)}/>
      <PauseIcon sx={{color : "blue", cursor : "pointer"}} onClick = {() => handleClickUpdate(id,title, description, status, category, price, quantity)} />
      <Box component="div">
        <Typography sx={{paddingLeft : "10px"}}>
          Title:
          {title}
          </Typography>
    </Box>
    <Box component="div">
        <Typography sx={{paddingLeft : "10px"}}>
          Description:
          {description}
        </Typography>
    </Box>
    <Box component="div">
        <Typography sx={{paddingLeft : "10px"}}>
          Status:
          {status === 0 ? "Available" : "Out of stock"}
        </Typography>
    </Box>
    <Box component="div">
        <Typography sx={{paddingLeft : "10px"}}>
          Category:
          {category}
        </Typography>
    </Box>
    <Box component="div">
        <Typography sx={{paddingLeft : "10px"}}>
          Price:
          {price}
        </Typography>
    </Box>
    <Box component="div">
        <Typography sx={{paddingLeft : "10px"}}>
          Quantity:
          {quantity}
        </Typography>
        </Box>
    </Box>
    <Box sx={{paddingBottom : "30px"}}/> 
    </Box>
    )
  );
};

export default DisplayProducts;
