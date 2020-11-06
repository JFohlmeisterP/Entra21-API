using System;

namespace Domain.Users
{
    public class UsersService
    {
        public Guid Create(string name, Profile profile)
        {
            var user = new User(name, profile);
            return user.Id;
        }

    }
}