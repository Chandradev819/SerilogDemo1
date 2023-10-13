using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerilogDemo1.Shared;

namespace SerilogDemo1.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        // POST api/<EmpController>
        [HttpPost]
        public async Task<string> post(ErrorLog log)
        {
            // we will write code for saving in database.
            string msg = log.ErrorStackTrace;
            return "Log has been saved in database";

        }
    }
}
