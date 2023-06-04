using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        // POST /api/notifications (send a notification)
        [HttpPost]
        public IActionResult SendNotification([FromBody] Notification notification)
        {
            throw new NotImplementedException();
        }

        // GET /api/notifications/{userId} (fetch notifications for a user)
        [HttpGet("{userId}")]
        public IActionResult GetNotifications(string userId)
        {
            throw new NotImplementedException();
        }
    }
}