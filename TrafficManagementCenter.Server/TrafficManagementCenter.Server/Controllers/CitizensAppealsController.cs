using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using TrafficManagementCenter.Server.Db.Repositories;

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

        [HttpPost("addappeal")]
        public async Task<IActionResult> AddAppeal(Appeal appeal)
        {
            var repos = new AppealRepository();

            repos.Add(appeal);
            
            return Ok();
        }
    }
}