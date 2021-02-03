using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace StickyNotes
{
    internal class NoteData : INoteData, ITextData, IImageData
    {
        // DECLARE the dictionary that sticky note instances will be stored in
        private IDictionary<int, DataElement> _data;

        // DELCARE the path of the images folder
        private const string _imagePath = "..\\..\\FishAssets\\";

        // DECLARE a list that the images will be stored in
        private IList<String> _imageNames;

        // DECLARE the counter that will be used to cycle through each image in the list
        private int _counter = 0;

        /// <summary>
        /// INSTANTIATE new NoteData component
        /// </summary>
        public NoteData()
        {
            // SET the data variable for each sticky note instance
            _data = new Dictionary<int, DataElement>();

            // SET the images to the _imageNames list
            _imageNames = new List<String>(Directory.GetFiles(_imagePath));
        }

        /// <summary>
        /// ADD a new sticky note instance to the dictionary list, using a new ID key to identify it
        /// </summary>
        /// <param name="nextNoteKey"></param>
        public void AddItem(int nextNoteKey)
        {
            // INSTANSIATE a new element component for the sticky note
            DataElement element = new DataElement();

            // SET an image to the sticky note, using the CircularCounter method to alternate between images
            element.Initialise("", Bitmap.FromFile(Path.GetFullPath(_imageNames[CircularCounter(_imageNames.Count)])));

            // ADD the new sticky note to the dictionary, setting the note's ID key and data
            _data.Add(nextNoteKey, element);
        }

        /// <summary>
        /// UPDATE _counter whenever a new sticky note instance is declared
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private int CircularCounter(int count)
        {
            // ADD 1 to _counter each time method is called
            _counter++;

            // CHECK if _counter reaches the count of images in _imageNames, and reset to 0 if so
            if (_counter == count)
            {
                _counter = 0;
            }
            return _counter;
        }

        /// <summary>
        /// UPDATE the text of a sticky note instance
        /// </summary>
        /// <param name="key"></param>
        /// <param name="newText"></param>
        public void ChangeText(int key, String newText)
        {
            // UPDATE the text of a sticky note based on the ID key of the instance
            _data[key].ChangeText(newText);
        }

        /// <summary>
        /// REMOVE a sticky note instance from the dictionary
        /// </summary>
        /// <param name="noteKey"></param>
        public void RemoveItem(int noteKey)
        {
            // REMOVE the sticky note based on the ID key of the instance
            _data[noteKey].Dispose();

            // REMOVE the ID key associated with the instance
            _data.Remove(noteKey);
        }

        /// <summary>
        /// RETRIEVE the text stored within a sticky note instance based on its ID
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string RetrieveText(int key)
        {
            // RETURN the text of the sticky note back to StickyNotes
            return _data[key].RetrieveText();
        }

        /// <summary>
        /// RETRIEVE the image stored within a sticky note instance based on its ID
        /// </summary>
        /// <param name="nextNoteKey"></param>
        /// <returns></returns>
        public Image RetrieveImage(int nextNoteKey)
        {
            // RETURN the image of the sticky note back to StickyNotes
            return _data[nextNoteKey].RetrieveImage();
        }
    }
}