using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IViajeManager : IGenericManager<viaje>
    {
        viaje BuscarPorIdCliente(string idViajeCliente);

        List<viaje> BuscarViajes(DateTime fechaInicio, DateTime fechaFinal);

        List<viaje> BuscarViajesPorRuta(int idRuta, DateTime fechaInicio, DateTime fechaFinal);
    }
}
