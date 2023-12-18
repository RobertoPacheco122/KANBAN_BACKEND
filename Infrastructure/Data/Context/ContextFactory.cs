using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Context {
    public class ContextFactory : IDesignTimeDbContextFactory<DataContext> {
        public DataContext CreateDbContext(string[] args) {
            var connectionString = "Host=localhost;Port=5432;Database=kanbandddapi;Username=postgres;Password=fanta123";
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new DataContext(optionsBuilder.Options);
        }
    }
}
