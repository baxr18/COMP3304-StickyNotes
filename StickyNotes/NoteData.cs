using System.Collections.Generic;

namespace StickyNotes
{
    internal class NoteData : INoteData
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

        public void RemoveItem(int noteKey)
        {
            _data[noteKey].Dispose();
            _data.Remove(noteKey);
        }
    }
}