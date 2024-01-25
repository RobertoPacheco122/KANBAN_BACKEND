using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase {
        private readonly IApplicationUserService _userService;
        public ApplicationUserController(IApplicationUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ApplicationUserEntity>>> GetAll() {
            try {
                var response = await _userService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUserEntity>> GetSingle(int id) {
            try {
                var response = await _userService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ApplicationUserEntity>> Insert([FromBody] ApplicationUserEntity user) {
            try {
                var response = await _userService.Insert(user);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApplicationUserEntity>> Update([FromBody] ApplicationUserEntity user) {
            try {
                var response = await _userService.Update(user);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id) {
            try {
                var response = await _userService.Delete(id);

                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
