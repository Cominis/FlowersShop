import { IconButton, List, ListSubheader, Typography } from "@mui/material";
import { Box, margin } from "@mui/system";
import { GridList, GridListTile, GridListTileBar } from "@material-ui/core";
import { withStyles } from "@material-ui/core/styles";
import { ImageList, ImageListItem, ImageListItemBar } from "@material-ui/core";

const styles = (theme) => ({
    root: {
        display: "flex",
        flexWrap: "wrap",
        justifyContent: "space-around",
        overflow: "hidden",
        backgroundColor: theme.palette.background.paper
    },
    gridList: {
        width: 450,
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
            <div className={classes.root}>
                <ImageList cols={3} className={classes.gridList}>
                    <ImageListItem
                        key="Subheader"
                        cols={3}
                        style={{ height: "auto" }}
                    >
                        <ListSubheader component="div">flowers</ListSubheader>
                    </ImageListItem>
                    {props.shop.products.map((tile) => (
                        <ImageListItem key={tile.id}>
                            <img
                                src={
                                    imgs[
                                        imgsNames[
                                            Math.floor(
                                                Math.random() * imgsNames.length
                                            )
                                        ]
                                    ]
                                }
                                alt={tile.title}
                            />
                            <ImageListItemBar
                                title={tile.title}
                                subtitle={
                                    <span>Country: {props.shop.location}</span>
                                }
                                actionIcon={
                                    <IconButton className={classes.icon}>
                                        Info
                                    </IconButton>
                                }
                            />
                        </ImageListItem>
                    ))}
                </ImageList>
            </div>
        )
    );
};

export default withStyles(styles)(FlowersContainer);
