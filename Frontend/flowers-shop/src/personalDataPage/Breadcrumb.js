import Breadcrumbs from "@mui/material/Breadcrumbs";
import Typography from "@mui/material/Typography";
import NavigateNextIcon from "@mui/icons-material/NavigateNext";

const Breadcrumb = (props) => {
    const breadcrumbs = props.routes.map((route, idx) => [
        <Typography
            key={idx}
            color={props.routes.length - 1 === idx ? "text.primary" : "text"}
        >
            {route}
        </Typography>
    ]);

    return (
        <Breadcrumbs
            separator={<NavigateNextIcon fontSize="small" />}
            aria-label="breadcrumb"
            sx={{ paddingTop: 20 }}
        >
            {breadcrumbs}
        </Breadcrumbs>
    );
};

export default Breadcrumb;
