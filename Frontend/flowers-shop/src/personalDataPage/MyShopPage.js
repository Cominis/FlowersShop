import * as React from "react";
import PersonalData from "./PersonalData";
import Typography from "@mui/material/Typography";
import ShopField from "./ShopField";
import Box from "@mui/material/Box";
import { Button } from "@mui/material";

const MyShopPage = (props) => {
    const routes = ["Flower E-shop", "My Shop"];
    const shopKeys = ["shop name", "shop description", "shop location"];
    const shopValues = [
        "Geliu parduotuve",
        "Cia tik geriausios geles",
        "Vilnius, Vilniaus g. 6"
    ];

    const pageInfo = (
        <>
            <Box component="div" className="SettingField" paddingBottom={10}>
                <Typography paddingBottom={10} sx={{ textAlign: "center" }}>
                    {"shop settings"}
                </Typography>
                <ShopField
                    settings={shopKeys.map((key, idx) => ({
                        key,
                        value: shopValues[idx]
                    }))}
                />
            </Box>
            <Button variant="outlined">Create/Update</Button>
        </>
    );

    return <PersonalData pageInfo={pageInfo} routes={routes} />;
};

export default MyShopPage;
