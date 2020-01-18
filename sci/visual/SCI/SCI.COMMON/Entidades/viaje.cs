using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class viaje:BaseDTO
    {
        public int IdViajeOps { get; set; }
        public string IdViajeCliente { get; set; }
        public DateTime FechaInicioOps { get; set; }
        public DateTime FechaInicioCliente { get; set; }
        public DateTime FechaFinOps { get; set; }
        public DateTime FechaFinCliente { get; set; }
        public int IdStatus { get; set; }
        public int IdRuta { get; set; }
        public int IdCliente { get; set; }
        public int IdOperador { get; set; }
    }
}
