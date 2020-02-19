using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class RutaValidator:AbstractValidator<ruta>
    {
        public RutaValidator()
        {
            RuleFor(r => r.Nombre).NotNull().NotEmpty().Length(1, 200);
            RuleFor(r => r.Costo).NotNull().NotEmpty().GreaterThan(-1);
            RuleFor(r => r.UnidadAFacturar).NotNull().NotEmpty().Length(1, 20);
            RuleFor(r => r.IdCliente).NotNull().NotEmpty().GreaterThan(0);
            //RuleFor(r => r.IdTipoDeUnidad).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
