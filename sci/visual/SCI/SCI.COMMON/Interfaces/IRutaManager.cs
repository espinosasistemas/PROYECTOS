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

        
    }
}
