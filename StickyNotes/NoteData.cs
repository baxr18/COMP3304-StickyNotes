using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace StickyNotes
{
    internal class NoteData : INoteData, ITextData, IImageData
    {
        private IDictionary<int, DataElement> _data;

        private const string _imagePath = "..\\..\\FishAssets\\";

        private IList<String> _imageNames;

        private int _counter = 0;

        public NoteData()
        {
            _data = new Dictionary<int, DataElement>();

            _imageNames = new List<String>(Directory.GetFiles(_imagePath));
        }

        public void AddItem(int nextNoteKey)
        {
            DataElement element = new DataElement();

            element.Initialise("", Bitmap.FromFile(Path.GetFullPath(_imageNames[CircularCounter(_imageNames.Count)])));

            _data.Add(nextNoteKey, element);
        }

        private int CircularCounter(int count)
        {
            _counter++;
            if (_counter == count)
            {
                _counter = 0;
            }
            return _counter;
        }

        public void ChangeText(int key, String newText)
        {
            _data[key].ChangeText(newText);
        }

        public void RemoveItem(int noteKey)
        {
            _data[noteKey].Dispose();
            _data.Remove(noteKey);
        }

        public string RetrieveText(int key)
        {
            return _data[key].RetrieveText();
        }

        public Image RetrieveImage(int nextNoteKey)
        {
            return _data[nextNoteKey].RetrieveImage();
        }
    }
}