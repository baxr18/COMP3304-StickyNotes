using System;

namespace StickyNotes
{
    internal interface ITextData
    {
        /// <summary>
        /// RETRIEVE the original text from a sticky note instance and pass it to the NoteData class
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string RetrieveText(int key);

        /// <summary>
        /// RETRIEVE the changed text from a sticky note instance and pass it to the NoteData class
        /// </summary>
        /// <param name="key"></param>
        /// <param name="newText"></param>
        void ChangeText(int key, String newText);
    }
}