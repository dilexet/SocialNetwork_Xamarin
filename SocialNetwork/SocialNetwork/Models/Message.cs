using System;

namespace SocialNetwork.Models
{
    public class Message
    {
        public Guid Id { get; set; }

        public Guid ChatId { get; set; }

        public Guid SenderId { get; set; }

        public string Text { get; set; }

        public DateTime DateMessageSent { get; set; }
    }
}