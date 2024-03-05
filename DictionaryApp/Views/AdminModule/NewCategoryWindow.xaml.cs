using System.Windows;

namespace DictionaryApp.Views.AdminModule
{
    public partial class NewCategoryWindow : Window
    {
        public string NewCategoryName { get; private set; }
        public NewCategoryWindow(Window parent)
        {
            Owner = parent;
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(categoryTb.Text))
            {
                MessageBox.Show("Va rugam sa introduceti o categorie.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                NewCategoryName = categoryTb.Text;
                DialogResult = true;
            }
        }


        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
