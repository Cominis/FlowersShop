import { IconButton, List, ListSubheader, Typography } from "@mui/material";
import { Box, margin } from "@mui/system";
import { GridList, GridListTile, GridListTileBar } from "@material-ui/core";
import { withStyles } from "@material-ui/core/styles";

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

const FlowersContainer = (props) => {
    const { classes } = props;

    const tileData = [
        {
            key: "0",
            img: imgs["btulpe.jpg"],
            title: "White tulp",
            country: "Lithunia"
        },
        {
            key: "1",
            img: imgs["rtulpe.jpg"],
            title: "Red tulp",
            country: "USA"
        },
        {
            key: "2",
            img: imgs["otulpe.jpg"],
            title: "Orange tulp",
            country: "Lithuania"
        },
        {
            key: "3",
            img: imgs["mtulpe.jpg"],
            title: "Light red tulp",
            country: "Poland"
        },
        {
            key: "4",
            img: imgs["btulpe.jpg"],
            title: "White tulp",
            country: "Lithunia"
        },
        {
            key: "5",
            img: imgs["rtulpe.jpg"],
            title: "Red tulp",
            country: "USA"
        },
        {
            key: "6",
            img: imgs["otulpe.jpg"],
            title: "Orange tulp",
            country: "Lithuania"
        },
        {
            key: "7",
            img: imgs["mtulpe.jpg"],
            title: "Light red tulp",
            country: "Poland"
        }
    ];

    return (
        <div className={classes.root}>
            <GridList cellHeight={200} className={classes.gridList} cols={3}>
                <GridListTile
                    key="Subheader"
                    cols={3}
                    style={{ height: "auto" }}
                >
                    <ListSubheader component="div">flowers</ListSubheader>
                </GridListTile>
                {tileData.map((tile) => (
                    <GridListTile key={tile.key}>
                        <img src={tile.img} alt={tile.title} />
                        <GridListTileBar
                            title={tile.title}
                            subtitle={<span>Country: {tile.country}</span>}
                            actionIcon={
                                <IconButton className={classes.icon}>
                                    Info
                                </IconButton>
                            }
                        />
                    </GridListTile>
                ))}
            </GridList>
        </div>
    );
};

export default withStyles(styles)(FlowersContainer);
