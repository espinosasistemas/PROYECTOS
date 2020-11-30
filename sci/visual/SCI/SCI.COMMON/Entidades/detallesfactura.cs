using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class detallesfactura : BaseDTO
    {
        public int IdPartidaFactura { get; set; }
        public int IdFolioFactura { get; set; }
        public int IdViaje { get; set; }
        public string ClaveProduto { get; set; }
        public int Cantidad { get; set; }
        public string ClaveUnidad { get; set; }
        public double ValorUnitario { get; set; }
        public double Importe { get; set; }
        public double Iva { get; set; }
        public double Retencion { get; set; }
    }
}
