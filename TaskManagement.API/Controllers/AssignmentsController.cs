using Microsoft.AspNetCore.Mvc;
using TaskManagement.BL.DTOs.AssignmentDTOs;
using TaskManagement.BL.Services.Abstracts;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController(IAssignmentService _service) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(AssignmentCreateDTO dto)
        {
            return Ok(await _service.CreateAsync(dto));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
