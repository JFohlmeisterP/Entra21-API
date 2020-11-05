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
        public IActionResult Post(CreateUserRequest userRequest)
        {
            if(userRequest.Profile == Profile.CBF && userRequest.Password != "admin123")
            {    
                return Unauthorized();
            }

            var user = new Usuario(userRequest.Name, userRequest.Profile);
            return Ok(user.Id);
        }

        [HttpGet]
        public List<Usuario> BuscarUsuario()
        {
            return Usuarios;
        }
        
    }
}
