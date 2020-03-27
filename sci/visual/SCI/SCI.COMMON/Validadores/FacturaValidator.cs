using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class FacturaValidator: AbstractValidator<factura>
    {
        public FacturaValidator()
        {
            RuleFor(f => f.IdCliente).NotNull().NotEmpty().LessThan(0);
            RuleFor(f => f.FolioFactura).NotNull().NotEmpty().LessThan(0);
            RuleFor(f => f.TipoDeViaje).NotNull().NotEmpty().Length(0,10);
            RuleFor(f => f.LoadLeg).NotNull().Length(0,20);
            RuleFor(f => f.FacturaAlms).NotNull().Length(0,20);
            RuleFor(f => f.Usuario).NotNull().Length(0,30);
            RuleFor(f => f.CartaPorte).NotNull().Length(0, 50);
            RuleFor(f => f.TrackId).NotNull().Length(0, 50);
            RuleFor(f => f.UsoCfdi).NotNull().Length(0, 20);
            RuleFor(f => f.MetodoDePago).NotNull().Length(0, 20);
            RuleFor(f => f.FormaDePago).NotNull().Length(0, 20);
            RuleFor(f => f.CondicionesDePago).NotNull().Length(0, 20);
            RuleFor(f => f.RegimenFiscal).NotNull().Length(0, 20);
            RuleFor(f => f.FechaDeFactura).NotNull();
            RuleFor(f => f.FechaFacturaAlms).NotNull();
            RuleFor(f => f.FechaDeRecibido).NotNull();
            RuleFor(f => f.FechaDePagoPromesa).NotNull();
            RuleFor(f => f.FechaPagoReal).NotNull();
            RuleFor(f => f.Subtotal).NotNull().GreaterThan(-1);
            RuleFor(f => f.Iva).NotNull().GreaterThan(-1);
            RuleFor(f => f.Retencion).NotNull().GreaterThan(-1);
            RuleFor(f => f.MontoTotal).NotNull().GreaterThan(-1);
            RuleFor(f => f.Status).NotNull().Length(0, 20);
        }

    }
}
