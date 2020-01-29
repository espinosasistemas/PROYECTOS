using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class unidades:BaseDTO
    {
        public int IdUnidad { get; set; }
        public string Nombre  { get; set; }
        public int NumeroEconomico { get; set; }
        public string Placas { get; set; }
        public string NumeroSerie { get; set; }
        public string TipoCombustible { get; set; }
        public int IdTipoDeUnidad { get; set; }
    }
}
