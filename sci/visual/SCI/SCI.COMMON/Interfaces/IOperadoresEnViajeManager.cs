using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IOperadoresEnViajeManager:IGenericManager<operadoresenviaje>
    {
        /// <summary>
        /// Busca todos los operadores en un viaje determinado
        /// </summary>
        /// <param name="idViajeOps">Clave del Viaje a buscar</param>
        /// <returns>Regresa una colección de operadoresenviaje</returns>
        IEnumerable<operadoresenviaje> BuscarPorIdViajeOps(int idViajeOps);


        operadoresenviaje BuscarPorIdViajeOpsyOperador(int idViajeOps,int idOperador);

        operadoresenviaje BuscarOperadorPoscionMenor(int idViaje, int Posicion);

    }
}
