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
        // DECLARE a boolean variable for if the note is expanded or collapsed
        string noteToggle = "expanded";

        // DECLARE delegate methods
        private DeleteStickyNote _deleteThis;
        private RetrieveText _retrieveText;
        private ReplaceText _replaceText;

        // DECLARE the ID of a sticky note instance
        private int _id;

        // DECLARE the text associated with a sticky note instance
        private string _text;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image"></param>
        /// <param name="retrieveText"></param>
        /// <param name="replaceText"></param>
        /// <param name="deleteMe"></param>
        public StickyNote(int id, Image image, RetrieveText retrieveText, ReplaceText replaceText, DeleteStickyNote deleteMe)
        {
            InitializeComponent();

            _id = id;

            this.btnCollapse.Image = image;

            _deleteThis = deleteMe;

            _retrieveText = retrieveText;

            _replaceText = replaceText;
        }

        /// <summary>
        /// Collapse/expand sticky note on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// DISPOSE sticky note instance on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();

            // DELETE the ID associated with the sticky note from 
            this._deleteThis(_id);
        }

        /// <summary>
        /// CLEAR textbox on click and retrieve the stored text for a sticky note based on its ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtText_Click(object sender, EventArgs e)
        {
            this.txtText.Text = _retrieveText(_id);
        }

        /// <summary>
        /// UPDATE the stored text for a sticky note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            _text = txtText.Text;
            _replaceText(_id, _text);
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
