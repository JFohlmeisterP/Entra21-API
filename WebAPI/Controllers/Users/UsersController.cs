using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly List<Usuario> Usuarios = new List<Usuario>();

        [HttpPost]
        public Profile Post(CreateUserRequest userRequest)
        {
            var user = new Usuario(userRequest.Name, userRequest.Profile);
            Usuarios.Add(user);
            return user.Profile;
        }

        [HttpGet]
        public List<Usuario> BuscarUsuario()
        {
            return Usuarios;
        }
        
    }
}
