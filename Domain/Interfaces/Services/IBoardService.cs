using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IBoardService {
        Task<bool> Delete(int id);
        Task<List<BoardEntity>> GetAll();
        Task<BoardEntity> GetSingle(int id);
        Task<BoardEntity> Insert(BoardEntity board);
        Task<BoardEntity> Update(BoardEntity board);
    }
}
