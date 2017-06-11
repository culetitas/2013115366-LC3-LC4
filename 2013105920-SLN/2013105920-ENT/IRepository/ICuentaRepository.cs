using _2013115366_ENT.Entities;
using _2013115366_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013115366_ENT.IRepository
{
    public interface ICuentaRepository : IRepository<Cuenta>
    {
        //  IEnumerable<Cuenta> getCuentaxBaseDatos(BaseDatos BaseDatos);
    }
}
