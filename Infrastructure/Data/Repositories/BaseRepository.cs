using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories {
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity {
        private readonly DataContext _context;
        private DbSet<T> _dataset;

        public BaseRepository(DataContext context) {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id) {
            try {
                var entityInDatabase = await _dataset.FindAsync(id);
                if (entityInDatabase == null) return false;

                entityInDatabase.IsDeleted = true;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception exception) {
                throw;
            }
        }

        public async Task<bool> ExistAsync(Guid id) {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<List<T>> GetAllAsync() {
            try {
                var entities = await _dataset.ToListAsync();

                return entities;
            }
            catch (Exception exception) {
                throw;
            }
        }

        public async Task<T> InsertAsync(T entity) {
            try {
                entity.Id = Guid.NewGuid();
                entity.CreationDate = DateTime.UtcNow;

                _dataset.Add(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception exception) {
                throw;
            }
        }

        public async Task<T> SelectAsync(Guid id) {
            try {
                var entityInDatabase = await _dataset.FindAsync(id);
                if (entityInDatabase == null) return null;

                return entityInDatabase;
            }
            catch (Exception exception) {
                throw;
            }
        }

        public async Task<T> UpdateAsync(T entity) {
            try {
                var entityInDatabase = await _dataset.FindAsync(entity.Id);
                if (entityInDatabase == null) return null;

                entity.LastTimeModifiedDate = DateTime.UtcNow;
                entity.CreationDate = entityInDatabase.CreationDate;

                _context.Entry(entityInDatabase).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

                return entityInDatabase;
            }
            catch (Exception exception) {
                throw;
            }
        }
    }
}
