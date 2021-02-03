using System;

namespace StickyNotes
{
    internal interface ITextData
    {
        string RetrieveText(int key);
        void ChangeText(int key, String newText);
    }
}