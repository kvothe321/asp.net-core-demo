using asp.net_core_demo.Database;
using asp.net_core_demo.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_demo.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        private readonly DataContext _dataContext;

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        #region CRUD operations. Interface defined methods.
        public async Task<T> CreateAsync(T t)
        {
            _dataContext.Set<T>().Add(t);
            await _dataContext.SaveChangesAsync();
            return t;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var entity = await _dataContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> ReadAllAsync()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public async Task<T> ReadAsync(int id)
        {
            var entity = await _dataContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            return entity;
        }

        public async Task<T> UpdateAsync(T t)
        {
            _dataContext.Entry(t).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
            return t;
        }
        #endregion
    }
}
