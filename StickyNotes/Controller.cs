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
        List<Form> notesList = new List<Form>();

        public Controller()
        {
            Application.Run(new StickyNotes(ref notesList));
        }
    }
}
