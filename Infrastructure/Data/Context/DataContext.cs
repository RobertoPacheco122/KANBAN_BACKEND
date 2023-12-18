using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Context {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ApplicationUserEntity> Users => Set<ApplicationUserEntity>();
        public DbSet<BoardEntity> Boards => Set<BoardEntity>();
        public DbSet<ListEntity> Lists => Set<ListEntity>();
        public DbSet<SubtaskEntity> Subtasks => Set<SubtaskEntity>();
        public DbSet<TagEntity> Tags => Set<TagEntity>();
        public DbSet<TaskEntity> Tasks => Set<TaskEntity>();

    }
}
