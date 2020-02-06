using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class GasolineriaManager : GenericManager<gasolineria>, IGasolineriaManager
    {
        public GasolineriaManager(IGenericRepository<gasolineria> repositorio) : base(repositorio)
        {
        }

        public gasolineria BuscarPorRfc(string rfc)
        {
            return repository.Query(g => g.Rfc == rfc).SingleOrDefault();
        }
    }
}
