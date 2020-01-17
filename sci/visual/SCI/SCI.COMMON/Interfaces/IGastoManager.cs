using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IGastoManager:IGenericManager<gasto>
    {
        gasto BuscarPorIdViajeOps(int idViajeOps);

        List<gasto> BuscarGastosPorRangoFechas(DateTime fechaInicio, DateTime fechaFinal);

        List<gasto> BuscarPorTipoGasto(int idTipoGasto, DateTime fechaInicio, DateTime fechaFinal);
    }
}
