using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class StatusViajeManager : GenericManager<statusviaje>, IStatusViajeManager
    {
        public StatusViajeManager(IGenericRepository<statusviaje> repositorio) : base(repositorio)
        {
        }

        public statusviaje BuscaPorStatus(string status)
        {
            return repository.Query(s => s.Nombre == status).SingleOrDefault();
        }
    }
}
