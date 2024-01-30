using Domain.DTOs.List;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IListService {
        Task<bool> Delete(Guid id);
        Task<List<ListDto>> GetAll();
        Task<ListDto> GetSingle(Guid id);
        Task<ListDto> Insert(ListAddDto listDto);
        Task<ListDto> Update(ListUpdateDto listDto);
    }
}
