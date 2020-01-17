using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface ILogManager:IGenericManager<log>
    {
        log BuscaMovimientoPorUsuario(string idUsuario, DateTime fechaInicio, DateTime fechaFin);

        log BuscaPorModuloAfectado(string moduloAfectado, DateTime fechaInicio, DateTime fechaFin);
    }
}
