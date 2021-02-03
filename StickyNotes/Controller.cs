using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    class Controller
    {
        // INSTANTIATE a new list of note instances
        IList<Form> notesList = new List<Form>();

        // INSTANTIATE a new 'StickyNotes' by passing list as reference
        public Controller()
        {
            IDictionary<int, Form> noteForms = new Dictionary<int, Form>();

            INoteData noteData = new NoteData();

            Application.Run(new StickyNotes(noteForms, noteData));
        }
    }
}
