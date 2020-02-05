using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class ViajeValidator:AbstractValidator<viaje>
    {
        public ViajeValidator()
        {
            RuleFor(v => v.IdViajeCliente).NotNull().Length(0, 100);
            RuleFor(v => v.FechaInicioSci).NotNull().NotEmpty();
            RuleFor(v => v.FechaInicioCliente).NotNull().NotEmpty();
            RuleFor(v => v.FechaFinSci).NotNull().NotEmpty();
            RuleFor(v => v.FechaFinCliente).NotNull().NotEmpty();
            RuleFor(v => v.IdStatus).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(v => v.IdRuta).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(v => v.IdCliente).NotNull().NotEmpty().GreaterThan(0);
            //RuleFor(v => v.IdOperador).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(v => v.IdUnidad).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
