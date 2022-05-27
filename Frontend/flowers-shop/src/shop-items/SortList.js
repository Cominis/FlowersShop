import * as React from 'react';
import TextField from '@mui/material/TextField';
import Autocomplete from '@mui/material/Autocomplete';
import { Button, Grid } from "@mui/material";

const category = [
    { label: 'A-Z' },
]

const title = [
    { label: 'A-Z' },
]

const SortList = (props) => {
    return (
        <Grid container rowSpacing={1} columnSpacing={{ xs: 1, sm: 2, md: 3 }}>
            <Grid item xs={6}>
                <Autocomplete
                    disablePortal
                    id="combo-box-category"
                    options={category}
                    sx={{ width: 250 }}
                    renderInput={(params) => <TextField {...params} label="category" />}
                />
            </Grid>
            <Grid item xs={6}>
                <Autocomplete
                    disablePortal
                    id="combo-box-title"
                    options={title}
                    sx={{ width: 250 }}
                    renderInput={(params) => <TextField {...params} label="title" />}
                />
            </Grid>
        </Grid>
    );
}

export default SortList;