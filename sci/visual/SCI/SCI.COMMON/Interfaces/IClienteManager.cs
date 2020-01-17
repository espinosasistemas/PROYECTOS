using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IClienteManager : IGenericManager<cliente>
    {
        /// <summary>
        /// Regresa un cliente por su RFC
        /// </summary>
        /// <param name="rfc">RFC del cliente</param>
        /// <returns>Regresa el cliente encontrado</returns>
        cliente BuscaClientePorRfc(string rfc);

    }
}
