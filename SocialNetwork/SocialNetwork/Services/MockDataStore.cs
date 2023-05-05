using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Models;
using SocialNetwork.ModelsView;

namespace SocialNetwork.Services
{
    public class MockDataStore
    {
        private readonly IEnumerable<News> _news;

        public MockDataStore()
        {
            _news = new List<News>()
            {
                new News()
                {
                    Id = Guid.NewGuid(),
                    IdUsersLiked = new[]
                    {
                        1, 5, 6, 7
                    },
                    Username = "user1",
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    DateCreated = DateTime.Now.AddDays(1),
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    ImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Username = "user2",
                    IdUsersLiked = new[]
                    {
                        1, 5, 2, 7
                    },
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    DateCreated = DateTime.Now.Subtract(new TimeSpan(1, 4, 45, 12)),
                    Text = "Nunc tempor, quam at venenatis vehicula, nisl risus placerat sapien.",
                    ImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg")
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Username = "user3",
                    IdUsersLiked = new[]
                    {
                        1, 9, 3, 7
                    },
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    DateCreated = DateTime.Now,
                    Text = "Suspendisse ut sagittis metus, a tristique lacus.",
                    ImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg")
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Username = "user1",
                    IdUsersLiked = new[]
                    {
                        1, 5, 6, 7
                    },
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    DateCreated = DateTime.Now.Subtract(new TimeSpan(5, 4, 45, 12)),
                    Text = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames.",
                    ImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg")
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Username = "user2",
                    IdUsersLiked = new[]
                    {
                        1, 5, 8, 7
                    },
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    DateCreated = DateTime.Now.Subtract(new TimeSpan(1, 2, 45, 12)),
                    Text = "Vivamus aliquet purus eget justo vehicula, sit amet consectetur metus fringilla.",
                    ImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg")
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Username = "user3",
                    IdUsersLiked = new[]
                    {
                        1, 5, 6, 7
                    },
                    ProfileImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg"),
                    DateCreated = DateTime.Now.Subtract(new TimeSpan(2, 4, 45, 12)),
                    Text = "Phasellus vel odio ullamcorper, scelerisque leo sed, porta ante.",
                    ImageUri = new Uri("https://img.freepik.com/free-photo/morskie-oko-tatry_1204-510.jpg")
                }
            };
        }

        public async Task<IEnumerable<NewsDto>> GetNews()
        {
            return await Task.FromResult(_news.ToList().OrderBy(x => x.DateCreated).Select(x => new NewsDto()
            {
                Id = x.Id,
                Username = x.Username,
                ProfileImageUri = x.ProfileImageUri,
                DateCreated = x.DateCreated.ToString("d MMMM \"at\" HH:mm"),
                Text = x.Text,
                ImageUri = x.ImageUri,
                IdUsersLiked = x.IdUsersLiked,
            }));
        }
    }
}