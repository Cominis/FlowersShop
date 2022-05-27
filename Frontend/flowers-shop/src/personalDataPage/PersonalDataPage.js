import * as React from "react";
import SettingField from "./SettingField";
import VisibilityIcon from "@mui/icons-material/Visibility";
import VisibilityOffIcon from "@mui/icons-material/VisibilityOff";
import IconButton from "@mui/material/IconButton";
import PersonalData from "./PersonalData";

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

    const routes = ["Flower E-shop", "PROFILE"];

    const pageInfo = (
        <>
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
        </>
    );

    return <PersonalData pageInfo={pageInfo} routes={routes} />;
};

export default PersonalDataPage;
