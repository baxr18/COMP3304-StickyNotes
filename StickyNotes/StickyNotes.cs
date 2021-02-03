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
        // DECLARE a dictionary to store each new sticky note instance
        private IDictionary<int, Form> _noteForms;

        // INITIALISE sticky note data, text and image interfaces
        private ITextData _noteText;
        private INoteData _noteData;
        private IImageData _noteImages;

        // SET the ID key of each new sticky note instance to 0
        int _nextNoteKey = 0;

        /// <summary>
        /// INSTANSIATE the StickyNotes class, using the note dictionary and data variables sent by the controller
        /// </summary>
        /// <param name="noteContainer"></param>
        /// <param name="noteData"></param>
        public StickyNotes(IDictionary<int, Form> noteContainer, INoteData noteData)
        {
            InitializeComponent();
            // SET noteContainer and noteData to dictionary and NoteData interfaces
            _noteForms = noteContainer;
            _noteData = noteData;

            // SET the newly created _noteData variable as ITextData and IImageData interfaces
            _noteText = _noteData as ITextData;
            _noteImages = _noteData as IImageData;
        }

        /// <summary>
        /// REMOVE a sticky note instance from the dictionary
        /// </summary>
        /// <param name="noteKey"></param>
        public void RemoveNote(int noteKey)
        {
            // REMOVE the sticky note from the NoteData interface
            _noteData.RemoveItem(noteKey);

            // REMOVE the sticky note from the dictionary
            _noteForms.Remove(noteKey);
        }

        /// <summary>
        /// CREATE new sticky note instance and add it to the dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            // DECLARE a new sticky note as _noteData, sending the current ID key as a reference
            _noteData.AddItem(_nextNoteKey);

            // CREATE a new sticky note instance, passing the sticky note data, text and image to the sticky note instance
            StickyNote _newNote = new StickyNote(_nextNoteKey, _noteImages.RetrieveImage(_nextNoteKey), _noteText.RetrieveText, _noteText.ChangeText, this.RemoveNote);

            // ADD the _newNote to the dictionary
            _noteForms.Add(_nextNoteKey, _newNote);

            // SHOW the new sticky note
            _noteForms[_nextNoteKey].Show();

            // ADD 1 to the sticky note ID counter
            _nextNoteKey++;
        }
    }
}
