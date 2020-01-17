using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class gasto:BaseDTO
    {
        public int IdGasto { get; set; }
        public int IdTipoGasto { get; set; }
        public string Concepto { get; set; }
        public double Costo { get; set; }
        public string RutaPdf { get; set; }
        public string RutaXml { get; set; }
        public DateTime Fecha { get; set; }
        public int IdViajeOps { get; set; }
    }
}
