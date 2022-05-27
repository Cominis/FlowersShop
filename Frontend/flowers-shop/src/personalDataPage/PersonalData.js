import * as React from "react";
import Breadcrumb from "./Breadcrumb";
import Divider from "@mui/material/Divider";
import { styled } from "@mui/material/styles";
import MuiGrid from "@mui/material/Grid";
import SettingList from "./SettingList";

const Grid = styled(MuiGrid)(({ theme }) => ({
    width: "100%",
    ...theme.typography.body2,
    '& [role="separator"]': {
        margin: theme.spacing(0, 2)
    }
}));

const PersonalData = (props) => {
    return (
        <>
            <Breadcrumb routes={props.routes} />

            <Grid
                container
                direction="row"
                alignItems="center"
                justifyContent="left"
                sx={{ paddingLeft: -10 }}
            >
                <Grid item xs={3} sx={{ paddingTop: 10 }}>
                    <SettingList />
                </Grid>
                <Divider orientation="vertical" flexItem />
                <Grid item xs={6} sx={{ paddingLeft: 20 }}>
                    {props.pageInfo}
                </Grid>
            </Grid>
        </>
    );
};

export default PersonalData;
