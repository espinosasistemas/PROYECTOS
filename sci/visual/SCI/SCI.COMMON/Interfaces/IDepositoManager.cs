using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IDepositoManager:IGenericManager<deposito>
    {
        //IEnumerable<deposito> BuscarDepositosPorVIaje(int idViajeSci, int idOperador);

        /// <summary>
        /// Busca todos los depositos hechos a un operador en un viaje.
        /// </summary>
        /// <param name="idViajeOps">Recibe el id del Viaje de SCI</param>
        /// <param name="idOperador">Recibe el id del operador </param>
        /// <returns>Regresa una colección de depositos asociados a un operador en un viaje.</returns>
        IEnumerable<deposito> BuscarPorIdViajeyOperador(int idViajeSci, int idOperador);
    }
}
