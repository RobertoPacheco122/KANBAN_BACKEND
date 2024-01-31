using Domain.DTOs.ApplicationUser;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IApplicationUserService {
        Task<bool> Delete(Guid id);
        Task<List<ApplicationUserDto>> GetAll();
        Task<ApplicationUserDto> GetSingle(Guid id);
        Task<ApplicationUserDto> Insert(ApplicationUserAddDto applicationUserAddDto);
        Task<ApplicationUserDto> Update(ApplicationUserUpdateDto applicationUserUpdateDto);
    }
}
