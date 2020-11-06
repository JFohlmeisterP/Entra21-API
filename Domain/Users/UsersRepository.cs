using System;
using System.Collections.Generic;

namespace Domain.Users
{
    class UsersRepository
    {
        private List<User> _users { get; set; }

        public IReadOnlyCollection<User> Users => _users;

        public void Add(User user)
        {
            _users.Add(user);
        }
    }
}