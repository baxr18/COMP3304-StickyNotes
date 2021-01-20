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
    public partial class StickyNotes : Form
    {
        // CREATE a new sticky note when 'Add Note' is clicked

        // DECLARE a new sticky note
        Form _newNote = new StickyNote();

        public StickyNotes()
        {
            InitializeComponent();
        }

        // CREATE new sticky note instance
        private void btnNew_Click(object sender, EventArgs e)
        {
            _newNote.Show();
        }
    }
}
