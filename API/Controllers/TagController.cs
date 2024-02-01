using Domain.DTOs.Tag;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase {
        private readonly ITagService _tagService;
        public TagController(ITagService tagService) {
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TagEntity>>> GetAll() {
            try {
                var response = await _tagService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TagDto>> GetSingle(Guid id) {
            try {
                var response = await _tagService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TagDto>> Insert([FromBody] TagAddDto tagAddDto) {
            try {
                var response = await _tagService.Insert(tagAddDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<TagDto>> Update([FromBody] TagUpdateDto tagUpdateDto) {
            try {
                var response = await _tagService.Update(tagUpdateDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id) {
            try {
                var response = await _tagService.Delete(id);

                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
