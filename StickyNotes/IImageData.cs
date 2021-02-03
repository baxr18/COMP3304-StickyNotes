using System.Drawing;

namespace StickyNotes
{
    internal interface IImageData
    {
        Image RetrieveImage(int nextNoteKey);
    }
}