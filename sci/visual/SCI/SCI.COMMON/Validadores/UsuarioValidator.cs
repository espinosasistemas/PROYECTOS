using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class UsuarioValidator : AbstractValidator<usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.NombreUsuario).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.NombreCompleto).NotNull().NotEmpty().Length(1, 50);
        }
    }
}
