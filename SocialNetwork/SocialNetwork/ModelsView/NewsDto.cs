using System;

namespace SocialNetwork.ModelsView
{
    public class NewsDto
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public Uri ProfileImageUri { get; set; }

        public string DateCreated { get; set; }

        public string Text { get; set; }

        public Uri ImageUri { get; set; }

        public int[] IdUsersLiked { get; set; }
    }
}