using Domain.DTOs.Board;
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
        public async Task<ActionResult<List<BoardDto>>> GetAll() {
            try {
                var response = await _boardService.GetAll();

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("related/{id}")]
        public async Task<ActionResult<List<BoardEntity>>> GetAllRelatedDetails(Guid id) {
            try {
                var response = await _boardService.GetRelatedDetails(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BoardDto>> GetSingle(Guid id) {
            try {
                var response = await _boardService.GetSingle(id);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<BoardDto>> Insert([FromBody] BoardAddDto boardAddDto) {
            try {
                var response = await _boardService.Insert(boardAddDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<BoardDto>> Update([FromBody] BoardUpdateDto boardUpdateDto) {
            try {
                var response = await _boardService.Update(boardUpdateDto);

                return Ok(response);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id) {
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
