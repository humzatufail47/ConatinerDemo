using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpAPIs.Database;
using HttpAPIs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IAppContext _appContext;

        public UsersController(IAppContext appContext)
        {
            _appContext = appContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersAsync()
        {
            return _appContext.Users.Select(x => x).ToList();
        }
    }
}
