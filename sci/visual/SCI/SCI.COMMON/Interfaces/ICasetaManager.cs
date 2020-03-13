using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ICasetaManager: IGenericManager<caseta>
    {
        /// <summary>
        /// Busca una caseta por el nombre exacto
        /// </summary>
        /// <param name="nombre">Nombre de la caseta a buscar</param>
        /// <returns>regresa un objeto tipo caseta si es que lo encuentra</returns>
        caseta BuscarCasetaPorNombre(string nombre, int tipoUnidad);


        /// <summary>
        /// Busca casetas por tipo de unidad, el costo es diferente por trailer, thorton, camioneta, etc.
        /// </summary>
        /// <param name="tipoUnidad">Tipo de unidad para filtrar</param>
        /// <returns>Todas las casetas por tipo de unidad</returns>
        IEnumerable<caseta> BuscarCasetaPorTipoDeUnidad(int tipoUnidad);
    }
}
