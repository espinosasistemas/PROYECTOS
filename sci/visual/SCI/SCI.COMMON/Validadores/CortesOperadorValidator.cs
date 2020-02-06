using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class CortesOperadorValidator:AbstractValidator<cortesoperador>
    {
        public CortesOperadorValidator()
        {
            RuleFor(c => c.FechaInicio).NotNull().NotEmpty();
            RuleFor(c => c.FechaFin).NotNull().NotEmpty();
            RuleFor(c => c.Costo).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(c => c.Horas).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(c => c.IdViajeSci).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(c => c.IdOperador).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(c => c.IdStatus).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
