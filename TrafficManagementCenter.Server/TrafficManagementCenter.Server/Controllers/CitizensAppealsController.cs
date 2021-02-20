using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace TrafficManagementCenter.Server.Controllers
{
    [Route("api/citizens")]
    [ApiController]
    public class CitizensAppealsController : ControllerBase
    {
        // GET
        public string Index()
        {
            return "";
        }

        [HttpGet("ping")]
        public int Ping()
        {
            return StatusCodes.Status200OK;
        }

        public Task<ActionResult> AddAppeal(Appeal appeal)
        {
            throw new System.NotImplementedException();
        }
    }
}