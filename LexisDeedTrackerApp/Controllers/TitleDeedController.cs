using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LexisDeedTrackerDataAccess.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LexisDeedTrackerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleDeedController : ControllerBase
    {

        private readonly ITitleDeedDataAccess _titledeedDataAccess;

        public TitleDeedController(ITitleDeedDataAccess titledeedDataAccess)
        {
            _titledeedDataAccess = titledeedDataAccess;
        }
        [HttpGet]
        public async Task<IActionResult> GetTitleDeeds()
        {
            try
            {

                var titleDeeds = await _titledeedDataAccess.GetTitleDeeds();
                return Ok(new
                {
                    Success = true,
                    Message = "All title deed records returned.",
                    titleDeeds
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet]
        [Route("{titleDeedId}")]
        public async Task<IActionResult> GetTitleDeed(int titleDeedId)
        {
            try
            {
                var titleDeed = await _titledeedDataAccess.GetTitleDeed(titleDeedId);
                if (titleDeed == null) return NotFound();
                return Ok(new
                {
                    success = true,
                    message = "One Title Deed record returned.",
                    data = titleDeed
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
