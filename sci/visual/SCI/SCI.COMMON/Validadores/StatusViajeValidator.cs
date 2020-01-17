using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    class StatusViajeValidator:AbstractValidator<statusviaje>
    {
        public StatusViajeValidator()
        {
            RuleFor(s=>s.Nombre).NotNull().NotEmpty().Length(1,50);
        }
    }
}
