using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;
using ClearSpeakApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly ApplicationDbContext _context;

        public UsersController(ILogger<UsersController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // POST /users (register new user)
        [HttpPost]
        public IActionResult RegisterUser([FromBody] User user)
        {
            var asdf = _context.Users.FirstOrDefault(x => x.Id == user.Id);
            // TODO: Add code to register a new user.
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

        // GET /users/phonenumber (get a user by phone number)
        [HttpGet("{phoneNumber}")]
        public IActionResult GetUserByPhoneNumber(string phoneNumber)
        {
            // TODO: Add code to get a user by phone number.
            User user = _context.Users.FirstOrDefault(u => u.PhoneNumber == phoneNumber);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // DELETE /users/userId (delete a user)
        [HttpDelete("{userId}")]
        public IActionResult DeleteUser(string userId)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }
}