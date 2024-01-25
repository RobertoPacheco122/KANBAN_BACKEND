using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IListService {
        Task<bool> Delete(Guid id);
        Task<List<ListEntity>> GetAll();
        Task<ListEntity> GetSingle(Guid id);
        Task<ListEntity> Insert(ListEntity list);
        Task<ListEntity> Update(ListEntity list);
    }
}
