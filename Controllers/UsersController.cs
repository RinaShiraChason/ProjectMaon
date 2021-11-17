using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("api/Users/FindUser")]
        public string FindUser(/*string name,string password*/)
        {
            return /*name + ' ' + password*/"הצליח";
        }
    }
}
