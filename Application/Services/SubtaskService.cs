using AutoMapper;
using Domain.DTOs.Subtask;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class SubtaskService : ISubtaskService {
        private readonly IRepository<SubtaskEntity> _subtaskRepository;
        private readonly IMapper _mapper;

        public SubtaskService(IRepository<SubtaskEntity> subtaskRepository, IMapper mapper) {
            _subtaskRepository = subtaskRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id) {
            return await _subtaskRepository.DeleteAsync(id);
        }

        public async Task<List<SubtaskDto>> GetAll() {
            var entities = await _subtaskRepository.GetAllAsync();
            
            return _mapper.Map<List<SubtaskDto>>(entities);
        }

        public async Task<SubtaskDto> GetSingle(Guid id) {
            var entity = await _subtaskRepository.SelectAsync(id);

            return _mapper.Map<SubtaskDto>(entity);
        }

        public async Task<SubtaskDto> Insert(SubtaskAddDto subtaskAddDto) {
            var dtoToEntity = _mapper.Map<SubtaskEntity>(subtaskAddDto);
            var entity = await _subtaskRepository.InsertAsync(dtoToEntity);

            return _mapper.Map<SubtaskDto>(entity);
        }
        public async Task<SubtaskDto> Update(SubtaskUpdateDto subtaskUpdateDto) {
            var dtoToEntity = _mapper.Map<SubtaskEntity>(subtaskUpdateDto);
            var entity = await _subtaskRepository.UpdateAsync(dtoToEntity);

            return _mapper.Map<SubtaskDto>(entity);
        }
    }
}
