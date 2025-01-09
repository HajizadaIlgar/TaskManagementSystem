using Microsoft.AspNetCore.Mvc;
using TaskManagement.BL.DTOs.TopicDTOs;
using TaskManagement.BL.Services.Abstracts;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController(ITopicService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Post(TopicCreateDTO dto)
        {
            return Ok(await _service.CreateAsync(dto));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
