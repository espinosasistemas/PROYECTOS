using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class deposito:BaseDTO
    {
        public int IdDeposito { get; set; }
        public int IdOperador { get; set; }
        public int IdViajeSci { get; set; }
        public double Monto { get; set; }
        public string Tipo { get; set; }
        public string Referencia { get; set; }
        public DateTime Fecha { get; set; }
    }
}
