using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SocialNetwork.ModelsView;
using SocialNetwork.Services;

namespace SocialNetwork.ViewModels
{
    public class MessageViewModel : INotifyPropertyChanged
    {
        private readonly ChatsMockDataStore _chatsMockDataStore;

        public ChatDto Chat { get; set; }

        public MessageViewModel()
        {
            _chatsMockDataStore = ChatsMockDataStore.GetInstance();
        }

        public void LoadMessages(Guid id)
        {
            Chat = _chatsMockDataStore.GetChatById(id);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}