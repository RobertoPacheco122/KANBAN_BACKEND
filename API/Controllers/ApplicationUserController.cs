using Domain.DTOs.ApplicationUser;
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
        public async Task<ActionResult<List<ApplicationUserDto>>> GetAll() {
            try {
                var response = await _userService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUserDto>> GetSingle(Guid id) {
            try {
                var response = await _userService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ApplicationUserDto>> Insert([FromBody] ApplicationUserAddDto applicationUserAddDto) {
            try {
                var response = await _userService.Insert(applicationUserAddDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<ApplicationUserDto>> Update([FromBody] ApplicationUserUpdateDto applicationUserUpdateDto) {
            try {
                var response = await _userService.Update(applicationUserUpdateDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id) {
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
