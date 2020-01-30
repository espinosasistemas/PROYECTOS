using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class GasolineriaManager : GenericManager<gasolineria>, IGasolineriaManager
    {
        public GasolineriaManager(IGenericRepository<gasolineria> repositorio) : base(repositorio)
        {
        }
    }
}
