using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase {
        private readonly IBoardService _boardService;
        public BoardController(IBoardService boardService) {
            _boardService = boardService;
        }

        [HttpGet]
        public async Task<ActionResult<List<BoardEntity>>> GetAll() {
            try {
                var response = await _boardService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BoardEntity>> GetSingle(int id) {
            try {
                var response = await _boardService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<BoardEntity>> Insert([FromBody] BoardEntity board) {
            try {
                var response = await _boardService.Insert(board);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BoardEntity>> Update([FromBody] BoardEntity board) {
            try {
                var response = await _boardService.Update(board);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id) {
            try {
                var response = await _boardService.Delete(id);

                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
