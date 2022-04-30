import Typography from '@mui/material/Typography';
import Box from '@mui/material/Box';
import * as React from 'react';
import {useGlobalState} from '../App';
import RemoveCircleIcon from '@mui/icons-material/RemoveCircle';
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

  return shop?.products?.map (
    ({title, description, status, category, price, quantity, id}) => (
    <Box component="div" key={id} sx = {{border : 1, "borderRadius" : "10px"}}>
      <Box component = "div">
      <RemoveCircleIcon sx={{color : "red", cursor : "pointer"}} onClick = {() => handleClick(id)}/>
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
          {status}
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
