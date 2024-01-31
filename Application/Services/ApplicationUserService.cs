using AutoMapper;
using Domain.DTOs.ApplicationUser;
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
        private readonly IMapper _mapper;

        public ApplicationUserService(IRepository<ApplicationUserEntity> userRepository, IMapper mapper) {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id) {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<List<ApplicationUserDto>> GetAll() {
            var entities = await _userRepository.GetAllAsync();

            return _mapper.Map<List<ApplicationUserDto>>(entities);
        }

        public async Task<ApplicationUserDto> GetSingle(Guid id) {
            var entity = await _userRepository.SelectAsync(id);

            return _mapper.Map<ApplicationUserDto>(entity);
        }

        public async Task<ApplicationUserDto> Insert(ApplicationUserAddDto applicationUserAddDto) {
            var dtoToEntity = _mapper.Map<ApplicationUserEntity>(applicationUserAddDto);
            var entity = await _userRepository.InsertAsync(dtoToEntity);

            return _mapper.Map<ApplicationUserDto>(entity);
        }

        public async Task<ApplicationUserDto> Update(ApplicationUserUpdateDto applicationUserUpdateDto) {
            var dtoToEntity = _mapper.Map<ApplicationUserEntity>(applicationUserUpdateDto);
            var entity = await _userRepository.UpdateAsync(dtoToEntity);

            return _mapper.Map<ApplicationUserDto>(entity);
        }
    }
}
