using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ILogManager:IGenericManager<log>
    {
        IEnumerable<log> BuscaMovimientoPorUsuario(string nombreUsuario, DateTime fechaInicio, DateTime fechaFin);

        IEnumerable<log> BuscaPorModuloAfectado(string moduloAfectado, DateTime fechaInicio, DateTime fechaFin);
    }
}
