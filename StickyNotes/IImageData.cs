using System.Drawing;

namespace StickyNotes
{
    internal interface IImageData
    {
        /// <summary>
        /// RETRIEVE the image of a sticky note instance based on its ID
        /// </summary>
        /// <param name="nextNoteKey"></param>
        /// <returns></returns>
        Image RetrieveImage(int nextNoteKey);
    }
}