using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class GastoManager : GenericManager<gasto>, IGastoManager
    {
        public GastoManager(IGenericRepository<gasto> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<gasto> BuscarPorIdViajeOps(int idViajeSci)
        {
            return repository.Query(g => g.IdViajeSci == idViajeSci);
        }

        public IEnumerable<gasto> BuscarGastosPorRangoFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
            DateTime rInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 0, 0, 0).AddDays(1);
            return repository.Query(g => g.Fecha >= rInicio && g.Fecha < rFin);
        }

        public IEnumerable<gasto> BuscarPorTipoGasto(int idTipoGasto, DateTime fechaInicio, DateTime fechaFinal)
        {
            DateTime rInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 0, 0, 0).AddDays(1);
            return repository.Query(g => g.Fecha >= rInicio && g.Fecha < rFin && g.IdTipoGasto==idTipoGasto);
        }

        public IEnumerable<gasto> BuscarPorIdViajeyOperador(int idViajeSci, int idOperador)
        {
            return repository.Query(g => g.IdViajeSci == idViajeSci && g.IdOperador == idOperador);
        }
    }
}
