using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class cortesoperador:BaseDTO
    {
        public int IdCorte { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Costo { get; set; }
        public double Horas { get; set; }
        public int IdOperador { get; set; }
        public int IdStatus { get; set; }
        public int IdViajeSci { get; set; }
    }
}
