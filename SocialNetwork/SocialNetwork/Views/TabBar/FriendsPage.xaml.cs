using System;
using SocialNetwork.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.TabBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendsPage : ContentPage
    {
        public FriendsPage()
        {
            InitializeComponent();
            var friendViewModel = new FriendViewModel();
            friendViewModel.LoadFriends();
            BindingContext = friendViewModel;
        }

        private void MaterialFloatingButton_OnClicked(object sender, EventArgs e)
        {
            
        }

        private void ToChatButton_OnClicked(object sender, EventArgs e)
        {
        }
    }
}