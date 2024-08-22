using P6TravelsAPP_MiguelC;
using P6TravelsAPP_MiguelC.Views;


namespace P6TravelsAPP_MiguelC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
