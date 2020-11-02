using System;

namespace Domain
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public Profile Profile { get; set; }      

        public Usuario(string nome, Profile profile)
        {
            Nome = nome;
            Profile = profile;
        }

    }
}