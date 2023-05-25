using System;

namespace SocialNetwork.Models
{
    public class Friend
    {
        public Guid Id { get; set; }

        public string Username { get; set; }
        
        public Uri ProfileImageUri { get; set; }

        public ushort Age { get; set; }
        
        public string CityFrom { get; set; }
    }
}