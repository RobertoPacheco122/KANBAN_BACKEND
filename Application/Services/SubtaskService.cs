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
        public SubtaskService(IRepository<SubtaskEntity> subtaskRepository) {
            _subtaskRepository = subtaskRepository;
        }

        public async Task<bool> Delete(int id) {
            return await _subtaskRepository.DeleteAsync(id);
        }

        public async Task<List<SubtaskEntity>> GetAll() {
            return await _subtaskRepository.GetAllAsync();
        }

        public async Task<SubtaskEntity> GetSingle(int id) {
            return await _subtaskRepository.SelectAsync(id);
        }

        public async Task<SubtaskEntity> Insert(SubtaskEntity subtask) {
            return await _subtaskRepository.InsertAsync(subtask);
        }
        public async Task<SubtaskEntity> Update(SubtaskEntity subtask) {
            return await _subtaskRepository.UpdateAsync(subtask);
        }
    }
}
