using AutoMapper;
using Domain.DTOs.List;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class ListService : IListService {
        private readonly IRepository<ListEntity> _listRepository;
        private readonly IMapper _mapper;

        public ListService(IRepository<ListEntity> listRepository, IMapper mapper) {
            _listRepository = listRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id) {
            return await _listRepository.DeleteAsync(id);
        }

        public async Task<List<ListDto>> GetAll() {
            var entities = await _listRepository.GetAllAsync();

            return _mapper.Map<List<ListDto>>(entities);
        }

        public async Task<ListDto> GetSingle(Guid id) {
            var entity = await _listRepository.SelectAsync(id);

            return _mapper.Map<ListDto>(entity); 
        }

        public async Task<ListDto> Insert(ListAddDto listDto) {
            var dtoConvertedToEntity = _mapper.Map<ListEntity>(listDto);
            var entity = await _listRepository.InsertAsync(dtoConvertedToEntity);

            return _mapper.Map<ListDto>(entity);
        }

        public async Task<ListDto> Update(ListUpdateDto listDto) {
            var dtoConvertedToEntity = _mapper.Map<ListEntity>(listDto);
            var entity = await _listRepository.UpdateAsync(dtoConvertedToEntity);

            return _mapper.Map<ListDto>(entity); 
        }
    }
}
