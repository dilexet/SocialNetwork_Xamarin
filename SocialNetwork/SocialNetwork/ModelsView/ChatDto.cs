using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SocialNetwork.ModelsView
{
    public class ChatDto
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public Uri ProfileImageUri { get; set; }

        public string LastMessageText { get; set; }

        public string LastMessageDate { get; set; }

        public uint NumberOfUnreadMessages { get; set; }

        public ObservableCollection<MessageGroup<string, MessageDto>> Messages { get; set; }
    }
}