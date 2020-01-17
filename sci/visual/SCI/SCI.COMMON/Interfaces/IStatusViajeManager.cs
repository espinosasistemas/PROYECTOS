using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IStatusViajeManager:IGenericManager<statusviaje>
    {
        statusviaje BuscaPorStatus(string status);
    }
}
