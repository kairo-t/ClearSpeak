using Microsoft.AspNetCore.Mvc;
using ClearSpeakApi.Models;

namespace ClearSpeakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        // POST /api/authentication/sendcode (send an authentication code)
        [HttpPost("sendcode")]
        public IActionResult SendCode([FromBody] PhoneNumber phoneNumber)
        {
            throw new NotImplementedException();
        }

        // POST /api/authentication/validate (validate an authentication code)
        [HttpPost("validate")]
        public IActionResult ValidateCode([FromBody] AuthCode authCode)
        {
            throw new NotImplementedException();
        }

        // POST /api/authentication/logout (logout a user)
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            throw new NotImplementedException();
        }
    }
}