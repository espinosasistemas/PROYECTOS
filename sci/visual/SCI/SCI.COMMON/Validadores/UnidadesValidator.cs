﻿using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class UnidadesValidator:AbstractValidator<unidades>
    {
        public UnidadesValidator()
        {
            RuleFor(u => u.Nombre).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.NumeroEconomico).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(u => u.Placas).NotNull().NotEmpty().Length(1, 15);
            RuleFor(u => u.NumeroSerie).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.PolizaSeguro).NotNull().NotEmpty().Length(0, 20);
            RuleFor(u => u.FechaVencimientoSeguro).NotNull();
            RuleFor(u => u.TipoCombustible).NotNull().NotEmpty().Length(1,50);
            RuleFor(u => u.IdTipoDeUnidad).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
