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

        // DECLARE a list of note instances to store to
        List<Form> _notesList = new List<Form>();

        public StickyNotes(ref List<Form> notesList)
        {
            InitializeComponent();
            _notesList = notesList;
        }

        // CREATE new sticky note instance and add it to the list
        private void btnNew_Click(object sender, EventArgs e)
        {
            _newNote = new StickyNote();
            _notesList.Add(_newNote);
            _newNote.Show();
        }
    }
}
