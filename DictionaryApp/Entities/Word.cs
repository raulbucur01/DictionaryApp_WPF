using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Word other = (Word)obj;
            return WordName == other.WordName && 
                   Description == other.Description &&
                   Category == other.Category &&
                   PicturePath == other.PicturePath;
        }

        public override int GetHashCode()
        {
            int hashCode = -1150115036;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_wordName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_category);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_picturePath);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WordName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Category);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PicturePath);
            return hashCode;
        }
    }
}

