using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class ClienteManager : GenericManager<cliente>, IClienteManager
    {
        public ClienteManager(IGenericRepository<cliente> repositorio) : base(repositorio)
        {
        }

        public cliente BuscaClientePorRfc(string rfc)
        {
            return repository.Query(c => c.Rfc == rfc).SingleOrDefault();
        }
    }
}
