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

        // DECLARE a boolean variable for if the note is expanded or collapsed
        string noteToggle = "expanded";

        private DeleteStickyNote _deleteThis;

        private int _id;

        public StickyNote(int id, DeleteStickyNote deleteMe)
        {
            _id = id;

            _deleteThis = deleteMe;

            InitializeComponent();
        }

        // Collapse/expand sticky note on click
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            switch (noteToggle)
            {
                // Collapse sticky note and set boolean to "collapsed"
                case "expanded":
                    txtText.Visible = false;
                    btnDelete.Visible = false;
                    noteToggle = "collapsed";
                    btnCollapse.Text = "Expand Note";
                    return;
                // Expand sticky note and set boolean to "expanded"
                case "collapsed":
                    txtText.Visible = true;
                    btnDelete.Visible = true;
                    btnCollapse.Text = "Collapse Note";
                    noteToggle = "expanded";
                    return;
            }
        }

        // Dispose sticky note on click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this._deleteThis(_id);
        }

        // Clear textbox on click
        private void txtText_Click(object sender, EventArgs e)
        {
            this.txtText.Text = "";
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
