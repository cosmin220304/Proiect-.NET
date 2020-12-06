using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetMe.API.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class Tesst : ControllerBase
    {

        [HttpGet]
        public string Salut()
        {
            return "Hello!";
        }
    }
}
