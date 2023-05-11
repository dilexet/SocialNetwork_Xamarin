using SocialNetwork.Views.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            SetNavBarIsVisible(this, false);
            Routing.RegisterRoute(nameof(ChatPage), typeof(ChatPage));
        }
    }
}