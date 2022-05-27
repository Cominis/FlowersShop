import * as React from 'react';
import PropTypes from 'prop-types';
import Button from '@mui/material/Button';
import {styled} from '@mui/material/styles';
import Dialog from '@mui/material/Dialog';
import DialogTitle from '@mui/material/DialogTitle';
import DialogContent from '@mui/material/DialogContent';
import DialogActions from '@mui/material/DialogActions';
import IconButton from '@mui/material/IconButton';
import CloseIcon from '@mui/icons-material/Close';
import Typography from '@mui/material/Typography';

const BootstrapDialog = styled (Dialog) (({theme}) => ({
  '& .MuiDialogContent-root': {
    padding: theme.spacing (2),
  },
  '& .MuiDialogActions-root': {
    padding: theme.spacing (1),
  },
}));

const BootstrapDialogTitle = props => {
  const {children, onClose, ...other} = props;

  return (
    <DialogTitle
      sx={{
        m: 0,
        p: 2,
        backgroundColor: props.product.status === 0 ? 'green' : 'red',
      }}
      {...other}
    >
      {children}
      {onClose
        ? <IconButton
            aria-label="close"
            onClick={onClose}
            sx={{
              position: 'absolute',
              right: 8,
              top: 8,
              color: theme => theme.palette.grey[500],
            }}
          >
            <CloseIcon />
          </IconButton>
        : null}
    </DialogTitle>
  );
};

BootstrapDialogTitle.propTypes = {
  children: PropTypes.node,
  onClose: PropTypes.func.isRequired,
};

const PopUpFlowers = props => {
  const [product, setProduct] = props.useOpen;

  const handleClose = () => {
    setProduct ();
  };

  return (
    <div>
      <BootstrapDialog
        onClose={handleClose}
        aria-labelledby="customized-dialog-title"
        open={product}
      >
        <BootstrapDialogTitle
          id="customized-dialog-title"
          onClose={handleClose}
          product={product}
        >
          {product.title}
        </BootstrapDialogTitle>
        <DialogContent dividers>
          <Typography gutterBottom>
            Price : {product.price}
          </Typography>
          <Typography gutterBottom>
            Quantity : {product.quantity}
          </Typography>
          <Typography gutterBottom>
            Category : {product.category}
          </Typography>
          <Typography gutterBottom>
            Description : {product.description}
          </Typography>
        </DialogContent>
        <DialogActions>
          <Button autoFocus onClick={handleClose}>
            Close
          </Button>
        </DialogActions>
      </BootstrapDialog>
    </div>
  );
};

export default PopUpFlowers;
