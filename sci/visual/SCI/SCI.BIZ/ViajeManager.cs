using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class ViajeManager : GenericManager<viaje>, IViajeManager
    {
        public ViajeManager(IGenericRepository<viaje> repositorio) : base(repositorio)
        {
        }

        public viaje BuscarPorIdCliente(string idViajeCliente)
        {
            return repository.Query(v => v.IdViajeCliente == idViajeCliente).SingleOrDefault();
        }

        public IEnumerable<viaje> BuscarViajesOps(DateTime fechaInicio, DateTime fechaFinal)
        {
            DateTime rInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 0, 0, 0).AddDays(1);
            return repository.Query(v => v.FechaInicioSci >= rInicio && v.FechaFinSci < rFin);
        }

        public IEnumerable<viaje> BuscarViajesPorRuta(int idRuta, DateTime fechaInicio, DateTime fechaFinal)
        {
            DateTime rInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day, 0, 0, 0);
            DateTime rFin = new DateTime(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 0, 0, 0).AddDays(1);
            return repository.Query(v => v.FechaInicioSci >= rInicio && v.FechaFinSci < rFin && v.IdRuta==idRuta);
        }

        public IEnumerable<viaje> BuscarViajesPorStatus(int idStatusViaje)
        {
            return repository.Query(v => v.IdStatus == idStatusViaje);
        }
    }
}
