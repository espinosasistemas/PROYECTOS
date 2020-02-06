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
            RuleFor(c => c.Rfc).NotNull().Matches("^[A-Z0-9]*$").Length(12, 13);
            RuleFor(c => c.Giro).NotNull().NotEmpty().Length(1, 50);
            RuleFor(c => c.Telefono).NotNull().NotEmpty().Length(1, 20);
            RuleFor(c => c.Correo).NotNull().NotEmpty().EmailAddress().Length(1, 100);
            RuleFor(c => c.NombreContacto).NotNull().Length(1, 200);
            RuleFor(c => c.Direccion).NotNull().Length(1, 200);
        }
        
    }
}
