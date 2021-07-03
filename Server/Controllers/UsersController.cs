using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public JsonResult Videos(int userId)
        {
            return Json(Enumerable.Range(1, 5).Select(index => userId.ToString()).ToArray());
        }
    }
}
