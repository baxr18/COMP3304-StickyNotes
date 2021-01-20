using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class StickyNote : Form
    {
        // CREATE a new sticky note when 'New Note' button is clicked


        string noteToggle = "expanded";

        public StickyNote()
        {
            InitializeComponent();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            switch (noteToggle)
            {
                case "expanded":
                    txtText.Visible = false;
                    noteToggle = "collapsed";
                    btnCollapse.Text = "Expand Note";
                    return;
                case "collapsed":
                    txtText.Visible = true;
                    btnCollapse.Text = "Collapse Note";
                    noteToggle = "expanded";
                    return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtText_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }

        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }
        #endregion
    }
}
