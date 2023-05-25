using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SocialNetwork.Models;
using SocialNetwork.Services;

namespace SocialNetwork.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        private readonly FriendMockDataStore _friendMockDataStore;

        public ObservableCollection<Friend> Friends { get; set; }

        public uint NumberOfFriends { get; set; }

        public FriendViewModel()
        {
            _friendMockDataStore = new FriendMockDataStore();
        }

        public void LoadFriends()
        {
            Friends = new ObservableCollection<Friend>(_friendMockDataStore.GerFriends());
            NumberOfFriends = (uint)Friends.Count();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}