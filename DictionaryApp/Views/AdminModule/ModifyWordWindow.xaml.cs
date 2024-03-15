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

            List<string> wordStrings = App._repository.GetAllWordNames();
            wordsListBox.ItemsSource = wordStrings;
        }

        private void wordsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedItem = (string)wordsListBox.SelectedItem;
            if (selectedItem != null)
            {
                WordModificationWindow wordModificationWindow = new WordModificationWindow(this, selectedItem);
                wordModificationWindow.ShowDialog();

                wordsListBox.SelectedItem = null;
                wordsListBox.ItemsSource = null;
                wordsListBox.ItemsSource = App._repository.GetAllWordNames();
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

        private void searchTb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
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
