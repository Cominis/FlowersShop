import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Container from '@mui/material/Container';
import Logo from './Logo';
import SearchBar from './SearchBar';
import LoginUser from './LoginUser';
import Hamburger from './Hamburger';
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart';
import {useNavigate} from 'react-router-dom';

const Header = () => {
  const navigate = useNavigate ();

  return (
    <AppBar position="absolute" sx={{bgcolor: 'green'}}>
      <Container maxWidth={false}>
        <Toolbar disableGutters>
          <Logo />
          <Box sx={{flexGrow: 1}} />
          <SearchBar />
          <Box sx={{flexGrow: 1}} />
          <Box
            component="div"
            sx={{cursor: 'pointer'}}
            onClick={() => {
              navigate ('/cart');
            }}
          >
            <ShoppingCartIcon/>    
            <br/>
               Cart
          </Box>
          <Hamburger />
          <LoginUser />
        </Toolbar>
      </Container>
    </AppBar>
  );
};

export default Header;
