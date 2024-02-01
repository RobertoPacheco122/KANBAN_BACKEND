using Domain.DTOs.Task;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService) {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskDto>>> GetAll() {
            try {
                var response = await _taskService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDto>> GetSingle(Guid id) {
            try {
                var response = await _taskService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TaskDto>> Insert([FromBody] TaskAddDto taskAddDto) {
            try {
                var response = await _taskService.Insert(taskAddDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<TaskDto>> Update([FromBody] TaskUpdateDto taskUpdateDto) {
            try {
                var response = await _taskService.Update(taskUpdateDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id) {
            try {
                var response = await _taskService.Delete(id);

                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
