﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class operador:BaseDTO
    {
        public int IdOperador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Salarioporhora { get; set; }
        public string Direccion { get; set; }
    }
}