using System;

namespace DictionaryApp.Entities
{
    public class Word
    {
        // Private fields
        private string _wordName;
        private string _description;
        private string _category;
        private string _picturePath; // file path

        // Public properties
        public string WordName
        {
            get { return _wordName; }
            set { _wordName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string PicturePath
        {
            get { return _picturePath; }
            set { _picturePath = value; }
        }

        // Constructors
        public Word()
        {
        }

        public Word(string wordName, string description, string category, string picturePath)
        {
            WordName = wordName;
            Description = description;
            Category = category;
            PicturePath = picturePath;
        }
    }
}

