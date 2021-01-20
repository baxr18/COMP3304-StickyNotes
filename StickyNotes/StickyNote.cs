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
    }
}
