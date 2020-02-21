using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class OperadoresEnViajeValidator:AbstractValidator<operadoresenviaje>
    {
        public OperadoresEnViajeValidator()
        {
            RuleFor(s => s.IdOperador).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(s => s.IdViajeSci).NotNull().NotEmpty().GreaterThan(0);
            //RuleFor(s => s.SaldoActual).NotNull().NotEmpty().GreaterThan(-1);
        }
    }
}
