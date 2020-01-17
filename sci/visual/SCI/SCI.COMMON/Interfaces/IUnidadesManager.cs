using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IUnidadesManager:IGenericManager<unidades>
    {
        /// <summary>
        /// Busca una unidad
        /// </summary>
        /// <param name="numero">Numero Económico para buscar</param>
        /// <returns>Una sola unidad encontrada</returns>
        unidades BuscarPorNumEco(int numero);

        /// <summary>
        /// Busca una colección de unidades que usen un tipo de combustible en especifico
        /// </summary>
        /// <param name="tipoCombustible">Tipo de Combustible</param>
        /// <returns>Regresa una lista de unidades que usan cierto tipo de combustible</returns>
        List<unidades> BuscaUnidadesPorTipoCombustible(string tipoCombustible);

    }
}
