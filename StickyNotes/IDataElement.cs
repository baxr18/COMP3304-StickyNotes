using System;
using System.Drawing;

namespace StickyNotes
{
    internal interface IDataElement
    {
        /// <summary>
        /// INITIALISE the DataElement component(s)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="image"></param>
        void Initialise(String text, Image image);

        /// <summary>
        /// GET the image from a sticky note instance and pass it to the DataElement class
        /// </summary>
        /// <returns></returns>
        Image RetrieveImage();

        /// <summary>
        /// GET the changed text from a sticky note instance and pass it to the DataElement class
        /// </summary>
        /// <param name="newText"></param>
        void ChangeText(String newText);

        /// <summary>
        /// GET the text from a sticky note instance and pass it to the DataElement class
        /// </summary>
        /// <returns></returns>
        String RetrieveText();
    }
}