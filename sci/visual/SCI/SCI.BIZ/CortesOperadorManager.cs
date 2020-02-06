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

        public IEnumerable<cortesoperador> BuscarCortesPorIdViaje(int idViajeSci)
        {
            return repository.Query(v => v.IdViajeSci == idViajeSci);
        }

        public IEnumerable<cortesoperador> BuscarCortesPorOperadorEnViaje(int idViajeSci, int idOperador)
        {
            return repository.Query(c=>c.IdViajeSci==idViajeSci && c.IdOperador == idOperador);
        }
    }
}
