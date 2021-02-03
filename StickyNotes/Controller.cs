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
        // INSTANTIATE a new 'StickyNotes' by passing list as reference
        public Controller()
        {
            // DECLARE a new dictionary to store sticky note instances
            IDictionary<int, Form> noteForms = new Dictionary<int, Form>();

            // INSTANTIATE a new NoteData component
            INoteData noteData = new NoteData();

            // RUN the initial application by passing the newly created dictionary and NoteData
            Application.Run(new StickyNotes(noteForms, noteData));
        }
    }
}
