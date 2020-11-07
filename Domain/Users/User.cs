using System;
using System.Linq;

namespace Domain.Users
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Profile Profile { get; set; }      

        public User(string name, Profile profile)
        {
            Name = name;
            Profile = profile;
        }
        public bool Validate()
        {

            bool isValid = true;

            if (string.IsNullOrEmpty(Name))
            {
                return !isValid;
            }

            var name = Name;

            for (var i = 0; i < name.Length; i++)
            {
                var charInName = name[i];
                if (charInName.Equals(" "))
                {
                    return !isValid;
                }
            }
            
            if (!name.All(char.IsLetter))
            {
                return !isValid;
            }
            else if (!name.All(char.IsNumber))
            {
                return !isValid;
            }

            return !isValid;
        }

    }
}