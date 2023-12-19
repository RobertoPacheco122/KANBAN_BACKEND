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
        public ListService(IRepository<ListEntity> listRepository) {
            _listRepository = listRepository;
        }

        public async Task<bool> Delete(int id) {
            return await _listRepository.DeleteAsync(id);
        }

        public async Task<List<ListEntity>> GetAll() {
            return await _listRepository.GetAllAsync();
        }

        public async Task<ListEntity> GetSingle(int id) {
            return await _listRepository.SelectAsync(id);
        }

        public async Task<ListEntity> Insert(ListEntity list) {
            return await _listRepository.InsertAsync(list);
        }

        public async Task<ListEntity> Update(ListEntity list) {
            return await _listRepository.UpdateAsync(list);
        }
    }
}
