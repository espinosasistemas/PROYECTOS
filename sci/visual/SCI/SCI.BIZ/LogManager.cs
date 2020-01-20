using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class LogManager : GenericManager<log>, ILogManager
    {


        public LogManager(IGenericRepository<log> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<log> BuscaMovimientoPorUsuario(string nombreUsuario, DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime rInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, 0, 0, 0).AddDays(1);
            return repository.Query(l => l.NombreUsuario == nombreUsuario && l.Fecha >= rInicio && l.Fecha < rFin);
        }

        public IEnumerable<log> BuscaPorModuloAfectado(string moduloAfectado, DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime rInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, 0, 0, 0).AddDays(1);
            return repository.Query(l => l.ModuloAfectado == moduloAfectado && l.Fecha >= rInicio && l.Fecha < rFin);
        }
    }
}
