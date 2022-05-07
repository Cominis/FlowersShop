import * as React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';


const Path = (props) => {
    return (
        <Box>
            <Typography variant="h6" color="text.secondary" marginTop={14}>
                {props.path.toUpperCase()}
            </Typography>
        </Box>
    );
}

export default Path;
