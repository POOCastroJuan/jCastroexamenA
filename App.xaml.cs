using jCastroexamenA.Views;

namespace jCastroexamenA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new vLogin());
        }

    }
}