using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ITaskService {
        Task<bool> Delete(Guid id);
        Task<List<TaskEntity>> GetAll();
        Task<TaskEntity> GetSingle(Guid id);
        Task<TaskEntity> Insert(TaskEntity task);
        Task<TaskEntity> Update(TaskEntity task);
    }
}
