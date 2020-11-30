using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_Conexion_PCH.ServicePCH;

namespace test_Conexion_PCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            var cliente = new PCH_MAYOREOPortTypeClient();
            var factura = await cliente.ObtenerFacturaPorOcAsync(16225, "396514", txtOc.Text);
            factura.resultado.datos.iFactura
            var datos = factura.resultado.datos;
            if(factura.resultado.datos != null)
                MessageBox.Show(datos.fTotal.ToString());
            else
                MessageBox.Show(factura.resultado.mensaje);
        }
    }
}
