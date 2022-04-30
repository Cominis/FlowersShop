import * as React from "react";
import PersonalData from "./PersonalData";
import Typography from "@mui/material/Typography";
import ShopField from "./ShopField";
import Box from "@mui/material/Box";
import axios from "../net/axios";
import { useGlobalState } from "../App";
import { useNavigate } from "react-router-dom";
import ProductField from "./ProductField"
import DisplayProducts from "./DisplayProducts"

const MyShopPage = (props) => {
    const [globalState] = useGlobalState();
    const navigate = useNavigate();
    const [shop, setShop] = React.useState();
    const routes = ["Flower E-shop", "My Shop"];

    React.useEffect(() => {
        if (shop) {
            return;
        }
        if (localStorage.getItem("token") === null) {
            navigate('/signin');
            return;
        }
        const fetchData = async () => {
            try {
                const response = await axios.get("Shops", {
                    headers: globalState.headers
                });
                setShop(response?.data?.response);
            } catch (err) {
                console.log(err);
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
            {
                shop ? <Box component="div" className="SettingField" paddingBottom={10}>
                <Typography paddingBottom={10} sx={{ textAlign: "center" }}>
                    {"product settings"}
                </Typography>
                <ProductField useShop={[shop, setShop]}/>
                </Box> : ""
            }
            
            {
                shop ? <DisplayProducts useShop={[shop, setShop]} /> : ""
            }
        </>
    );

    return <PersonalData pageInfo={pageInfo} routes={routes} />;
};

export default MyShopPage;
