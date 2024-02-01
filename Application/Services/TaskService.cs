using AutoMapper;
using Domain.DTOs.Task;
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
        private readonly IMapper _mapper;

        public TaskService(IRepository<TaskEntity> taskRepository, IMapper mapper) {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id) {
            return await _taskRepository.DeleteAsync(id);
        }

        public async Task<List<TaskDto>> GetAll() {
            var entities = await _taskRepository.GetAllAsync();

            return _mapper.Map<List<TaskDto>>(entities);
        }

        public async Task<TaskDto> GetSingle(Guid id) {
            var entity = await _taskRepository.SelectAsync(id);

            return _mapper.Map<TaskDto>(entity);
        }

        public async Task<TaskDto> Insert(TaskAddDto taskAddDto) {
            var dtoToEntity = _mapper.Map<TaskEntity>(taskAddDto);
            var entity = await _taskRepository.InsertAsync(dtoToEntity);

            return _mapper.Map<TaskDto>(entity);
        }

        public async Task<TaskDto> Update(TaskUpdateDto taskUpdateDto) {
            var dtoToEntity = _mapper.Map<TaskEntity>(taskUpdateDto);
            var entity = _mapper.Map<TaskDto>(dtoToEntity);

            return _mapper.Map<TaskDto>(entity);
        }
    }
}
