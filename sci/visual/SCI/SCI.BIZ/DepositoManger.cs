using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class DepositoManger : GenericManager<deposito>, IDepositoManager
    {
        public DepositoManger(IGenericRepository<deposito> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<deposito> BuscarDepositosPorVIaje(int idViajeSci, int idOperador)
        {
            return repository.Query(d => d.IdViajeSci == idViajeSci && d.IdOperador == idOperador);
        }
    }
}
