using System.Windows;

namespace DictionaryApp.Views.AdminModule
{
    public partial class AdminMenuWindow : Window
    {
        public AdminMenuWindow(Window parent, string username)
        {
            Owner = parent;
            InitializeComponent();


            greetingTextBlock.Text = "Salut administrator, " + username + "!";
        }

        private void addWordBtn_Click(object sender, RoutedEventArgs e)
        {
            AddWordWindow addWordWindow = new AddWordWindow(this);
            addWordWindow.ShowDialog();
        }

        private void showWordsBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWordsWindow showWordsWindow = new ShowWordsWindow(this);
            showWordsWindow.ShowDialog();
        }

        private void modifyWordBtn_Click(object sender, RoutedEventArgs e)
        {
            ModifyWordWindow modifyWordWindow = new ModifyWordWindow(this);
            modifyWordWindow.ShowDialog();
        }

        private void deleteWordBtn_Click(object sender, RoutedEventArgs e)
        {
           DeleteWordWindow deleteWordWindow = new DeleteWordWindow(this);
           deleteWordWindow.ShowDialog();
        }
    }
}
