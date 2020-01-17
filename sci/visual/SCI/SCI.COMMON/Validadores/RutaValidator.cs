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
            RuleFor(r => r.IdUnidad).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
