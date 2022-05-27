import * as React from 'react';
import TextField from '@mui/material/TextField';
import Autocomplete from '@mui/material/Autocomplete';
import { Button, Grid } from "@mui/material";

const occasion = [
    { label: 'Valentine\'s Day first' },
    { label: 'Birthday first' },
    { label: 'Mother\'s Day first' },
    { label: 'Anniversary first' },
    { label: 'Teacher\'s Day first' },
]

const type = [
    { label: 'flowers first' },
    { label: 'bouquets first' },
]

const price = [
    { label: 'to 5 EUR' },
    { label: 'from 5 to 10 EUR' },
    { label: 'from 10 to 20 EUR' },
    { label: 'from 20 to 30 EUR' },
    { label: 'from 30 to 50 EUR' },
    { label: 'from 50 EUR' },
]

const popularity = [
    { label: 'popular first' },
    { label: 'unpopular first' },
]

const SortList = (props) => {
    return (
        <Grid container rowSpacing={1} columnSpacing={{ xs: 1, sm: 2, md: 3 }}>
            <Grid item xs={2.8}>
                <Autocomplete
                    disablePortal
                    id="combo-box-occasion"
                    options={occasion}
                    sx={{ width: 250 }}
                    renderInput={(params) => <TextField {...params} label="occasion" />}
                />
            </Grid>
            <Grid item xs={2.8}>
                <Autocomplete
                    disablePortal
                    id="combo-box-type"
                    options={type}
                    sx={{ width: 250 }}
                    renderInput={(params) => <TextField {...params} label="type" />}
                />
            </Grid>
            <Grid item xs={2.8}>
                <Autocomplete
                    disablePortal
                    id="combo-box-price"
                    options={price}
                    sx={{ width: 250 }}
                    renderInput={(params) => <TextField {...params} label="price" />}
                />
             </Grid>
             <Grid item xs={2.8}>
                <Autocomplete
                    disablePortal
                    id="combo-box-popularity"
                    options={popularity}
                    sx={{ width: 250 }}
                    renderInput={(params) => <TextField {...params} label="popularity" />}
                />
            </Grid>
        </Grid>
    );
}

export default SortList;