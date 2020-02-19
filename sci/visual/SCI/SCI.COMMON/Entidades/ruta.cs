using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class ruta:BaseDTO
    {
        public int IdRuta { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public string UnidadAFacturar { get; set; }
        public int IdCliente { get; set; }
        //public int IdTipoDeUnidad { get; set; }
    }
}
