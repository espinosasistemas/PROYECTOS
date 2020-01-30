using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class caseta:BaseDTO
    {
        public int IdCaseta { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public int IdTipoDeUnidad { get; set; }
        public int IdTipoDeGasto { get; set; }
    }
}
