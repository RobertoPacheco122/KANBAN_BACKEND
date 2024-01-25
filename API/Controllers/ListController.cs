using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase {
        private readonly IListService _listService;
        public ListController(IListService listService) {
            _listService = listService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ListEntity>>> GetAll() {
            try {
                var response = await _listService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ListEntity>> GetSingle(Guid id) {
            try {
                var response = await _listService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ListEntity>> Insert([FromBody] ListEntity list) {
            try {
                var response = await _listService.Insert(list);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ListEntity>> Update([FromBody] ListEntity list) {
            try {
                var response = await _listService.Update(list);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id) {
            try {
                var response = await _listService.Delete(id);

                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
