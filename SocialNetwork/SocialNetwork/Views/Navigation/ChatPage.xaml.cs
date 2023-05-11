using System;
using SocialNetwork.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialNetwork.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ChatId), nameof(ChatId))]
    public partial class ChatPage : ContentPage
    {
        private readonly ChatsMockDataStore _chatsMockDataStore;

        public string ChatId
        {
            set => LoadChat(value);
        }

        public ChatPage()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
            _chatsMockDataStore = ChatsMockDataStore.GetInstance();
        }

        private void LoadChat(string value)
        {
            Guid id = Guid.Parse(value);
            var chat = _chatsMockDataStore.GetChatById(id);
            BindingContext = chat;
        }

        private void MessageText_OnTextChanged(object sender, EventArgs e)
        {
        }
    }
}