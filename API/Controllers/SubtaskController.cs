using Domain.DTOs.Subtask;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SubtaskController : ControllerBase {
        private readonly ISubtaskService _subtaskService;
        public SubtaskController(ISubtaskService subtaskService) {
            _subtaskService = subtaskService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SubtaskDto>>> GetAll() {
            try {
                var response = await _subtaskService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubtaskDto>> GetSingle(Guid id) {
            try {
                var response = await _subtaskService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<SubtaskDto>> Insert([FromBody] SubtaskAddDto subtaskAddDto) {
            try {
                var response = await _subtaskService.Insert(subtaskAddDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<SubtaskDto>> Update([FromBody] SubtaskUpdateDto subtaskUpdateDto) {
            try {
                var response = await _subtaskService.Update(subtaskUpdateDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id) {
            try {
                var response = await _subtaskService.Delete(id);

                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
