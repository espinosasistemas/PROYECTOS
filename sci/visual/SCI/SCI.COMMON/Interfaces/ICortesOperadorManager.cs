using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ICortesOperadorManager:IGenericManager<cortesoperador>
    {
        IEnumerable<cortesoperador> BuscarCortesPorIdViaje(int idViajeOps);
    }
}
