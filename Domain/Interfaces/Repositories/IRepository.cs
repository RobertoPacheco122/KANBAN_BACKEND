using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories {
    public interface IRepository<T> where T : BaseEntity {
        Task<bool> DeleteAsync(int id);
        Task<bool> ExistAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> InsertAsync(T entity);
        Task<T> SelectAsync(int id);
        Task<T> UpdateAsync(T entity);
    }
}
