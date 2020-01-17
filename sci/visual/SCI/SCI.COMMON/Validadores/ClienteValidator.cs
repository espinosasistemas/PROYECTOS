using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class ClienteValidator : AbstractValidator<cliente>
    {
        public ClienteValidator()
        {
            //RuleFor(c => c.IdCliente).NotNull().NotEmpty();
            RuleFor(c => c.RazonSocial).NotNull().NotEmpty().Length(1,200);
            RuleFor(c => c.Rfc).NotNull().NotEmpty().Length(1, 15);
            RuleFor(c => c.Giro).NotNull().NotEmpty().Length(1, 50);
            RuleFor(c => c.Telefono).NotNull().NotEmpty().Length(1, 20);
            RuleFor(c => c.Correo).NotNull().NotEmpty().Length(1, 100);
            RuleFor(c => c.NombreContacto).NotNull().NotEmpty().Length(1, 200);
            RuleFor(c => c.Observaciones).NotNull().NotEmpty().Length(1, 200);
        }
        
    }
}
