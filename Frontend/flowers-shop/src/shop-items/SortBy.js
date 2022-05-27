import * as React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import SortList from "./SortList";

const SortBy = (props) => {
    return (
        <Box>
            <Typography variant="h6" color="text.secondary">
                sort by:
            </Typography>
            <Box ml={10} mt={-6}>
                <SortList />
            </Box>
        </Box>
    );
}

export default SortBy;