using DictionaryApp.Views.AdminModule;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DictionaryApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            categoriesCb.ItemsSource = App._repository.Categories;
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(this);
            loginWindow.ShowDialog();
        }

        private void searchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(searchTb.Text))
            {
                suggestionsScrollViewer.Visibility = Visibility.Hidden;
                suggestionsListBox.Visibility = Visibility.Hidden;   
            }
            else if (!string.IsNullOrEmpty(searchTb.Text) && !searchTb.Text.Equals("Cautati un cuvant..."))
            {
                string searchedText = searchTb.Text;

                if (categoriesCb.SelectedIndex == 0) 
                { 
                    List<string> suggestions = App._repository.GetSuggestions(searchedText);
                    suggestionsScrollViewer.Visibility = Visibility.Visible;
                    suggestionsListBox.Visibility = Visibility.Visible;
                    suggestionsListBox.ItemsSource = suggestions;   
                }
                else
                {
                    List<string> suggestions = App._repository.GetSuggestions(searchedText, categoriesCb.SelectedItem.ToString());
                    suggestionsScrollViewer.Visibility = Visibility.Visible;
                    suggestionsListBox.Visibility = Visibility.Visible;
                    suggestionsListBox.ItemsSource = suggestions;
                }
            }
        }

        private void categoriesCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTb.Text)) {
                if (categoriesCb.SelectedIndex == 0)
                {
                    string searchedText = searchTb.Text;

                    List<string> suggestions = App._repository.GetSuggestions(searchedText);
                    suggestionsScrollViewer.Visibility = Visibility.Visible;
                    suggestionsListBox.Visibility = Visibility.Visible;
                    suggestionsListBox.ItemsSource = suggestions;
                }
                else
                {
                    string searchedText = searchTb.Text;

                    List<string> suggestions = App._repository.GetSuggestions(searchedText, categoriesCb.SelectedItem.ToString());
                    suggestionsScrollViewer.Visibility = Visibility.Visible;
                    suggestionsListBox.Visibility = Visibility.Visible;
                    suggestionsListBox.ItemsSource = suggestions;
                }
            }
        }

        private void suggestionsScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                suggestionsScrollViewer.LineUp();
            }
            else
            {
                suggestionsScrollViewer.LineDown();
            }

            e.Handled = true;
        }

        private void suggestionsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)suggestionsListBox.SelectedItem;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                WordInfoWindow wordInfoWindow = new WordInfoWindow(this, selectedItem);
                wordInfoWindow.Show();
                suggestionsListBox.SelectedItem = null;
            }
        }
    }
}
