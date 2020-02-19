using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class RutaManager : GenericManager<ruta>, IRutaManager
    {
        public RutaManager(IGenericRepository<ruta> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<ruta> BuscaPorNombreRuta(string nombre)
        {
            return repository.Query(r => r.Nombre.ToLower().Contains(nombre.ToLower()));
        }

        public IEnumerable<ruta> BuscarPorIdCliente(int idCliente)
        {
            return repository.Query(r => r.IdCliente == idCliente);
        }
    }
}
