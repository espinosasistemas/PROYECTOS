using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class cobrosadicionales : BaseDTO
    {
        public int IdCobroAdicional { get; set; }
        public int IdViajeSci { get; set; }
        public string TipoCobro { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
