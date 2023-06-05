using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;
using ClearSpeakApi.Data;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/chats/{chatId}/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly ILogger<MessagesController> _logger;
        private readonly ApplicationDbContext _context;

        public MessagesController(ILogger<MessagesController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // POST /api/chats/{chatId}/messages (send a new message)
        [HttpPost]
        public IActionResult SendMessage(string chatId, [FromBody] Message message)
        {
            throw new NotImplementedException();
        }

        // GET /api/chats/{chatId}/messages (fetch messages for a chat)
        [HttpGet]
        public IActionResult GetMessages(string chatId)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/chats/{chatId}/messages/{messageId} (delete a message)
        [HttpDelete("{messageId}")]
        public IActionResult DeleteMessage(string chatId, string messageId)
        {
            throw new NotImplementedException();
        }
    }
}