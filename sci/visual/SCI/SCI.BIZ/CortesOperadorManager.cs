using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class CortesOperadorManager : GenericManager<cortesoperador>, ICortesOperadorManager
    {
        public CortesOperadorManager(IGenericRepository<cortesoperador> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<cortesoperador> BuscarCortesPorIdViaje(int idViajeOps)
        {
            return repository.Query(c => c.IdViajeOps == idViajeOps);
        }
    }
}
