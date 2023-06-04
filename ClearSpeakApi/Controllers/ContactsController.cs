using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
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