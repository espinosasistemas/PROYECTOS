using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IDepositoManager:IGenericManager<deposito>
    {
        IEnumerable<deposito> BuscarDepositosPorVIaje(int idViajeSci, int idOperador);
    }
}
