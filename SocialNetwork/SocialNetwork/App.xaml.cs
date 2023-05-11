using SocialNetwork.Views.Authorize;
using Xamarin.Forms;

namespace SocialNetwork
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        private bool IsAuth()
        {
            return true;
        }

        protected override void OnStart()
        {
            if (IsAuth())
            {
                MainPage = new AppShell();
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}