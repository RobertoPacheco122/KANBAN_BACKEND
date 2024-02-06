using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Implementations {
    public class TaskImplementation : BaseRepository<TaskEntity>, ITaskRepository {
        private DbSet<TaskEntity> _dataset;

        public TaskImplementation(DataContext context) : base(context) {
            _dataset = context.Set<TaskEntity>();
        }

        public async Task<TaskEntity> GetAllRelatedDetails(Guid id) {
            try {
                var queryResult = await _dataset
                    .Include(task => task.Tags)
                    .Include(task => task.Users)
                    .Include(task => task.Subtasks)
                    .FirstOrDefaultAsync(task => task.Id == id);

                return queryResult;
            } catch (Exception exception) {
                throw;
            }
        }
    }
}
