using System;
using SocialNetwork.ViewModels;
using SocialNetwork.Views.TabBar;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ChatId), nameof(ChatId))]
    public partial class ChatPage : ContentPage
    {
        public string ChatId
        {
            set => LoadChat(value);
        }

        public ChatPage()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
        }

        private void LoadChat(string value)
        {
            Guid id = Guid.Parse(value);
            var messageViewModel = new MessageViewModel();
            messageViewModel.LoadMessages(id);
            BindingContext = messageViewModel;
        }

        private void MessageText_OnTextChanged(object sender, EventArgs e)
        {
        }

        private async void MaterialFloatingButton_OnClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(MessengerPage)}");
        }
    }
}