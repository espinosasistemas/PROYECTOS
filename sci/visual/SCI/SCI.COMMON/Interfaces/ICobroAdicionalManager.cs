using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ICobroAdicionalManager: IGenericManager<cobrosadicionales>
    {
        /// <summary>
        /// Muestra todos los cobros adicionales hechos en un Viaje en específico.
        /// </summary>
        /// <param name="idViajeSci">Recibe el id del viaje para buscar sus cobros</param>
        /// <returns>Regresa una colección de cobros asociados al viaje.</returns>
        IEnumerable<cobrosadicionales> BuscarCobrosPorViaje(int idViajeSci);
    }
}
