namespace StickyNotes
{
    public interface INoteData
    {
        /// <summary>
        /// REMOVE a sticky note from the dictionary when the 'Close' button is clicked, using its ID
        /// </summary>
        /// <param name="noteKey"></param>
        void RemoveItem(int noteKey);

        /// <summary>
        /// ADD a new sticky note instance to the dictionary with its unique ID
        /// </summary>
        /// <param name="nextNoteKey"></param>
        void AddItem(int nextNoteKey);
    }
}