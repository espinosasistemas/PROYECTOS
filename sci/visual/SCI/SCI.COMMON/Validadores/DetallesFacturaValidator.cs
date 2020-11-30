using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class DetallesFacturaValidator : AbstractValidator<detallesfactura>
    {
        public DetallesFacturaValidator()
        {
            RuleFor(f => f.IdFolioFactura).NotNull().NotEmpty().LessThan(0);
            RuleFor(f => f.IdViaje).NotNull().NotEmpty().LessThan(0);
            //RuleFor(f => f.ClaveProduto).NotNull().NotEmpty()
            //RuleFor(f => f.IdFolioFactura).NotNull().NotEmpty().LessThan(0);
        }
    }
}
