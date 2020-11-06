using System;
using System.Collections.Generic;

namespace Domain.Users
{
    class UsersRepository
    {
        private static List<User> _users = new List<User>();

        public static IReadOnlyCollection<User> Users => _users;

        public void Add(User user)
        {
            _users.Add(user);
        }
    }
}