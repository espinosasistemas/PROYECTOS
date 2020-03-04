using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IRutaManager:IGenericManager<ruta>
    {
        IEnumerable<ruta> BuscaPorNombreRuta(string nombre);
        IEnumerable<ruta> BuscarPorIdCliente(int idCliente);

        /// <summary>
        /// Busca una ruta con el nombre exacto
        /// </summary>
        /// <param name="nombre">Nombre de la ruta a buscar</param>
        /// <returns>Una ruta con el mismo nombre</returns>
        ruta BuscarPorNombreExacto(string nombre);
    }
}
