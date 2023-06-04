using Microsoft.AspNetCore.Mvc;
using System;
using ClearSpeakApi.Models;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        // POST /api/chats (create a new chat)
        [HttpPost]
        public IActionResult CreateChat([FromBody] Chat chat)
        {
            throw new NotImplementedException();
        }

        // GET /api/chats/{chatId} (get a chat)
        [HttpGet("{chatId}")]
        public IActionResult GetChat(string chatId)
        {
            throw new NotImplementedException();
        }

        // POST /api/chats/{chatId}/users (add user to a chat)
        [HttpPost("{chatId}/users")]
        public IActionResult AddUserToChat(string chatId, [FromBody] User user)
        {
            throw new NotImplementedException();
        }

        // DELETE /api/chats/{chatId}/users/{userId} (remove user from a chat)
        [HttpDelete("{chatId}/users/{userId}")]
        public IActionResult RemoveUserFromChat(string chatId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}