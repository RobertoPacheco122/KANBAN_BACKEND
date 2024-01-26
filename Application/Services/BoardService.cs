using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class BoardService : IBoardService {
        private readonly IRepository<BoardEntity> _boardRepository;
        private readonly IBoardRepository _specificBoardRepository;
        public BoardService(IRepository<BoardEntity> boardRepository, IBoardRepository specificBoardRepository) {
            _boardRepository = boardRepository;
            _specificBoardRepository = specificBoardRepository;
        }

        public async Task<bool> Delete(Guid id) {
            return await _boardRepository.DeleteAsync(id);
        }

        public async Task<List<BoardEntity>> GetAll() {
            return await _boardRepository.GetAllAsync();
        }

        public async Task<BoardEntity> GetRelatedDetails(Guid id) {
            return await _specificBoardRepository.GetAllRelatedDetails(id);
        }

        public async Task<BoardEntity> GetSingle(Guid id) {
            return await _boardRepository.SelectAsync(id);
        }

        public async Task<BoardEntity> Insert(BoardEntity board) {
            return await _boardRepository.InsertAsync(board);
        }

        public async Task<BoardEntity> Update(BoardEntity board) {
            return await _boardRepository.UpdateAsync(board);
        }
    }
}
