using DictionaryApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace DictionaryApp.Repository
{
    public class Repo
    {
        private List<Word> _words;
        private List<Account> _accounts;
        private List<string> _categories;
        private readonly string _accountsFilePath = "C:\\MY_CODE\\MY Projects\\C#\\DictionaryApp\\Resources\\Accounts.json";
        private readonly string _wordsFilePath = "C:\\MY_CODE\\MY Projects\\C#\\DictionaryApp\\Resources\\Words.json";
        private readonly string _categoriesFilePath = "C:\\MY_CODE\\MY Projects\\C#\\DictionaryApp\\Resources\\Categories.txt";

        public Repo()
        {
            _words = new List<Word>();
            _accounts = new List<Account>();
            _categories = new List<string>();
            LoadAccountsFromJson();
            LoadWordsFromJson();
            LoadCategoriesFromFile();

            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
        }

        public List<string> GetSuggestions(string searchedText, string category = "")
        {
            List<string> suggestions = new List<string>();

            if (string.IsNullOrEmpty(category))
            {
                foreach (Word word in _words)
                {
                    if (word.WordName.StartsWith(searchedText))
                    {
                        suggestions.Add(word.WordName);
                    }
                }
            }
            else
            {
                foreach (Word word in _words)
                {
                    if (word.WordName.StartsWith(searchedText) && word.Category.Equals(category))
                    {
                        suggestions.Add(word.WordName);
                    }
                }
            }

            return suggestions;
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            SaveAccountsToJson();
            SaveWordsToJson();
            SaveCategoriesToFile();
        }

        public List<Word> Words
        {
            get { return _words; }
            set { _words = value; }
        }

        public List<Account> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }

        public List<string> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        public void AddCategory(string category)
        {
            _categories.Add(category);
        }

        // Create operation
        public void AddWord(Word word)
        {
            _words.Add(word);
        }

        // Read operation
        public Word GetWordByName(string wordName)
        {
            foreach (Word word in _words)
            {
                if (word.WordName == wordName)
                {
                    return word;
                }
            }
            return null;
        }

        // Update operation
        public void UpdateWord(string wordName, Word updatedWord)
        {
            Word wordToUpdate = GetWordByName(wordName);
            if (wordToUpdate != null)
            {
                wordToUpdate.WordName = updatedWord.WordName;
                wordToUpdate.Description = updatedWord.Description;
                wordToUpdate.Category = updatedWord.Category;
                wordToUpdate.PicturePath = updatedWord.PicturePath;
            }
        }

        // Delete operation
        public void DeleteWord(string wordName)
        {
            Word wordToDelete = GetWordByName(wordName);
            if (wordToDelete != null)
            {
                _words.Remove(wordToDelete);
            }
        }

        private void LoadAccountsFromJson()
        {
            if (File.Exists(_accountsFilePath))
            {
                string json = File.ReadAllText(_accountsFilePath);
                _accounts = JsonSerializer.Deserialize<List<Account>>(json);
            }
        }

        private void LoadWordsFromJson()
        {
            if (File.Exists(_wordsFilePath))
            {
                string json = File.ReadAllText(_wordsFilePath);
                _words = JsonSerializer.Deserialize<List<Word>>(json);
            }
        }
        private void SaveAccountsToJson()
        {
            string json = JsonSerializer.Serialize(_accounts);
            File.WriteAllText(_accountsFilePath, json);
        }

        private void SaveWordsToJson()
        {
            string json = JsonSerializer.Serialize(_words);
            File.WriteAllText(_wordsFilePath, json);
        }

        public bool AccountExists(string username, string password)
        {
            foreach (Account account in _accounts)
            {
                if (account.Username == username && account.Password == password)
                    return true;
            }

            return false;
        }


        private void LoadCategoriesFromFile()
        {
            StreamReader reader = new StreamReader(_categoriesFilePath);
            string noCatString = reader.ReadLine();
            if (int.TryParse(noCatString, out int noCat))
            {
                for (int i = 0; i < noCat; i++)
                {
                    _categories.Add(reader.ReadLine());
                }
            }

            reader.Close();
        }

        private void SaveCategoriesToFile()
        {
            StreamWriter writer = new StreamWriter(_categoriesFilePath);
            writer.WriteLine(_categories.Count);
            for (int i = 0; i < _categories.Count; i++)
            {
                writer.WriteLine(_categories[i]);
            }

            writer.Close();
        }
    }
}
