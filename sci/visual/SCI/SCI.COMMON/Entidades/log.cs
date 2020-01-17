using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class log:BaseDTO
    {
        public int IdMovimiento { get; set; }
        public string Accion { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string ModuloAfectado { get; set; }
    }
}
