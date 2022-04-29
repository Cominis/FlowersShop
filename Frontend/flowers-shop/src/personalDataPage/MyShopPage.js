import * as React from "react";
import PersonalData from "./PersonalData";
import Typography from "@mui/material/Typography";
import ShopField from "./ShopField";
import Box from "@mui/material/Box";
import axios from "../net/axios";
import { useGlobalState } from "../App";

const MyShopPage = (props) => {
    const [globalState] = useGlobalState();
    const [shop, setShop] = React.useState();
    const routes = ["Flower E-shop", "My Shop"];

    React.useEffect(() => {
        if (shop) {
            return;
        }
        const fetchData = async () => {
            try {
                const response = await axios.get("Shops", {
                    headers: globalState.headers
                });
                setShop(response?.data?.response);
            } catch (err) {
                alert(
                    err.response?.data?.Error?.Message ||
                        "Unexpected error occured, try again"
                );
            }
        };

        fetchData();
    }, []);

    const pageInfo = (
        <>
            <Box component="div" className="SettingField" paddingBottom={10}>
                <Typography paddingBottom={10} sx={{ textAlign: "center" }}>
                    {"shop settings"}
                </Typography>
                <ShopField useShop={[shop, setShop]} />
            </Box>
        </>
    );

    return <PersonalData pageInfo={pageInfo} routes={routes} />;
};

export default MyShopPage;
