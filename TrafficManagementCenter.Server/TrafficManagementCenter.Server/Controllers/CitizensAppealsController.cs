using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using TrafficManagementCenter.Server.Db.Context;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Controllers
{
    [Route("api/citizens")]
    [ApiController]
    public class CitizensAppealsController : ControllerBase
    {
        private AppDbContext _context;

        public CitizensAppealsController(AppDbContext context)
        {
            _context = context;
        }
        
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

        [HttpGet("all")]
        public async Task<IActionResult> GetAllAppeal()
        {
            IEnumerable<Appeal> appeals;
            using (var repos = new AppealRepository())
                appeals =repos.GetEntities();
            return Ok(appeals);
        }

        [HttpPost("addappeal")]
        public async Task<IActionResult> AddAppeal(Appeal appeal)
        {
            using (var repos = new AppealRepository())
                repos.Add(appeal);
            return Ok();
        }
    }
}