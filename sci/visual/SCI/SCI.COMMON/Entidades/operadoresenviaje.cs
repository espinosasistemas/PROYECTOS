using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class operadoresenviaje:BaseDTO
    {
        public int IdRegistro { get; set; }
        public int IdOperador { get; set; }
        public int IdViajeSci { get; set; }
        public double SaldoActual { get; set; }
        public int Posicion { get; set; }
    }
}
