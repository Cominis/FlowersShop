import TextField from "@material-ui/core/TextField";
import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";

const SettingField = (props) => {
    const settings = props.settings.map(({ visible, key, value, disabled }) => (
        <Box component="div" className="SettingField" key={key}>
            <Typography
                sx={{ width: "150px" }}
                display="inline-block"
            >{`${key}:`}</Typography>
            <TextField
                type="text"
                value={visible ? value : "********************"}
                disabled={visible ? disabled : true}
                inputProps={{
                    style: {
                        paddingBottom: "3px"
                    }
                }}
            />
        </Box>
    ));
    return (
        <Box component="div" className="SettingField">
            {settings}
        </Box>
    );
};

export default SettingField;
