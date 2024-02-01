using Domain.DTOs.Tag;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface ITagService {
        Task<bool> Delete(Guid id);
        Task<List<TagDto>> GetAll();
        Task<TagDto> GetSingle(Guid id);
        Task<TagDto> Insert(TagAddDto tagAddDto);
        Task<TagDto> Update(TagUpdateDto tagUpdateDto);
    }
}
