using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Domain.Users;

namespace WebAPI.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public readonly UsersService _usersService;
        public UsersController()
        {
            _usersService = new UsersService();
        }

        [HttpPost]
        public IActionResult Post(CreateUserRequest userRequest)
        {
            if(userRequest.Profile == Domain.Profile.CBF && userRequest.Password != "admin123")
            {
                return Unauthorized();
            }

            var response = _usersService.Create(userRequest.Name, userRequest.Profile);

            if (!response.IsValid)
            {
                return BadRequest(response.Errors);
            }
            
            return Ok(response.Id);
        }

        [HttpPut("{name}")]
        public IActionResult Put(CreateUserRequest userRequest)
        {
            if(userRequest.Profile == Domain.Profile.CBF && userRequest.Password != "admin123")
            {
                return Unauthorized();
            }

            var response = _usersService.Update(userRequest.Name, userRequest.Profile);

            if (!response.IsValid)
            {
                return BadRequest(response.Errors);
            }
            
            return Ok(response.Id);
        }
        
    }
}
