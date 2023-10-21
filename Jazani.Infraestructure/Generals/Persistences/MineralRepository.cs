using Jazani.Domain.Generals.Models;
using Jazani.Domain.Generals.Repositories;
using Jazani.Infraestructure.Cores.Contexts;
using Jazani.Infraestructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infraestructure.Generals.Persistences
{
    public class MineralRepository : CrudRepository<Mineral, int>, IMineralRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MineralRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<IReadOnlyList<Mineral>> FindAllAsync()
        {
            return await _dbContext.Set<Mineral>()
                .Include(t => t.MineralType)
                .AsNoTracking()
                .ToListAsync();
        }

        public override async Task<Mineral?> FindByIdAsync(int id)
        {
            return await _dbContext.Set<Mineral>()
                .Include(t => t.MineralType)
                .FirstOrDefaultAsync();
        }
    }
}
