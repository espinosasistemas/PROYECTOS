using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class usuario : BaseDTO
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string NombreCompleto { get; set; }
    }
}
