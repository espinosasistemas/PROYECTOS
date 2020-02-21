using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class OperadoresEnViajeManager : GenericManager<operadoresenviaje>, IOperadoresEnViajeManager
    {
        public OperadoresEnViajeManager(IGenericRepository<operadoresenviaje> repositorio) : base(repositorio)
        {

        }

        public IEnumerable<operadoresenviaje> BuscarPorIdViajeOps(int idViajeOps)
        {
            return repository.Query(g => g.IdViajeSci == idViajeOps);
        }

        public operadoresenviaje BuscarPorIdViajeOpsyOperador(int idViajeOps, int idOperador)
        {
            return repository.Read.Where(o => o.IdViajeSci == idViajeOps && o.IdOperador == idOperador).SingleOrDefault();
        }
    }
}
