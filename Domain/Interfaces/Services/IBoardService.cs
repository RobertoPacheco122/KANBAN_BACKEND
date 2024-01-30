using Domain.DTOs.Board;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IBoardService {
        Task<bool> Delete(Guid id);
        Task<List<BoardDto>> GetAll();
        Task<BoardDto> GetSingle(Guid id);
        Task<BoardDto> Insert(BoardAddDto boardAddDto);
        Task<BoardDto> Update(BoardUpdateDto boardUpdateDto);
        Task<BoardEntity> GetRelatedDetails(Guid id);
    }
}
