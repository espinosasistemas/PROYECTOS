using System;
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
        public double Salarioporhora { get; set; }
        public string Direccion { get; set; }
        public string TelefonoDeCasa { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
    }
}
