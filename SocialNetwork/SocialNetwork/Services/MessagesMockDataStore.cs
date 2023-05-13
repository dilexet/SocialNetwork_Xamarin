using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SocialNetwork.Models;
using SocialNetwork.ModelsView;

namespace SocialNetwork.Services
{
    public class MessagesMockDataStore
    {
        private readonly IEnumerable<Message> _messages;

        public static Guid MyId = new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4");

        public MessagesMockDataStore()
        {
            var dateNow = DateTime.Now;
            var friendId = Guid.NewGuid();
            _messages = new List<Message>()
            {
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "Hello, how are you?",
                    DateMessageSent = dateNow.AddHours(-3)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Did you hear about the new movie coming out?",
                    DateMessageSent = dateNow.AddMonths(-1)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "I'm running a bit late, be there in 10 minutes.",
                    DateMessageSent = dateNow.AddHours(-2)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "Can you send me the report by the end of the day?",
                    DateMessageSent = dateNow.AddDays(-9)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "I'm sorry for the confusion earlier.",
                    DateMessageSent = dateNow.AddHours(-1)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Thanks for letting me know.",
                    DateMessageSent = dateNow.AddMinutes(-45)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "Have you seen the new restaurant that just opened?",
                    DateMessageSent = dateNow.AddHours(-1)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Can you give me a call when you get a chance?",
                    DateMessageSent = dateNow.AddMinutes(-15)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Just wanted to check in and see how things are going.",
                    DateMessageSent = dateNow.AddMinutes(-30)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "I'm not feeling well today, so I won't be able to come in.",
                    DateMessageSent = dateNow.AddDays(-3)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Sorry, I didn't catch what you said earlier. Can you repeat it?",
                    DateMessageSent = dateNow.AddMinutes(-50)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "I'm excited for the concert tonight!",
                    DateMessageSent = dateNow.AddHours(-8)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Just wanted to say thanks again for your help yesterday.",
                    DateMessageSent = dateNow.AddMinutes(-2)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = friendId,
                    Text = "Can we schedule a meeting for next week?",
                    DateMessageSent = dateNow.AddMinutes(-10)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "I'm looking forward to the long weekend.",
                    DateMessageSent = dateNow.AddMinutes(-5)
                }
            };
        }

        // public ObservableCollection<Grouping<string, MessageDto>> GetMessages()
        // {
        //     var groups = _messages
        //         .ToList()
        //         .GroupBy(x => x.DateMessageSent.Date)
        //         .Select(x =>
        //             new Grouping<string, MessageDto>(
        //                 x.Key.ToString("MMMM dd"),
        //                 x.Select(item => new MessageDto()
        //                 {
        //                     Id = item.Id,
        //                     SenderId = item.SenderId,
        //                     Text = item.Text,
        //                     DateMessageSent = item.DateMessageSent.ToString("HH:mm"),
        //                 })
        //             )
        //         );
        //
        //     return new ObservableCollection<Grouping<string, MessageDto>>(groups);
        // }

        public IEnumerable<MessageDto> GetMessages()
        {
            return _messages
                .ToList()
                .OrderByDescending(x => x.DateMessageSent)
                .Select(x => new MessageDto()
                {
                    Id = x.Id,
                    SenderId = x.SenderId,
                    Text = x.Text,
                    DateMessageSent = x.DateMessageSent.ToString("HH:mm")
                });
        }
    }
}