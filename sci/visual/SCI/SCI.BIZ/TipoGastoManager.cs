using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class TipoGastoManager : GenericManager<tipogasto>, ITipoDeGastoManager
    {
        public TipoGastoManager(IGenericRepository<tipogasto> repositorio) : base(repositorio)
        {
        }

        public tipogasto BuscaPorConcepto(string concepto)
        {
            return repository.Query(t => t.Concepto == concepto).SingleOrDefault();
        }
    }
}
