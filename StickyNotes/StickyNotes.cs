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
        //Form _newNote = new StickyNote();

        // DECLARE a list of note instances to store to
        //IList<Form> _noteForms = new List<Form>();

        private IDictionary<int, Form> _noteForms;

        private ITextData _noteText;

        private INoteData _noteData;

        int _nextNoteKey = 0;

        public StickyNotes(IDictionary<int, Form> noteContainer, INoteData noteData)
        {
            InitializeComponent();
            _noteForms = noteContainer;
            _noteData = noteData;
            _noteText = _noteData as ITextData;
        }

        public void RemoveNote(int noteKey)
        {
            _noteData.RemoveItem(noteKey);

            _noteForms.Remove(noteKey);
        }

        // CREATE new sticky note instance and add it to the list
        private void btnNew_Click(object sender, EventArgs e)
        {
            _noteData.AddItem(_nextNoteKey);
            StickyNote _newNote = new StickyNote(_nextNoteKey, _noteText.RetrieveText, _noteText.ChangeText, this.RemoveNote);
            _noteForms.Add(_nextNoteKey, _newNote);
            _noteForms[_nextNoteKey].Show();
            _nextNoteKey++;
        }
    }
}
