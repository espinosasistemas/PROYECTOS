﻿using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class DepositoValidator : AbstractValidator<deposito>
    {
        public DepositoValidator()
        {
            RuleFor(d => d.IdOperador).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(d => d.IdViajeSci).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(d => d.Monto).NotNull().NotEmpty().GreaterThan(-1);
            RuleFor(d => d.Tipo).NotNull().NotEmpty().Length(0,40);
            RuleFor(d => d.Referencia).NotNull().Length(0, 40);
            RuleFor(d => d.Fecha).NotNull().NotEmpty();
            RuleFor(d => d.Nota).NotNull().Length(0, 100);
            
        }
    }
}
