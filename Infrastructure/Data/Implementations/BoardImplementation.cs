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
    public class BoardImplementation : BaseRepository<BoardEntity>, IBoardRepository {
        private DbSet<BoardEntity> _dataset;

        public BoardImplementation(DataContext context) : base(context) {
            _dataset = context.Set<BoardEntity>();
        }

        public async Task<BoardEntity> GetAllRelatedDetails(Guid id) {
            try {
                var queryResult = await _dataset.
                    Include(board => board.Lists.OrderBy(list => list.CreationDate))
                        .ThenInclude(list => list.Tasks.OrderBy(task => task.CreationDate))
                            .ThenInclude(task => task.Users)
                                .ThenInclude(user => user.Tasks)
                            .ThenInclude(task => task.Tags)
                    .FirstOrDefaultAsync(board => board.Id == id);

                return queryResult;
            } catch (Exception expection) {
                throw;
            }
        }
    }
}
