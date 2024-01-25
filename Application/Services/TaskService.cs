using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class TaskService : ITaskService {
        private readonly IRepository<TaskEntity> _taskRepository;
        public TaskService(IRepository<TaskEntity> taskRepository) {
            _taskRepository = taskRepository;
        }

        public async Task<bool> Delete(Guid id) {
            return await _taskRepository.DeleteAsync(id);
        }

        public async Task<List<TaskEntity>> GetAll() {
            return await _taskRepository.GetAllAsync();
        }

        public async Task<TaskEntity> GetSingle(Guid id) {
            return await _taskRepository.SelectAsync(id);
        }

        public async Task<TaskEntity> Insert(TaskEntity task) {
            return await _taskRepository.InsertAsync(task);
        }

        public async Task<TaskEntity> Update(TaskEntity task) {
            return await _taskRepository.UpdateAsync(task);
        }
    }
}
