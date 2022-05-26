import {Box} from '@mui/system';
import * as React from 'react';
import List from '@mui/material/List';
import ListSubheader from '@mui/material/ListSubheader';
import ShopsItem from './ShopItem';
const ShopsContainer = props => {
  return (
    <Box
      sx={{
        display: 'flex',
        width: '50%',
      }}
    >
      <List
        sx={{
          width: '100%',
          minWidth: '500px',
          bgcolor: 'background.paper',
          position: 'relative',
          overflow: 'auto',
          height: '700px',
          '& ul': {padding: 0},
        }}
        subheader={<li />}
      >
        <ListSubheader>Shops</ListSubheader>
        {props.shops.map (shop => <ShopsItem key={shop.id} shop={shop} />)}
      </List>
    </Box>
  );
};

export default ShopsContainer;
