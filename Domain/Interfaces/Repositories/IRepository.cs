using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories {
    public interface IRepository<T> where T : BaseEntity {
        Task<bool> DeleteAsync(Guid id);
        Task<bool> ExistAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task<T> InsertAsync(T entity);
        Task<T> SelectAsync(Guid id);
        Task<T> UpdateAsync(T entity);
    }
}
