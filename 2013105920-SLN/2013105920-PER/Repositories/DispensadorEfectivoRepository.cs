using _2013115366_ENT.Entities;
using _2013115366_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013115366_PER.Repositories
{
    public class DispensadorEfectivoRepository : Repository<DispensadorEfectivo>, IDispensadorEfectivoRepository
    
    {
        public DispensadorEfectivoRepository(CajeroDbContext context) : base(context)
        {

        }
    }
}
