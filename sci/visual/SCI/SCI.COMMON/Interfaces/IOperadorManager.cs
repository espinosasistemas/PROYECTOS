using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IOperadorManager : IGenericManager<operador>
    {
        /// <summary>
        /// Busca en la lista de Operadores, los que contienen el nombre
        /// </summary>
        /// <param name="nombre">Nombre a bucar</param>
        /// <returns>Regresa una lita de operadores con ese nombre</returns>
        IEnumerable<operador> BuscarPorNombre(string nombre);

        /// <summary>
        /// Busca un solo operador por nombre completo
        /// </summary>
        /// <param name="nombreCompleto">Nombre + Apellido</param>
        /// <returns>Un operador</returns>
        operador BuscarPorNombreExacto(string nombreCompleto);
    }
}
