import TextField from "@material-ui/core/TextField";
import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";

const ShopField = (props) => {
    const settings = props.settings.map(({ key, value }) => (
        <Box component="div" className="ShopField" key={key}>
            <Typography
                sx={{ width: "150px" }}
                display="inline-block"
            >{`${key}:`}</Typography>
            <TextField
                type="text"
                value={value ?? ""}
                inputProps={{
                    style: {
                        paddingBottom: "3px"
                    }
                }}
            />
        </Box>
    ));
    return (
        <Box component="div" className="ShopField">
            {settings}
        </Box>
    );
};

export default ShopField;
