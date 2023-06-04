using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        // POST /users (register new user)
        [HttpPost]
        public IActionResult RegisterUser([FromBody] User user)
        {
            // TODO: Add code to register a new user.

            throw new NotImplementedException();
        }

        // GET /users/phonenumber (get a user by phone number)
        [HttpGet("{phoneNumber}")]
        public IActionResult GetUserByPhoneNumber(string phoneNumber)
        {
            // TODO: Add code to get a user by phone number.

            throw new NotImplementedException();
        }

        // DELETE /users/userId (delete a user)
        [HttpDelete("{userId}")]
        public IActionResult DeleteUser(string userId)
        {
            // TODO: Add code to delete a user.

            throw new NotImplementedException();
        }
    }

}