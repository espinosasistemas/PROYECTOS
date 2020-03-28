using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI.INTERFAZ.UI
{
    public partial class FormAgregarFactura : Form
    {
        IClienteManager managerCliente;

        string resultado = string.Empty;
        usuario user;
        string accion = string.Empty;
        int idFactura = 0;
        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public FormAgregarFactura(usuario u, string evento, int id)
        {
            InitializeComponent();
            managerCliente = Tools.FabricManager.ClienteManager();
            user = u;
            accion = evento;
            idFactura = id;
        }

        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            IEnumerable<cliente> todosLosClientes = managerCliente.ObtenerTodos;
            if (todosLosClientes != null)
            {
                comboClientes.DataSource = todosLosClientes.Select(r => (r.IdCliente + "/" + r.RazonSocial)).ToList();
                comboClientes.Text = string.Empty;
            }
        }

        private void btnBuscarClienteRFC_Click(object sender, EventArgs e)
        {
            cliente clienteEncontrado = managerCliente.BuscaClientePorRfc(textRfc.Text);
            
        }
    }
}
