using Jazani.Domain.Cores.Repositories;
using Jazani.Infraestructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infraestructure.Cores.Persistences
{
    public abstract class CrudRepository<T, ID> : ICrudRepository<T, ID> where T : class
    {
        private readonly ApplicationDbContext _dbcontext;

        protected CrudRepository(ApplicationDbContext dbContext) 
        {
            _dbcontext = dbContext; 
        }

        public virtual async Task<IReadOnlyList<T>> FindAllAsync()
        {
            return await _dbcontext.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<T?> FindByIdAsync(ID id)
        {
            return await _dbcontext.Set<T>().FindAsync(id);
        }

        public virtual async Task<T> SaveAsync(T entity)
        {
            EntityState state = _dbcontext.Entry(entity).State;

            _ = state switch
            {
                EntityState.Detached => _dbcontext.Set<T>().Add(entity),
                EntityState.Modified => _dbcontext.Set<T>().Update(entity)
            };

            await _dbcontext.SaveChangesAsync();

            return entity;
        }
    }
}
