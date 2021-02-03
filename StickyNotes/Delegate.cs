using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes
{
    public delegate void DeleteStickyNote(int key);

    public delegate String RetrieveText(int key);

    public delegate void ReplaceText(int key, String newText);
}
