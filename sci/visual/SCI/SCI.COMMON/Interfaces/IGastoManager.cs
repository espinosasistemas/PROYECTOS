using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IGastoManager:IGenericManager<gasto>
    {
        IEnumerable<gasto>BuscarPorIdViajeOps(int idViajeOps);

        IEnumerable<gasto> BuscarPorIdViajeyOperador(int idViajeOps, int idOperador);

        IEnumerable<gasto> BuscarGastosPorRangoFechas(DateTime fechaInicio, DateTime fechaFinal);

        IEnumerable<gasto> BuscarPorTipoGasto(int idTipoGasto, DateTime fechaInicio, DateTime fechaFinal);
    }
}
