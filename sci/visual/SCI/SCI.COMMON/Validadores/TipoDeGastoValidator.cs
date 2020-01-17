using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class TipoDeGastoValidator:AbstractValidator<tipogasto>
    {
        public TipoDeGastoValidator()
        {
            RuleFor(g => g.Concepto).NotNull().NotEmpty().Length(1, 50);
        }
    }
}
