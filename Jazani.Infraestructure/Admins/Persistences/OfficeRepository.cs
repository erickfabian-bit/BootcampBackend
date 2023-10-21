using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using Jazani.Infraestructure.Cores.Contexts;
using Jazani.Infraestructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infraestructure.Admins.Persistences
{
    public class OfficeRepository : CrudRepository<Office, int>, IOfficeRepository
    {
        public OfficeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
