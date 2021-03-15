using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using TrafficManagementCenter.Server.Db.Context;
using TrafficManagementCenter.Server.Db.Extensions;
using TrafficManagementCenter.Server.Db.Factory;
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

        [HttpGet("ping")]
        public int Ping()
        {
            return StatusCodes.Status200OK;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllAppeal()
        {
            return Ok(RepositoryFactory<Appeal>.Create(_context).GetEntities());
        }

        [HttpGet("allbyemail")]
        public async Task<IActionResult> GetAllAppealsByEmail(string email)
        {
            return Ok(((AppealRepository) RepositoryFactory<Appeal>.Create(_context)).GetEntitiesByEmail(email));
        }

        [HttpPost("addappeal")]
        public async Task<IActionResult> AddAppeal([FromBody]Appeal appeal, [FromQuery]string nameClass,
            [FromQuery]string nameSubtype)
        {
            ((AppealRepository) RepositoryFactory<Appeal>.Create(_context)).Add(appeal, nameClass, nameSubtype);
            return Ok();
        }

        [HttpGet("alltypes")]
        public async Task<IActionResult> GetAllClassAppeal()
        {
            return Ok(RepositoryFactory<ClassAppeal>.Create(_context).GetEntities());
        }
        
        [HttpGet("subtypesbytype")]
        public async Task<IActionResult> GetSubtypeByTypeAppeal(string nameType)
        {
            return Ok(((SubtypeAppealRepository)RepositoryFactory<SubtypeAppeal>.Create(_context)).
                GetSubtypeByTypeAppeal(nameType));
        }
    }
}