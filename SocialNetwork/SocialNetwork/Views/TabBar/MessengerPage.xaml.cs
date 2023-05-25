using System.Linq;
using SocialNetwork.ModelsView;
using SocialNetwork.Services;
using SocialNetwork.ViewModels;
using SocialNetwork.Views.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.TabBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessengerPage : ContentPage
    {

        public MessengerPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            var chatViewModel = new ChatViewModel();
            await chatViewModel.LoadChats();
            BindingContext = chatViewModel;
            base.OnAppearing();
        }

        private async void ChatsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChatDto chat = (ChatDto)e.CurrentSelection?.FirstOrDefault();
            if (chat != null)
            {
                await Shell.Current.GoToAsync(
                    $"{nameof(ChatPage)}?{nameof(ChatPage.ChatId)}={chat.Id.ToString()}");
            }
        }
    }
}