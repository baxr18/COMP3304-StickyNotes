using System;
using System.Collections.Generic;

namespace StickyNotes
{
    internal class NoteData : INoteData, ITextData
    {
        private IDictionary<int, DataElement> _data;

        public NoteData()
        {
            _data = new Dictionary<int, DataElement>();
        }

        public void AddItem(int nextNoteKey)
        {
            DataElement element = new DataElement();

            _data.Add(nextNoteKey, element);
        }

        public void ChangeText(int key, String newText)
        {
            _data[key].ChangeText(newText);
        }

        public void RemoveItem(int noteKey)
        {
            _data[noteKey].Dispose();
            _data.Remove(noteKey);
        }

        public string RetrieveText(int key)
        {
            return _data[key].RetrieveText();
        }
    }
}