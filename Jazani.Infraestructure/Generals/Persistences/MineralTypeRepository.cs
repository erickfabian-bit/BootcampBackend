using Jazani.Domain.Generals.Models;
using Jazani.Domain.Generals.Repositories;
using Jazani.Infraestructure.Cores.Contexts;
using Jazani.Infraestructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Infraestructure.Generals.Persistences
{
    public class MineralTypeRepository : CrudRepository<MineralType, int>, IMineralTypeRepository
    {
        public MineralTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
