using System;
using System.Collections.Generic;

namespace SocialNetwork.Models
{
    public class Chat
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public Uri ProfileImageUri { get; set; }

        public string LastMessageText { get; set; }

        public DateTime LastMessageDate { get; set; }

        public uint NumberOfUnreadMessages { get; set; }

        public IEnumerable<Message> Messages { get; set; }
    }
}