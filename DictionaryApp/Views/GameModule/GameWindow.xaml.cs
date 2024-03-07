using System.Windows;

namespace DictionaryApp.Views.GameModule
{
    public partial class GameWindow : Window
    {
        public GameWindow(Window parent)
        {
            Owner = parent;
            InitializeComponent();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            startStackPanel.Visibility = Visibility.Collapsed;
            gameGrid.Visibility = Visibility.Visible;
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void verifyBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
