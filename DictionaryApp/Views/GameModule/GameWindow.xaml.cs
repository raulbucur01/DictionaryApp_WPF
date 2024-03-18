using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace DictionaryApp.Views.GameModule
{
    public partial class GameWindow : Window
    {
        private int round = 1;
        private string crtAnswer = null;
        private int correctAnsweredAmount = 0;
        private List<int> alreadySelectedIndexes;
        public GameWindow(Window parent)
        {
            Owner = parent;
            InitializeComponent();

            alreadySelectedIndexes = new List<int>();
        }

        private void HandleClueRetrieval()
        {
            (string clueToDisplay, int type, string answer, int newIndex) = App._repository.GetRandomPicturePathOrDescriptionAndAnswer(alreadySelectedIndexes);

            crtAnswer = answer;
            alreadySelectedIndexes.Add(newIndex);

            if (type == 1)
            {
                clueImage.Visibility = Visibility.Collapsed;
                clueTblock.Visibility = Visibility.Visible;
                clueRectangle.Visibility = Visibility.Visible;
                clueTblock.Text = clueToDisplay;
            }
            else
            {
                clueTblock.Visibility = Visibility.Collapsed;
                clueRectangle.Visibility = Visibility.Collapsed;
                clueImage.Visibility = Visibility.Visible;
                BitmapImage bitmapImage = new BitmapImage(new Uri(clueToDisplay));

                clueImage.Source = bitmapImage;
            }
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            startStackPanel.Visibility = Visibility.Collapsed;
            gameGrid.Visibility = Visibility.Visible;

            round = 1;
            correctAnsweredAmount = 0;
            HandleClueRetrieval();
        }

        private void verifyBtn_Click(object sender, RoutedEventArgs e)
        {
            string guess = guessTb.Text;
            if (string.IsNullOrEmpty(guess))
            {
                MessageBox.Show("Nu ati introdus nimic in casuta de ghicit. Incearca din nou.", "Verificare esuata",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (crtAnswer.Equals(guess))
                {
                    nextBtn.IsEnabled = true;
                    verifyBtn.IsEnabled = false;
                    amountGuessedLabel.Content = $"Ghicite: {++correctAnsweredAmount}/5";
                    MessageBox.Show("RASPUNS CORECT!", " Raspuns corect",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    nextBtn.IsEnabled = true;
                    verifyBtn.IsEnabled = false;
                    MessageBox.Show($"Raspuns gresit. Raspunsul corect era: {crtAnswer}", "Corect",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            verifyBtn.IsEnabled = true;
            clueImage.Visibility = Visibility.Collapsed;
            clueTblock.Visibility = Visibility.Collapsed;
            guessTb.Text = null;
            round++;

            if (round > 5)
            {
                gameGrid.Visibility = Visibility.Collapsed;
                finishGrid.Visibility = Visibility.Visible;
                resultLabel.Content = $"Jocul s-a incheiat. Ai ghicit: {correctAnsweredAmount}/5";
                alreadySelectedIndexes.Clear();
            }
            else
            {
                nextBtn.IsEnabled = false;
                roundLabel.Content = $"Runda: {round}";

                HandleClueRetrieval();
            }
        }

        private void restartBtn_Click(object sender, RoutedEventArgs e)
        {
            finishGrid.Visibility = Visibility.Collapsed;
            gameGrid.Visibility = Visibility.Visible;
            round = 1;
            correctAnsweredAmount = 0;
            amountGuessedLabel.Content = $"Ghicite: {correctAnsweredAmount}/5";
            roundLabel.Content = $"Runda: {round}";

            HandleClueRetrieval();
        }
    }
}
