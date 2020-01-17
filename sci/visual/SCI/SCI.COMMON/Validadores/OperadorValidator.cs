using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class OperadorValidator : AbstractValidator<operador>
    {
        public OperadorValidator()
        {
            RuleFor(o => o.Nombre).NotEmpty().NotNull().Length(1, 100);
            RuleFor(o =>o.Apellidos).NotEmpty().NotNull().Length(1, 100);
            RuleFor(o => o.FechaIngreso).NotEmpty().NotNull();
            RuleFor(o => o.Salarioporhora).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(o => o.Direccion).NotEmpty().NotNull().Length(1, 500);
        }
    }
}
