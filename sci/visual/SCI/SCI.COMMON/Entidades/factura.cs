using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Entidades
{
    public class factura : BaseDTO
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int FolioFactura { get; set; }
        public string TipoDeViaje { get; set; }
        public string LoadLeg { get; set; }
        public string FacturaAlms { get; set; }
        public string Usuario { get; set; }
        public string CartaPorte { get; set; }
        public string TrackId { get; set; }
        public string UsoCfdi { get; set; }
        public string MetodoDePago { get; set; }
        public string FormaDePago { get; set; }
        public string CondicionesDePago { get; set; }
        public string RegimenFiscal { get; set; }
        public DateTime FechaDeFactura { get; set; }
        public DateTime FechaFacturaAlms { get; set; }
        public DateTime FechaDeRecibido { get; set; }
        public DateTime FechaDePagoPromesa { get; set; }
        public DateTime FechaPagoReal { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Retencion { get; set; }
        public double MontoTotal { get; set; }
        public string Status { get; set; }
    }
}
