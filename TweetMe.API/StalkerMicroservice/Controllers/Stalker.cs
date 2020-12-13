using Microsoft.AspNetCore.Mvc;

namespace StalkerMicroservice.Controllers
{
    [Route("api/stalker")]
    [ApiController]
    public class Stalker : ControllerBase
    {
        [HttpGet]
        public string FriendList()
        {
            return "DA";
        }

    }
}
