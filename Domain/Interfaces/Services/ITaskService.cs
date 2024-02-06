using Domain.DTOs.Task;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ITaskService {
        Task<bool> Delete(Guid id);
        Task<List<TaskDto>> GetAll();
        Task<TaskEntity> GetRelatedDetails(Guid id);
        Task<TaskDto> GetSingle(Guid id);
        Task<TaskDto> Insert(TaskAddDto taskAddDto);
        Task<TaskDto> Update(TaskUpdateDto taskUpdateDto);
    }
}
