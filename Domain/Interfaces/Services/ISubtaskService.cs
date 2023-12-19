using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ISubtaskService {
        Task<bool> Delete(int id);
        Task<List<SubtaskEntity>> GetAll();
        Task<SubtaskEntity> GetSingle(int id);
        Task<SubtaskEntity> Insert(SubtaskEntity subtask);
        Task<SubtaskEntity> Update(SubtaskEntity subtask);
    }
}
