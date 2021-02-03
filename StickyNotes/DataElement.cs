using System;
using System.Drawing;

namespace StickyNotes
{
    internal class DataElement : IDataElement
    {
        // DECLARE the text for each sticky note
        private String _text;

        // DELCARE the image for each sticky note
        private Image _image;

        /// <summary>
        /// INITIALISE each new sticky note instance
        /// </summary>
        /// <param name="text"></param>
        /// <param name="image"></param>
        public void Initialise(String text, Image image)
        {
            // SET the text and image of each sticky note
            _text = text;
            _image = image;
        }

        /// <summary>
        /// UPDATE the text of a sticky note
        /// </summary>
        /// <param name="newText"></param>
        public void ChangeText(String newText)
        {
            // REPLACE the original text in the sticky note with the updated text
            _text = newText;
        }

        /// <summary>
        /// RETRIEVE the text of a sticky note instance
        /// </summary>
        /// <returns></returns>
        public String RetrieveText()
        {
            // RETURN the text back to the NoteData class
            return _text;
        }

        /// <summary>
        /// RETRIEVE the image of a sticky note instance
        /// </summary>
        /// <returns></returns>
        public Image RetrieveImage()
        {
            // RETURN the image back to the NoteData class
            return _image;
        }

        /// <summary>
        /// DELETE the image associated with a disposed sticky note
        /// </summary>
        internal void Dispose()
        {
            // DELETE sticky note image, thus freeing up memory resources
            _image.Dispose();
        }
    }
}