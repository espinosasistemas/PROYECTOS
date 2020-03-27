using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class FacturaManager : GenericManager<factura>, IFacturaManager
    {
        public FacturaManager(IGenericRepository<factura> repositorio) : base(repositorio)
        {

        }
    }
}
