using DictionaryApp.Entities;
using System.Collections.Generic;
using System.Windows;

namespace DictionaryApp.Views.AdminModule
{
    public partial class DeleteWordWindow : Window
    {
        private List<string> _wordStrings;
        public DeleteWordWindow(Window owner)
        {
            Owner = owner;
            InitializeComponent();

            List<Word> words = App._repository.Words;

            _wordStrings = new List<string>();
            foreach (Word word in words)
            {
                _wordStrings.Add(word.WordName);
            }
            wordsListBox.ItemsSource = _wordStrings;
        }

        private void wordsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedItem = (string)wordsListBox.SelectedItem;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                MessageBoxResult result = MessageBox.Show($"Esti sigur ca vrei sa stergi cuvantul '{selectedItem}'?",
                                          "Confirmare stergere", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    App._repository.DeleteWord(selectedItem);
                    MessageBox.Show($"Cuvantul '{selectedItem}' a fost sters cu success!",
                                    "Stergere cu success", MessageBoxButton.OK, MessageBoxImage.Information);
                        
                    // scoatem din lista
                    _wordStrings.Remove(selectedItem);
                    // reinitializam ItemsSource pt a updata lista
                    wordsListBox.ItemsSource = null;
                    wordsListBox.ItemsSource = _wordStrings;
                }
            }
        }

        private void wordsListBox_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                wordsListScrollViewer.LineUp();
            }
            else
            {
                wordsListScrollViewer.LineDown();
            }

            e.Handled = true;
        }
    }
}
