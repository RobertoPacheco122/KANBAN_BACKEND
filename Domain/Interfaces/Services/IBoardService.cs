using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IBoardService {
        Task<bool> Delete(Guid id);
        Task<List<BoardEntity>> GetAll();
        Task<BoardEntity> GetSingle(Guid id);
        Task<BoardEntity> Insert(BoardEntity board);
        Task<BoardEntity> Update(BoardEntity board);
        Task<BoardEntity> GetRelatedDetails(Guid id);
    }
}
