using Domain;

namespace WebAPI.Controllers
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public Profile Profile { get; set; }
    }
}