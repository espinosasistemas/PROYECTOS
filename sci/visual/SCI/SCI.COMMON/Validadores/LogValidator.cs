using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class LogValidator:AbstractValidator<log>
    {
        public LogValidator()
        {
            RuleFor(l => l.Accion).NotNull().NotEmpty().Length(1, 50);
            RuleFor(l => l.NombreUsuario).NotNull().NotEmpty().Length(1, 50);
            RuleFor(l => l.Fecha).NotNull().NotEmpty();
            RuleFor(l => l.ModuloAfectado).NotNull().NotEmpty().Length(1,50);
        }
    }
}
