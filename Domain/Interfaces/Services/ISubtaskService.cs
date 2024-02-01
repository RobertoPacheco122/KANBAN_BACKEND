using Domain.DTOs.Subtask;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ISubtaskService {
        Task<bool> Delete(Guid id);
        Task<List<SubtaskDto>> GetAll();
        Task<SubtaskDto> GetSingle(Guid id);
        Task<SubtaskDto> Insert(SubtaskAddDto subtaskAddDto);
        Task<SubtaskDto> Update(SubtaskUpdateDto subtaskUpdateDto);
    }
}
