using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class GasolineriaValidator:AbstractValidator<gasolineria>
    {
        public GasolineriaValidator()
        {
            RuleFor(s => s.Nombre).NotNull().NotEmpty().Length(1, 100);
            RuleFor(s => s.Direccion).NotNull().Length(1, 200);
            RuleFor(s => s.IdTipoGasto).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(s => s.Rfc).NotNull().Length(0, 15);
            RuleFor(s => s.RazonSocial).NotNull().Length(0, 100);
            RuleFor(s => s.Telefono).NotNull().Length(0, 20);
            RuleFor(s => s.Correo).NotNull().Length(0, 50);
        }
    }
}
