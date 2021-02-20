using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrafficManagementCenter.Server.Controllers
{
    [ApiController]
    [Route("[api/citizens]")]
    public class CitizensAppealsController : ControllerBase
    {
        // GET
        public string Index()
        {
            return "";
        }

        [HttpGet("/ping")]
        public int Ping()
        {
            return StatusCodes.Status200OK;
        }
    }
}