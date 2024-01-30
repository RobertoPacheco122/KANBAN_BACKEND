using AutoMapper;
using Domain.DTOs.Board;
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
        private readonly IMapper _mapper;

        public BoardService(
            IRepository<BoardEntity> boardRepository, 
            IBoardRepository specificBoardRepository,
            IMapper mapper
        ){
            _boardRepository = boardRepository;
            _specificBoardRepository = specificBoardRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id) {
            return await _boardRepository.DeleteAsync(id);
        }

        public async Task<List<BoardDto>> GetAll() {
            var entities = await _boardRepository.GetAllAsync();

            return _mapper.Map<List<BoardDto>>(entities);
        }

        public async Task<BoardEntity> GetRelatedDetails(Guid id) {
            return await _specificBoardRepository.GetAllRelatedDetails(id);
        }

        public async Task<BoardDto> GetSingle(Guid id) {
            var entity = await _boardRepository.SelectAsync(id);

            return _mapper.Map<BoardDto>(entity);
        }

        public async Task<BoardDto> Insert(BoardAddDto boardAddDto) {
            var dtoToEntity = _mapper.Map<BoardEntity>(boardAddDto);
            var entity = await _boardRepository.InsertAsync(dtoToEntity);

            return _mapper.Map<BoardDto>(entity);
        }

        public async Task<BoardDto> Update(BoardUpdateDto boardUpdateDto) {
            var dtoToEntity = _mapper.Map<BoardEntity>(boardUpdateDto);
            var entity = await _boardRepository.UpdateAsync(dtoToEntity);

            return _mapper.Map<BoardDto>(entity);
        }
    }
}
