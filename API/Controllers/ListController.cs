using Domain.DTOs.List;
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
        public async Task<ActionResult<List<ListDto>>> GetAll() {
            try {
                var response = await _listService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ListDto>> GetSingle(Guid id) {
            try {
                var response = await _listService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ListDto>> Insert([FromBody] ListAddDto listDto) {
            try {
                var response = await _listService.Insert(listDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<ListDto>> Update([FromBody] ListUpdateDto list) {
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

                if(response =! true) return BadRequest("Ocorreu um erro ao deletar a task");

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
