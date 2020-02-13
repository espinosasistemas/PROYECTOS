using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IViajeManager : IGenericManager<viaje>
    {
        viaje BuscarPorIdCliente(string idViajeCliente);

        IEnumerable<viaje> BuscarViajesOps(DateTime fechaInicio, DateTime fechaFinal);

        IEnumerable<viaje> BuscarViajesPorRuta(int idRuta, DateTime fechaInicio, DateTime fechaFinal);

        IEnumerable<viaje> BuscarViajesPorStatus(int idStatusViaje);
    }
}
