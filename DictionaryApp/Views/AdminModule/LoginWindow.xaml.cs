using System.Windows;

namespace DictionaryApp.Views.AdminModule
{
    public partial class LoginWindow : Window
    {
        public LoginWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordBox.Password;

            bool isValidLogin = App._repository.AccountExists(username, password);

            if (!isValidLogin)
            {
                MessageBox.Show("Username sau parola invalide. Incearca din nou.", "Login esuat", MessageBoxButton.OK, MessageBoxImage.Error);
                usernameTb.Clear();
                passwordBox.Clear();
            }
            else
            {
                AdminMenuWindow adminMenuWindow = new AdminMenuWindow(this, username);
                adminMenuWindow.ShowDialog();
            }
        }
    }
}
