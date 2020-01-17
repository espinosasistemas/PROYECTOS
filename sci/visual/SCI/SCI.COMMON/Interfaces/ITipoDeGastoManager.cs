using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ITipoDeGastoManager:IGenericManager<tipogasto>
    {
        /// <summary>
        /// Busca un tipo de gasto
        /// </summary>
        /// <param name="tipo">tipo de Gasto</param>
        /// <returns>Regresa el tipo de Gasto</returns>
        tipogasto BuscaPorTipoGasto(string tipo);
    }
}
