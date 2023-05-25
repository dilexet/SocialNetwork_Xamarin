using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Models;
using SocialNetwork.ModelsView;

namespace SocialNetwork.Services
{
    public class ChatsMockDataStore
    {
        private readonly IEnumerable<Chat> _chats;

        private static ChatsMockDataStore _instance;

        public static ChatsMockDataStore GetInstance()
        {
            return _instance ?? (_instance = new ChatsMockDataStore());
        }

        public ChatsMockDataStore()
        {
            _chats = new List<Chat>()
            {
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Alice",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "Hey, how are you?",
                    LastMessageDate = DateTime.Now.AddDays(-1),
                    NumberOfUnreadMessages = 0,
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Bob",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "Not bad, you?",
                    LastMessageDate = DateTime.Now.AddHours(-3),
                    NumberOfUnreadMessages = 2
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Charlie",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "I'm good, thanks!",
                    LastMessageDate = DateTime.Now.AddMinutes(-30),
                    NumberOfUnreadMessages = 1
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Dave",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "Hey, can we talk later?",
                    LastMessageDate = DateTime.Now.AddDays(-2),
                    NumberOfUnreadMessages = 0
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Eve",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "Sure, what time?",
                    LastMessageDate = DateTime.Now.AddDays(-3),
                    NumberOfUnreadMessages = 0
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Frank",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "How's work going?",
                    LastMessageDate = DateTime.Now.AddHours(-2),
                    NumberOfUnreadMessages = 5
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Grace",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "It's going well, thanks for asking!",
                    LastMessageDate = DateTime.Now.AddDays(-4),
                    NumberOfUnreadMessages = 0
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Harry",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "What are you up to this weekend?",
                    LastMessageDate = DateTime.Now.AddDays(-5),
                    NumberOfUnreadMessages = 0
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Isabel",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "Not much, you?",
                    LastMessageDate = DateTime.Now.AddDays(-6),
                    NumberOfUnreadMessages = 0
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    Username = "Jack",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    LastMessageText = "I'm planning on going for a hike",
                    LastMessageDate = DateTime.Now.AddHours(-5),
                    NumberOfUnreadMessages = 0
                },
            };
        }

        public async Task<IEnumerable<ChatDto>> GetChats()
        {
            return await Task.FromResult(
                _chats
                    .ToList()
                    .OrderByDescending(x => x.LastMessageDate)
                    .Select(chat =>
                        new ChatDto
                        {
                            Id = chat.Id,
                            Username = chat.Username,
                            ProfileImageUri = chat.ProfileImageUri,
                            LastMessageText = chat.LastMessageText,
                            LastMessageDate = ConvertDate(chat.LastMessageDate),
                            NumberOfUnreadMessages = chat.NumberOfUnreadMessages,
                        }));
        }

        public ChatDto GetChatById(Guid id)
        {
            var chat = _chats.FirstOrDefault(x => x.Id.Equals(id));
            if (chat == null)
            {
                return null;
            }

            var messagesMockDataStore = new MessagesMockDataStore();

            var chatDto = new ChatDto
            {
                Id = chat.Id,
                Username = chat.Username,
                ProfileImageUri = chat.ProfileImageUri,
                LastMessageText = chat.LastMessageText,
                LastMessageDate = ConvertDate(chat.LastMessageDate),
                NumberOfUnreadMessages = chat.NumberOfUnreadMessages,
                Messages = new ObservableCollection<MessageGroup<string, MessageDto>>(messagesMockDataStore.GetMessages())
            };

            return chatDto;
        }

        private string ConvertDate(DateTime dateToConvert)
        {
            return dateToConvert.Date == DateTime.Today
                ? dateToConvert.ToString("HH:mm")
                : dateToConvert.ToString("MMM d");
        }
    }
}