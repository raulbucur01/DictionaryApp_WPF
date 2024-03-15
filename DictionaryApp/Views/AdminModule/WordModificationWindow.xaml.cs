using DictionaryApp.Entities;
using Microsoft.Win32;
using System.Windows;

namespace DictionaryApp.Views.AdminModule
{

    public partial class WordModificationWindow : Window
    {
        private static string _picturePath = "default";
        private static string _wordToModify;
        public WordModificationWindow(Window parent, string wordToModify)
        {
            Owner = parent;
            InitializeComponent();

            _wordToModify = wordToModify;
            // obiectul Word pe care vrem sa il modificam
            Word wordObjectToModify = App._repository.GetWordByName(wordToModify);

            // punem datele obiectului Word in casute
            greetingLabel.Content = $"Modificati cuvantul '{wordObjectToModify.WordName}'";

            wordTb.Text = wordObjectToModify.WordName;
            descriptionTb.Text = wordObjectToModify.Description;

            categoryCb.Items.Clear();
            categoryCb.ItemsSource = App._repository.Categories;
            categoryCb.SelectedItem = wordObjectToModify.Category;

            _picturePath = wordObjectToModify.PicturePath;
        }

        private void saveChangesBtn_Click(object sender, RoutedEventArgs e)
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
                string newWordName = wordTb.Text;
                string newDescription = descriptionTb.Text;
                string newCategory = categoryCb.SelectedItem as string;
                string newSelectedPictureFilePath = _picturePath;


                Word updatedWord = new Word(newWordName, newDescription, newCategory, newSelectedPictureFilePath);

                if (newWordName != _wordToModify)
                {
                    if (App._repository.WordNameExists(updatedWord.WordName))
                    {
                        MessageBox.Show("Cuvantul exista deja!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        App._repository.UpdateWord(_wordToModify, updatedWord);

                        MessageBox.Show("Cuvant modificat cu succes!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                        Close();
                    }
                }
                else
                {
                    if (App._repository.WordExists(updatedWord))
                    {
                        MessageBox.Show("Cuvantul exista deja!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        App._repository.UpdateWord(_wordToModify, updatedWord);

                        MessageBox.Show("Cuvant modificat cu succes!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                        Close();
                    }

                }
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
