using DictionaryApp.Entities;
using Microsoft.Win32;
using System;
using System.Windows;

namespace DictionaryApp.Views.AdminModule
{
    public partial class AddWordWindow : Window
    {
        private static string _picturePath = "default";
        public AddWordWindow(Window parent)
        {
            Owner = parent;
            InitializeComponent();

            categoryCb.Items.Clear();
            categoryCb.ItemsSource = App._repository.Categories;
        }

        private void addWordBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(wordTb.Text)
                || string.IsNullOrWhiteSpace(descriptionTb.Text))
            {
                MessageBox.Show("Va rugam sa introduceti un cuvant si o descriere.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (categoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Va rugam sa alegeti o categorie.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string wordName = wordTb.Text;
                string description = descriptionTb.Text;
                string category = categoryCb.SelectedItem as string;
                string selectedPictureFilePath = _picturePath;

                Word wordToAdd = new Word(wordName, description, category, selectedPictureFilePath);

                App._repository.AddWord(wordToAdd);
                MessageBox.Show("Cuvant adaugat cu succes!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                wordTb.Clear();
                descriptionTb.Clear();
                categoryCb.SelectedIndex = -1;
                _picturePath = "default";

                Close();
            }
        }

        private void photoSelectBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "C:\\MY_CODE\\MY Projects\\C#\\DictionaryApp\\Resources\\";

            if (openFileDialog.ShowDialog() == true)
            {
                if (openFileDialog.FileName != null)
                {
                    _picturePath = openFileDialog.FileName;
                    MessageBox.Show("Imagine selectata: \n" + _picturePath, "Imagine selectata cu succes", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Imaginea nu s-a putut selecta!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void newCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            NewCategoryWindow newCategoryWindow = new NewCategoryWindow(this);
            bool? result = newCategoryWindow.ShowDialog();
            if (result == true)
            {
                // luam numele categoriei noi din window
                string newCategoryName = newCategoryWindow.NewCategoryName;

                // adaugam noua categorie la repo
                App._repository.AddCategory(newCategoryName);

                // selectam ca aleasa noua categorie
                categoryCb.SelectedItem = newCategoryName;
            }
        }
    }
}
