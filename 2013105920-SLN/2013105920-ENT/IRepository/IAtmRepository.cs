using _2013115366_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using _2013115366_ENT.IRepositories;

namespace _2013115366_ENT.IRepository
{
    public interface IAtmRepository : IRepository<Atm>
    {
        //  IEnumerable<ATM> getATMxRanura(RanuraDeposito RanuraDeposito);
        //  IEnumerable<ATM> getATMxTeclado(Teclado Teclado);
        //  IEnumerable<ATM> getATMxDispensadorEfectivo(DispensadorEfectivo DispensadorEfectivo);
        //  IEnumerable<ATM> getATMxPantalla(Pantalla Pantalla);
        //  IEnumerable<ATM> getATMxRetiro(Retiro Retiro);
        //  IEnumerable<ATM> getATMxBaseDatos(BaseDatos BaseDatos);
        new
        //  IEnumerable<ATM> getATMxRanura(RanuraDeposito RanuraDeposito);
        //  IEnumerable<ATM> getATMxTeclado(Teclado Teclado);
        //  IEnumerable<ATM> getATMxDispensadorEfectivo(DispensadorEfectivo DispensadorEfectivo);
        //  IEnumerable<ATM> getATMxPantalla(Pantalla Pantalla);
        //  IEnumerable<ATM> getATMxRetiro(Retiro Retiro);
        //  IEnumerable<ATM> getATMxBaseDatos(BaseDatos BaseDatos);
        object GetAll();
        new IEnumerable GetEntity();
    }
}
