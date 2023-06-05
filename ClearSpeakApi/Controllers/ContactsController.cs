using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;
using ClearSpeakApi.Data;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly ILogger<ContactsController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactsController(ILogger<ContactsController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // POST /api/contacts (add a contact)
        [HttpPost]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            throw new NotImplementedException();
        }

        // GET /api/contacts/{userId} (get contacts for a user)
        [HttpGet("{userId}")]
        public IActionResult GetContacts(string userId)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/contacts/{userId}/{contactId} (delete a contact)
        [HttpDelete("{userId}/{contactId}")]
        public IActionResult DeleteContact(string userId, string contactId)
        {
            throw new NotImplementedException();
        }
    }
}