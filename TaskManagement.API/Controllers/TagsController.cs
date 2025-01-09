using Microsoft.AspNetCore.Mvc;
using TaskManagement.BL.DTOs.TagDTOs;
using TaskManagement.BL.Services.Abstracts;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController(ITagService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Post(TagCreateDTO dto)
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
