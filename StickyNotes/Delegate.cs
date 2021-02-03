using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes
{
    /// <summary>
    /// REMOVE a sticky note from the dictionary based on its ID
    /// </summary>
    /// <param name="key"></param>
    public delegate void DeleteStickyNote(int key);

    /// <summary>
    /// RETRIEVE the text associated with a sticky note instance based on its ID
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public delegate String RetrieveText(int key);

    /// <summary>
    /// UPDATE the text of a sticky note instance with 'newText', based on the ID of the instance
    /// </summary>
    /// <param name="key"></param>
    /// <param name="newText"></param>
    public delegate void ReplaceText(int key, String newText);
}
