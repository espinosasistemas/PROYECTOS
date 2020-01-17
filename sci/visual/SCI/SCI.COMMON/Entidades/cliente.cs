using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class cliente:BaseDTO
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Giro { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string NombreContacto { get; set; }
        public string Observaciones { get; set; }
    }
}
