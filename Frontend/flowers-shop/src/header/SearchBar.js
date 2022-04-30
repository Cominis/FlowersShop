import * as React from 'react';
import {styled, alpha} from '@mui/material/styles';
import InputBase from '@mui/material/InputBase';
import SearchIcon from '@mui/icons-material/Search';
import {useNavigate} from 'react-router-dom';
import axios from '../net/axios';
import {Box, Button, CircularProgress, Grid} from '@mui/material';
import Typography from '@mui/material/Typography';
import Select from '@mui/material/Select';
import MenuItem from '@mui/material/MenuItem';

const Search = styled ('div') (({theme}) => ({
  position: 'relative',
  borderRadius: theme.shape.borderRadius,
  backgroundColor: alpha (theme.palette.common.white, 0.15),
  '&:hover': {
    backgroundColor: alpha (theme.palette.common.white, 0.25),
  },
  marginRight: theme.spacing (2),
  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up ('sm')]: {
    marginLeft: theme.spacing (3),
    width: 'auto',
  },
}));

const SearchIconWrapper = styled ('div') (({theme}) => ({
  padding: theme.spacing (0, 2),
  height: '100%',
  position: 'absolute',
  pointerEvents: 'none',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
}));

const StyledInputBase = styled (InputBase) (({theme}) => ({
  color: 'inherit',
  '& .MuiInputBase-input': {
    padding: theme.spacing (1, 1, 1, 0),
    // vertical padding + font size from searchIcon
    paddingLeft: `calc(1em + ${theme.spacing (4)})`,
    transition: theme.transitions.create ('width'),
    width: '100%',
    [theme.breakpoints.up ('md')]: {
      width: '20ch',
    },
  },
}));

const SearchBar = () => {
  const navigate = useNavigate ();
  const [statusSearch, setstatusSearch] = React.useState ('All');
  const [priceStart, setPriceStart] = React.useState (0);
  const [priceEnd, setPriceEnd] = React.useState (0);
  const [results, setResults] = React.useState ();
  const [isLoading, setIsLoading] = React.useState (false);
  const [query, setQuery] = React.useState ('""');

  const getSearchResults = async () => {
    setIsLoading (true);

    const payload = {
      SearchQuery: query,
    };

    try {
      const response = await axios.get (
        `Search/${query}/${priceStart}/${priceEnd}/${statusSearch}`
      );

      console.log (response);
      setResults (response.data.response);
      navigate ('/shops');
    } catch (err) {
      alert ('Bad search, try again');
    }
    setIsLoading (false);
  };

  const search = query => {};

  return (
    <Grid
      container
      sx={{
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
      }}
      rowSpacing={0}
      columnSpacing={0}
      direction="row"
    >
      {isLoading
        ? <Grid item sx={{display: 'flex'}}>
            <CircularProgress sx={{color: 'white'}} size="2vh" />
          </Grid>
        : null}
      <Grid item>
        <Search>
          <SearchIconWrapper>
            <SearchIcon />
          </SearchIconWrapper>
          <StyledInputBase
            placeholder="Search…"
            inputProps={{'aria-label': 'search'}}
            onChange={e => setQuery (e.target.value)}
          />
          <Button sx={{color: 'white'}} onClick={getSearchResults}>
            Search
          </Button>
        </Search>
      </Grid>
      <Grid sx={{float: 'left'}}>
        Status: <Select
          value={statusSearch}
          onChange={e => setstatusSearch (e.target.value)}
          sx={{
            width: '177px',
            height: '20px',
            color: 'black',
            backgroundColor: 'white',
          }}
        >
          <MenuItem value={'Available'}>Available</MenuItem>
          <MenuItem value={'OutOfStock'}>Out Of Stock</MenuItem>
          <MenuItem value={'All'}>All</MenuItem>
        </Select>
      </Grid>
      <Grid>
        Price from:
        <input
          type="number"
          value={priceStart}
          onChange={e => setPriceStart (e.target.value)}
        />
      </Grid>
      <Grid>
        Price to:
        <input
          type="number"
          value={priceEnd}
          onChange={e => setPriceEnd (e.target.value)}
        />
      </Grid>
    </Grid>
  );
};

export default SearchBar;
