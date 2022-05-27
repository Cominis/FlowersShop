import { IconButton, ListSubheader } from "@mui/material";
import { withStyles } from "@material-ui/core/styles";
import { ImageList, ImageListItem, ImageListItemBar } from "@material-ui/core";
import AddIcon from "@mui/icons-material/Add";

const styles = (theme) => ({
    root: {
        display: "flex",
        flexWrap: "wrap",
        justifyContent: "space-around",
        overflow: "hidden",
        backgroundColor: theme.palette.background.paper
    },
    gridList: {
        width: 490,
        height: 600
    },
    icon: {
        color: "rgba(255, 255, 255, 0.54)"
    }
});

function importAll(r) {
    let images = {};
    r.keys().map((item, index) => {
        images[item.replace("./", "")] = r(item);
    });
    return images;
}

const imgs = importAll(
    require.context("../../images", false, /\.(png|jpe?g|svg)$/)
);
const imgsNames = ["btulpe.jpg", "mtulpe.jpg", "otulpe.jpg", "rtulpe.jpg"];

const FlowersContainer = (props) => {
    const { classes } = props;
    return (
        props.shop && (
            <>
                <ListSubheader component="div">flowers</ListSubheader>
                <div className={classes.root}>
                    <ImageList cols={3} className={classes.gridList}>
                        <ImageListItem
                            key="Subheader"
                            cols={3}
                            style={{ height: "auto" }}
                        ></ImageListItem>
                        {props.shop.products.map((tile) => (
                            <ImageListItem key={tile.id}>
                                {tile.status === 0 ? (
                                    <AddIcon
                                        sx={{ cursor: "pointer" }}
                                        onClick={() => {
                                            let cart =
                                                localStorage.getItem("cart");
                                            if (!cart) {
                                                localStorage.setItem(
                                                    "cart",
                                                    JSON.stringify([tile.id])
                                                );
                                            } else {
                                                cart = JSON.parse(cart);
                                                cart.push(tile.id);
                                                localStorage.setItem(
                                                    "cart",
                                                    JSON.stringify(cart)
                                                );
                                            }
                                            alert(
                                                "Flower was added to the cart!"
                                            );
                                        }}
                                    />
                                ) : (
                                    ""
                                )}
                                <img
                                    src={
                                        imgs[
                                            imgsNames[
                                                Math.floor(
                                                    Math.random() *
                                                        imgsNames.length
                                                )
                                            ]
                                        ]
                                    }
                                    alt={tile.title}
                                />
                                <ImageListItemBar
                                    title={tile.title}
                                    subtitle={
                                        <span>
                                            Price: {`${tile.price} Eur`}
                                        </span>
                                    }
                                    actionIcon={
                                        <IconButton
                                            className={classes.icon}
                                            sx={{
                                                backgroundColor:
                                                    tile.status === 0
                                                        ? "green"
                                                        : "red"
                                            }}
                                        >
                                            Info
                                        </IconButton>
                                    }
                                />
                            </ImageListItem>
                        ))}
                    </ImageList>
                </div>
            </>
        )
    );
};

export default withStyles(styles)(FlowersContainer);
