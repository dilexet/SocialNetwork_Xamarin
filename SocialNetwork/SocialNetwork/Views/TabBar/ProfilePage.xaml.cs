using SocialNetwork.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.TabBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            var profileViewModel = new ProfileViewModel();
            await profileViewModel.LoadProfile();
            BindingContext = profileViewModel;
            base.OnAppearing();
        }
    }
}