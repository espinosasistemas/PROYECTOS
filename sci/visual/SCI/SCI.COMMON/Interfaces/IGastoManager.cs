using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IGastoManager:IGenericManager<gasto>
    {
        IEnumerable<gasto>BuscarPorIdViajeOps(int idViajeOps);

        /// <summary>
        /// Busca Todos los gastos de un Operador en un Viaje
        /// </summary>
        /// <param name="idViajeOps">Clave del Viaje</param>
        /// <param name="idOperador">Clave del Operador</param>
        /// <returns>Regresa null si no hay o una coleccion de gastos en caso de que existan.</returns>
        IEnumerable<gasto> BuscarPorIdViajeyOperador(int idViajeOps, int idOperador);

        IEnumerable<gasto> BuscarGastosPorRangoFechas(DateTime fechaInicio, DateTime fechaFinal);

        IEnumerable<gasto> BuscarPorTipoGasto(int idTipoGasto, DateTime fechaInicio, DateTime fechaFinal);

    }
}
