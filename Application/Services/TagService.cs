using AutoMapper;
using Domain.DTOs.Tag;
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
        private readonly IMapper _mapper;

        public TagService(IRepository<TagEntity> tagRepository, IMapper mapper) {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id) {
            return await _tagRepository.DeleteAsync(id);
        }

        public async Task<List<TagDto>> GetAll() {
            var entities = await _tagRepository.GetAllAsync();

            return _mapper.Map<List<TagDto>>(entities);
        }

        public async Task<TagDto> GetSingle(Guid id) {
            var entity = await _tagRepository.SelectAsync(id);

            return _mapper.Map<TagDto>(entity);
        }

        public async Task<TagDto> Insert(TagAddDto tagAddDto) {
            var dtoToEntity = _mapper.Map<TagEntity>(tagAddDto);
            var entity = await _tagRepository.InsertAsync(dtoToEntity);

            return _mapper.Map<TagDto>(entity);
        }

        public async Task<TagDto> Update(TagUpdateDto tagUpdateDto) {
            var dtoToEntity = _mapper.Map<TagEntity>(tagUpdateDto);
            var entity = await _tagRepository.UpdateAsync(dtoToEntity);

            return _mapper.Map<TagDto>(entity);
        }
    }
}
