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
        public async Task<ActionResult<List<SubtaskEntity>>> GetAll() {
            try {
                var response = await _subtaskService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubtaskEntity>> GetSingle(int id) {
            try {
                var response = await _subtaskService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<SubtaskEntity>> Insert([FromBody] SubtaskEntity subtask) {
            try {
                var response = await _subtaskService.Insert(subtask);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SubtaskEntity>> Update([FromBody] SubtaskEntity subtask) {
            try {
                var response = await _subtaskService.Update(subtask);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id) {
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
