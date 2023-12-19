using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services {
    public class ApplicationUserService : IApplicationUserService {
        private readonly IRepository<ApplicationUserEntity> _userRepository;
        public ApplicationUserService(IRepository<ApplicationUserEntity> userRepository) {
            _userRepository = userRepository;
        }

        public async Task<bool> Delete(int id) {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<List<ApplicationUserEntity>> GetAll() {
            return await _userRepository.GetAllAsync();
        }

        public async Task<ApplicationUserEntity> GetSingle(int id) {
            return await _userRepository.SelectAsync(id);
        }

        public async Task<ApplicationUserEntity> Insert(ApplicationUserEntity aluno) {
            return await _userRepository.InsertAsync(aluno);
        }

        public async Task<ApplicationUserEntity> Update(ApplicationUserEntity aluno) {
            return await _userRepository.UpdateAsync(aluno);
        }
    }
}
