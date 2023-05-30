using System;
using System.Collections.Generic;
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
                    DateMessageSent = dateNow.AddYears(-1)
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
                    DateMessageSent = dateNow.AddYears(-2)
                },
                new Message
                {
                    Id = Guid.NewGuid(),
                    SenderId = MyId,
                    Text = "Thanks for letting me know.",
                    DateMessageSent = dateNow.AddMonths(-5)
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
                    DateMessageSent = dateNow.AddMonths(-5)
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
                    DateMessageSent = dateNow.AddDays(-1)
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

        public IEnumerable<MessageGroup<string, MessageDto>> GetMessages()
        {
            var groups = _messages
                .ToList()
                .GroupBy(x => x.DateMessageSent.Date)
                .Select(x =>
                    new MessageGroup<DateTime, Message>(
                        x.Key.Date,
                        x.OrderByDescending(msg => msg.DateMessageSent.Ticks)
                    )
                )
                .OrderByDescending(x => x.Date);

            return groups.Select(x =>
                new MessageGroup<string, MessageDto>(
                    ConvertGroupDateToString(x.Date),
                    x.Select(item => new MessageDto()
                    {
                        Id = item.Id,
                        SenderId = item.SenderId,
                        Text = item.Text,
                        DateMessageSent = item.DateMessageSent.ToString("HH:mm")
                    })
                )
            );
        }

        public string ConvertGroupDateToString(DateTime groupDate)
        {
            var dateToday = DateTime.Today.Date;
            var dateGroupWithoutTime = groupDate.Date;

            if (dateToday == dateGroupWithoutTime)
            {
                return "today";
            }

            var dateYesterday = dateToday.Subtract(new TimeSpan(1, 0, 0, 0));

            if (dateYesterday == dateGroupWithoutTime)
            {
                return "yesterday";
            }

            if (dateToday.Year == dateGroupWithoutTime.Year)
            {
                return groupDate.ToString("MMMM dd");
            }

            return groupDate.ToString("MMMM dd, yyyy");
        }
    }
}