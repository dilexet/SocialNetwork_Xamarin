using System;
using System.Collections.ObjectModel;
using SocialNetwork.ModelsView;

namespace SocialNetwork.Models
{
    public class Profile
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public Uri ProfileImageUri { get; set; }

        public string CityFrom { get; set; }

        public ObservableCollection<Friend> Friends { get; set; }

        public ObservableCollection<NewsDto> News { get; set; }
    }
}