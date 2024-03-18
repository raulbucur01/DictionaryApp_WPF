using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DictionaryApp.Views.AdminModule
{
    public partial class ShowWordsWindow : Window
    {
        public ShowWordsWindow(Window parent)
        {
            Owner = parent;
            InitializeComponent();

            List<string> wordStrings = App._repository.GetAllWordNames();
            wordsListBox.ItemsSource = wordStrings;
        }

        private void wordsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (wordsListBox.SelectedItem != null)
            {
                string word = wordsListBox.SelectedItem.ToString();

                WordInfoWindow wordInfoWindow = new WordInfoWindow(this, word);
                wordInfoWindow.Show();
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

        private void searchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTb.Text))
            {
                string searchedText = searchTb.Text;

                List<string> suggestions = App._repository.GetSuggestions(searchedText);

                wordsListBox.ItemsSource = suggestions;
            }
            else
            {
                wordsListBox.ItemsSource = App._repository.GetAllWordNames();
            }
        }
    }
}
