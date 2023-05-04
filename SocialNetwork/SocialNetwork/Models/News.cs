using System;

namespace SocialNetwork.Models
{
    public class News
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public Uri ProfileImageUri { get; set; }
        public DateTime DateCreated { get; set; }
        public string Text { get; set; }
        public Uri ImageUri { get; set; }
    }
}