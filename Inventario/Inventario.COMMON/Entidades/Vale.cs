using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.COMMON.Entidades
{
    public class Vale:Base
    {
        public DateTime FechaHora { get; set; }

        public DateTime FechaEntrega { get; set; }

        public DateTime? FechaEntregaReal { get; set; } //el ? sig que puede aceptar NULL

        public List<Material> MateralesPrestados { get; set; } 

        public Empleado Solicitante { get; set; }

        public Empleado EncargadoDeAlmacen { get; set; }

    }
}
