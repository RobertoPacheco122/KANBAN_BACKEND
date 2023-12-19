using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ITagService {
        Task<bool> Delete(int id);
        Task<List<TagEntity>> GetAll();
        Task<TagEntity> GetSingle(int id);
        Task<TagEntity> Insert(TagEntity tag);
        Task<TagEntity> Update(TagEntity tag);
    }
}
