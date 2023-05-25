using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SocialNetwork.ModelsView;
using SocialNetwork.Services;

namespace SocialNetwork.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        private readonly ChatsMockDataStore _chatsMockDataStore;

        public ObservableCollection<ChatDto> Chats { get; set; }

        public ChatViewModel()
        {
            _chatsMockDataStore = ChatsMockDataStore.GetInstance();
        }

        public async Task LoadChats()
        {
            Chats = new ObservableCollection<ChatDto>(await _chatsMockDataStore.GetChats());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}