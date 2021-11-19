using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_Core_Web_API.Database;
using Microsoft.EntityFrameworkCore;
using Net_Core_Web_API.Interface;

namespace Net_Core_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LectureController : ControllerBase
    {

        private readonly ILectureService _lectureService;

        public LectureController(ILectureService lectureService)
        {
            _lectureService= lectureService;
        }

        [HttpGet]
        [Route("GetLectures")]
        public async Task<IActionResult> GetLectures()
        {
            try
            {
                var serviceResult = await _lectureService.GetLecturesAsync();
                return Ok(serviceResult);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var serviceResult = await _lectureService.GetUsersAsync();
                return Ok(serviceResult);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


    }
}
