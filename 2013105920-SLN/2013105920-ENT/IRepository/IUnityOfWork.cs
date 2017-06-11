using _2013115366_ENT.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013115366_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {

        IAtmRepository ATM { get; }
        IBaseDatosRepository BaseDatos { get; }
        ICuentaRepository Cuentas { get; }
        IPantallaRepository Pantallas { get; }
        IRanuraDepositoRepository RanuraDepositos { get; }
        IRetiroRepository Retiros { get; }
        ITecladoRepository Teclados { get; }
        IDispensadorEfectivoRepository DispensadorEfectivos { get; }
        object ATMs { get; set; }

        int SaveChanges();

        void StateModified(object entity);


    }
}
