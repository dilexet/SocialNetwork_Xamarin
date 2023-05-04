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
        }
    }
}