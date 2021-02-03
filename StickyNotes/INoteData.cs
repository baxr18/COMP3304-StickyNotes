namespace StickyNotes
{
    public interface INoteData
    {
        void RemoveItem(int noteKey);
        void AddItem(int nextNoteKey);
    }
}