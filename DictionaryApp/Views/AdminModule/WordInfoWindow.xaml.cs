using DictionaryApp.Entities;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace DictionaryApp.Views.AdminModule
{ 
    public partial class WordInfoWindow : Window
    {
        public WordInfoWindow(Window parent, string word)
        {
            Owner = parent;
            InitializeComponent();
            UpdateWordInfo(word);
        }

        private void UpdateWordInfo(string word)
        {
            Word searchedWord = App._repository.GetWordByName(word);
            if (!searchedWord.PicturePath.Equals("default"))
            {
                try
                {
                    // BitmapImage din filepath
                    BitmapImage bitmapImage = new BitmapImage(new Uri(searchedWord.PicturePath));

                    image.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la incarcarea imaginii: {ex.Message}", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            wordTb.Text = "Cuvant: " + searchedWord.WordName;
            descriptionTb.Text = "Descriere: " + searchedWord.Description;
            categoryTb.Text = "Categorie: " + searchedWord.Category;
        }
    }
}
