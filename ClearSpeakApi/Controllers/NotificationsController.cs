using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;
using ClearSpeakApi.Data;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly ILogger<NotificationsController> _logger;
        private readonly ApplicationDbContext _context;

        public NotificationsController(ILogger<NotificationsController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

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