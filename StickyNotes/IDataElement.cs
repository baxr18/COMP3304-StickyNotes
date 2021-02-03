using System;
using System.Drawing;

namespace StickyNotes
{
    internal interface IDataElement
    {
        void Initialise(String text, Image image);

        Image RetrieveImage();

        void ChangeText(String newText);

        String RetrieveText();
    }
}