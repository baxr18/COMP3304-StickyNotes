using System;
using System.Drawing;

namespace StickyNotes
{
    internal class DataElement : IDataElement
    {
        private String _text;

        private Image _image;

        public void Initialise(String text, Image image)
        {
            _text = text;
            _image = image;
        }

        public void ChangeText(String newText)
        {
            _text = newText;
        }

        public String RetrieveText()
        {
            return _text;
        }

        public Image RetrieveImage()
        {
            return _image;
        }

        internal void Dispose()
        {
            _image.Dispose();
        }
    }
}