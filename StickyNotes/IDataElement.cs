using System.Drawing;

namespace StickyNotes
{
    internal interface IDataElement
    {
        void Initialise(string text, Image image);

        Image RetriveImage();

        void ChangeText(string newText);
    }
}