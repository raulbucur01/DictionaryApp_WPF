using DictionaryApp.Entities;
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
            
            List<Word> words = App._repository.Words;

            List<string> wordStrings = new List<string>();
            foreach (Word word in words)
            {
                wordStrings.Add(word.WordName);
            }
            wordsListBox.ItemsSource = wordStrings;
        }

        private void wordsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (wordsListBox.SelectedItem != null)
            {
                string word = wordsListBox.SelectedItem.ToString();

                WordInfoWindow wordInfoWindow = new WordInfoWindow(this, word);
                wordInfoWindow.Show();
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
