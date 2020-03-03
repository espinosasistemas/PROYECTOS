using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class CobrosAdicionalesValidator : AbstractValidator<cobrosadicionales>
    {
        public CobrosAdicionalesValidator()
        {
            RuleFor(s => s.IdViajeSci).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(s => s.TipoCobro).NotNull().NotEmpty().Length(1, 20);
            RuleFor(s => s.Monto).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(s => s.Fecha).NotNull().NotEmpty();
        }
    }
}
