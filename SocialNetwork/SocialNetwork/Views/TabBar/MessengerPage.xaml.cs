using System.Linq;
using SocialNetwork.ModelsView;
using SocialNetwork.Services;
using SocialNetwork.Views.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.TabBar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessengerPage : ContentPage
    {
        private readonly ChatsMockDataStore _chatsMockDataStore;

        public MessengerPage()
        {
            InitializeComponent();
            _chatsMockDataStore = ChatsMockDataStore.GetInstance();
        }

        protected async override void OnAppearing()
        {
            ChatsView.ItemsSource = await _chatsMockDataStore.GetChats();
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