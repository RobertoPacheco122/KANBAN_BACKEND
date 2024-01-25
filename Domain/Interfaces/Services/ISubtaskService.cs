using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ISubtaskService {
        Task<bool> Delete(Guid id);
        Task<List<SubtaskEntity>> GetAll();
        Task<SubtaskEntity> GetSingle(Guid id);
        Task<SubtaskEntity> Insert(SubtaskEntity subtask);
        Task<SubtaskEntity> Update(SubtaskEntity subtask);
    }
}
