using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/chats/{chatId}/[controller]")]
    public class MessagesController : ControllerBase
    {
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