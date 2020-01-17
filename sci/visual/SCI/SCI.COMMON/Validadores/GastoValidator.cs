﻿using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class GastoValidator:AbstractValidator<gasto>
    {
        public GastoValidator()
        {
            RuleFor(g => g.IdTipoGasto).NotNull().NotEmpty();
            RuleFor(g => g.Concepto).NotNull().NotEmpty().Length(1, 100);
            RuleFor(g => g.Costo).NotNull().NotEmpty().GreaterThan(-1);
            RuleFor(g => g.RutaPdf).NotNull().Length(1,300);
            RuleFor(g => g.RutaXml).NotNull().Length(1, 300);
            RuleFor(g => g.Fecha).NotNull().NotEmpty();
            RuleFor(g => g.IdViajeOps).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}