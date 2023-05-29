using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SocialNetwork.Models;
using SocialNetwork.ModelsView;
using SocialNetwork.Services;

namespace SocialNetwork.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        public Profile Profile { get; set; }

        public uint NumberOfFriends { get; set; }

        public IList<Uri> FriendsImagUri { get; set; }

        private readonly NewsMockDataStore _newsMockDataStore;

        private readonly FriendMockDataStore _friendMockDataStore;

        public ProfileViewModel()
        {
            _newsMockDataStore = new NewsMockDataStore();
            _friendMockDataStore = new FriendMockDataStore();
        }

        public async Task LoadProfile()
        {
            Profile = new Profile()
            {
                Id = Guid.NewGuid(),
                ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                Username = "Arkadiy Paravozov",
                CityFrom = "Lalalend",
                Friends = new ObservableCollection<Friend>(_friendMockDataStore.GerFriends()),
                News = new ObservableCollection<NewsDto>(await _newsMockDataStore.GetNews())
            };

            NumberOfFriends = (uint)Profile.Friends.Count;
            FriendsImagUri = Profile.Friends.Take(3).Select(x => x.ProfileImageUri).ToList();
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