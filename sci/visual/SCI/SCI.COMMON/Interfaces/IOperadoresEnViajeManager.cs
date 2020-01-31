using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IOperadoresEnViajeManager:IGenericManager<operadoresenviaje>
    {
        IEnumerable<operadoresenviaje> BuscarPorIdViajeOps(int idViajeOps);
        operadoresenviaje BuscarPorIdViajeOpsyOperador(int idViajeOps,int idOperador);
    }
}
