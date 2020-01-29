using FluentValidation;
using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Validadores
{
    public class TipoDeUnidadValidator:AbstractValidator<tipounidad>
    {
        public TipoDeUnidadValidator()
        {
            RuleFor(s => s.Descripcion).NotNull().NotEmpty().Length(1, 20);
        }
    }
}
