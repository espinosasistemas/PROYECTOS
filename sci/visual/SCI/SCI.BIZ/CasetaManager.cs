using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class CasetaManager : GenericManager<caseta>, ICasetaManager
    {
        public CasetaManager(IGenericRepository<caseta> repositorio) : base(repositorio)
        {
        }

        public caseta BuscarCasetaPorNombre(string nombre, int tipoDeUnidad)
        {
            return repository.Query(c => c.Nombre == nombre && c.IdTipoDeUnidad==tipoDeUnidad).SingleOrDefault();
        }

        public IEnumerable<caseta> BuscarCasetaPorTipoDeUnidad(int tipoUnidad)
        {
            return repository.Query(u=>u.IdTipoDeUnidad==tipoUnidad);
        }
    }
}
