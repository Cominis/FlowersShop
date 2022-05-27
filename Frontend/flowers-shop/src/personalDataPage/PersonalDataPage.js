import * as React from "react";
import Breadcrumb from "./Breadcrumb";
import SettingField from "./SettingField";
import Header from "../header/Header";
import Divider from "@mui/material/Divider";
import { styled } from "@mui/material/styles";
import MuiGrid from "@mui/material/Grid";
import SettingList from "./SettingList";
import VisibilityIcon from "@mui/icons-material/Visibility";
import VisibilityOffIcon from "@mui/icons-material/VisibilityOff";
import IconButton from "@mui/material/IconButton";

const Grid = styled(MuiGrid)(({ theme }) => ({
    width: "100%",
    ...theme.typography.body2,
    '& [role="separator"]': {
        margin: theme.spacing(0, 2)
    }
}));

const PersonalDataPage = (props) => {
    const [visible, setVisible] = React.useState(false);
    const keys = [
        "name",
        "last name",
        "e-mail",
        "address",
        "password",
        "made-orders",
        "joined"
    ];
    const values = [
        "testName",
        "test last name",
        "email@gmail.com",
        "address1",
        "",
        "made-orders",
        "joined date"
    ];

    return (
        <>
            <Breadcrumb routes={["Flower E-shop", "PROFILE"]} />

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
                    <IconButton
                        size="large"
                        aria-label="settings visibility"
                        aria-haspopup="true"
                        onClick={() => setVisible(!visible)}
                        color="inherit"
                    >
                        {visible ? <VisibilityOffIcon /> : <VisibilityIcon />}
                    </IconButton>

                    <SettingField
                        settings={keys.map((key, idx) => ({
                            key,
                            visible: key === "password" ? false : visible,
                            value: values[idx],
                            disabled: key === "joined"
                        }))}
                    />
                </Grid>
            </Grid>
        </>
    );
};

export default PersonalDataPage;
