using FluentValidation;
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
            RuleFor(g => g.RutaPdf).NotNull().Length(0,100);
            RuleFor(g => g.RutaXml).NotNull().Length(0, 100);
            RuleFor(g => g.Fecha).NotNull().NotEmpty();
            RuleFor(g => g.IdViajeOps).NotNull().NotEmpty().GreaterThan(0);

            RuleFor(g => g.NumeroDePoliza).NotNull();
            RuleFor(g => g.NumTicket).NotNull().Length(0, 50);
            RuleFor(g => g.FolioFactura).NotNull().Length(0, 50);
            RuleFor(g => g.NumTicket).NotNull().Length(0, 50);
            RuleFor(g => g.FormaDePago).NotNull().NotEmpty().Length(1, 20);
        }
    }
}
