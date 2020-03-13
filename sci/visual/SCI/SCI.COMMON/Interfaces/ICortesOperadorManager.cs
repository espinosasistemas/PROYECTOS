using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ICortesOperadorManager:IGenericManager<cortesoperador>
    {
        /// <summary>
        /// Muestra todos los cortes asociados al viaje
        /// </summary>
        /// <param name="idViajeOps">Recibe el id del viaje</param>
        /// <returns>Regresa una colección de todos los cortes asociados al viaje</returns>
        IEnumerable<cortesoperador> BuscarCortesPorIdViaje(int idViajeOps);

        /// <summary>
        /// Los cortes asociados al viaje los filtra por operador
        /// </summary>
        /// <param name="idViajeSci">Recibe el id del Viaje</param>
        /// <param name="idOperador">Recibe el id del Operador</param>
        /// <returns>Regresa una colección de cortes asociados al operador en el viaje</returns>
        IEnumerable<cortesoperador> BuscarCortesPorOperadorEnViaje(int idViajeSci, int idOperador);

    }
}
