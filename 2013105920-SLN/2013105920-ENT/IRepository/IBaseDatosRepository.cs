using _2013115366_ENT.Entities;
using _2013115366_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013115366_ENT.IRepository
{
    public interface IBaseDatosRepository : IRepository<BaseDatos>
    {
        //   IEnumerable<BaseDatos> getBaseDatosxATM(ATM ATM);
        //   IEnumerable<BaseDatos> getBaseDatosxRetiro(Retiro Retiro);
        //   IEnumerable<BaseDatos> getBaseDatosxCuenta(Cuenta Cuenta);
    }
}
