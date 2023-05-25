using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Models;

namespace SocialNetwork.Services
{
    public class FriendMockDataStore
    {
        private readonly IEnumerable<Friend> _friends;

        public FriendMockDataStore()
        {
            _friends = new List<Friend>()
            {
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "John",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 25,
                    CityFrom = "New York"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Lisa",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 28,
                    CityFrom = "Los Angeles"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Alex",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 30,
                    CityFrom = "Chicago"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Ryan",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 21,
                    CityFrom = "Houston"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Emma",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 23,
                    CityFrom = "New York"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Derek",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 33,
                    CityFrom = "Miami"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Harper",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 23,
                    CityFrom = "Las Vegas"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Olivia",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 27,
                    CityFrom = "San Francisco"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Lucas",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 26,
                    CityFrom = "Seattle"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Sophia",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 24,
                    CityFrom = "Boston"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Mia",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 29,
                    CityFrom = "Austin"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Avery",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 22,
                    CityFrom = "Portland"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Ethan",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 31,
                    CityFrom = "Denver"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Chloe",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 28,
                    CityFrom = "San Diego"
                },
                new Friend()
                {
                    Id = Guid.NewGuid(),
                    Username = "Levi",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    Age = 25,
                    CityFrom = "Philadelphia"
                }
            };
        }


        public IEnumerable<Friend> GerFriends()
        {
            return _friends.ToList().OrderByDescending(x => x.Username);
        }
    }
}