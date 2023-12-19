using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class TagService : ITagService {
        private readonly IRepository<TagEntity> _tagRepository;
        public TagService(IRepository<TagEntity> tagRepository) {
            _tagRepository = tagRepository;
        }

        public async Task<bool> Delete(int id) {
            return await _tagRepository.DeleteAsync(id);
        }

        public async Task<List<TagEntity>> GetAll() {
            return await _tagRepository.GetAllAsync();
        }

        public async Task<TagEntity> GetSingle(int id) {
            return await _tagRepository.SelectAsync(id);
        }

        public async Task<TagEntity> Insert(TagEntity tag) {
            return await _tagRepository.InsertAsync(tag);
        }

        public async Task<TagEntity> Update(TagEntity tag) {
            return await _tagRepository.UpdateAsync(tag);
        }
    }
}
