using DictionaryApp.Entities;
using System.Collections.Generic;
using System.Windows;

namespace DictionaryApp.Views.AdminModule
{
    public partial class ModifyWordWindow : Window
    {
        private List<string> _wordStrings;
        public ModifyWordWindow(Window parent)
        {
            Owner = parent;
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
            if (selectedItem != null)
            {
                WordModificationWindow wordModificationWindow = new WordModificationWindow(this, selectedItem);
                wordModificationWindow.ShowDialog();

                wordsListBox.SelectedItem = null;
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
