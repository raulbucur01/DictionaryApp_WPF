using DictionaryApp.Repository;
using System.Windows;

namespace DictionaryApp
{

    public partial class App : Application
    {
        public static Repo _repository { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _repository = new Repo();
        }

    }
}
