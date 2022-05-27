import * as React from 'react';
import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';
import Slide from '@mui/material/Slide';
import {useNavigate} from 'react-router-dom';
const PopUp = props => {
  const navigate = useNavigate ();
  const Transition = React.forwardRef (function Transition (props, ref) {
    return <Slide direction="up" ref={ref} {...props} />;
  });
  const [open, setOpen] = props.useShow;
  const [, setCart] = props.useCart;

  const removeCart = () => {
    localStorage.setItem ('cart', JSON.stringify ([]));
    setOpen (false);
    setCart ([]);
  };

  return (
    <div>
      <Dialog
        open={open}
        TransitionComponent={Transition}
        keepMounted
        aria-describedby="alert-dialog-slide-description"
      >
        <DialogTitle>{'Confirm purchase'}</DialogTitle>
        <DialogContent>
          <DialogContentText id="alert-dialog-slide-description">
            Are you sure?
          </DialogContentText>
        </DialogContent>
        <DialogActions>
          <Button onClick={() => setOpen (false)}>
            Cancel
          </Button>
          <Button onClick={() => removeCart ()}>
            Confirm
          </Button>
        </DialogActions>
      </Dialog>
    </div>
  );
};

export default PopUp;
