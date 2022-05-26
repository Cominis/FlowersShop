import {Button, Typography} from '@mui/material';
import {Box} from '@mui/system';
import * as React from 'react';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';

const ShopsItem = props => {
  return (
    <ListItem
      key={`item-${props.shop.id}`}
      sx={{border: 1, borderRadius: '10px'}}
    >
      <Box
        sx={{
          display: 'flex',
          flexFlow: 'column noWrap',
          flexGrow: '4',
        }}
      >
        <Box sx={{display: 'flex', justifyContent: 'space-between'}}>
          <ListItemText primary={props.shop.name} />
          <Button>Add</Button>
        </Box>

        <Typography>Location: {props.shop.location}</Typography>
      </Box>
    </ListItem>
  );
};

export default ShopsItem;
