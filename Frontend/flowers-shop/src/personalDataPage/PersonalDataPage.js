import * as React from "react";
import SettingField from "./SettingField";
import VisibilityIcon from "@mui/icons-material/Visibility";
import VisibilityOffIcon from "@mui/icons-material/VisibilityOff";
import IconButton from "@mui/material/IconButton";
import PersonalData from "./PersonalData";
import axios from "../net/axios";
import { useGlobalState } from "../App";
import { useNavigate } from "react-router-dom";

const PersonalDataPage = (props) => {
    const [globalState] = useGlobalState();
    const [visible, setVisible] = React.useState(false);
    const [user, setUser] = React.useState();
    const navigate = useNavigate();
    React.useEffect(() => {
        if (user) {
            return;
        }
        const fetchData = async () => {
            
            if (localStorage.getItem("token") === null) {
                navigate('/signin');
                return;
            }

            try {
                const response = await axios.get("Users", {
                    headers: globalState.headers
                });
                setUser(response?.data?.response);
            } catch (err) {
                alert(
                    err.response?.data?.Error?.Message ||
                        "Unexpected error occured, try again"
                );
            }
        };

        fetchData();
    }, []);
    
    const keys = [
        "first name",
        "last name",
        "email",
        "userName"
    ];
    const values = [
        user?.name || "",
        user?.surname || "",
        user?.email || "",
        user?.userName || ""
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
