using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class CasetaValidator:AbstractValidator<caseta>
    {
        public CasetaValidator()
        {
            RuleFor(s => s.Nombre).NotNull().NotEmpty().Length(1, 200);
            RuleFor(s => s.Costo).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(s => s.IdTipoDeUnidad).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(s => s.IdTipoDeGasto).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
