﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class gasolineria : BaseDTO
    {
        public int IdGasolineria { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int IdTipoGasto { get; set; }

    }
}
