using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class TipoDeUnidadManager : GenericManager<tipounidad>, ITipoDeUnidadManager
    {
        public TipoDeUnidadManager(IGenericRepository<tipounidad> repositorio) : base(repositorio)
        {
        }

        /*public tipounidad BuscaPorDescripcion(string descripcion)
        {
            return repository.Query(s => s.Descripcion == descripcion).SingleOrDefault();
        }
        */

    }
}
