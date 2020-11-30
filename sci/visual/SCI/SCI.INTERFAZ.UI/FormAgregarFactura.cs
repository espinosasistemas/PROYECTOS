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
        int tabPageIndex = 0;
        bool clientesInicial = true;

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
                clientesInicial = false;
            }
        }

        private void btnBuscarClienteRFC_Click(object sender, EventArgs e)
        {
            cliente clienteEncontrado = managerCliente.BuscaClientePorRfc(textRfc.Text);
            if (clienteEncontrado != null)
            {
                comboClientes.Text = clienteEncontrado.IdCliente + "/" + clienteEncontrado.RazonSocial;
                textNombre.Text = clienteEncontrado.NombreContacto;
                textCorreo.Text = clienteEncontrado.Correo;
            }
            
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int paginas = tabControl1.TabPages.Count;
            if (++tabPageIndex < paginas)
                tabControl1.SelectedTab = tabControl1.TabPages[tabPageIndex];
            else
            {
                tabPageIndex = 0;
                tabControl1.SelectedTab = tabControl1.TabPages[tabPageIndex];
            }
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            int paginas = tabControl1.TabPages.Count;
            if (--tabPageIndex >= 0)
                tabControl1.SelectedTab = tabControl1.TabPages[tabPageIndex];
            else
            {
                tabPageIndex = paginas-1;
                tabControl1.SelectedTab = tabControl1.TabPages[tabPageIndex];
            }
        }

        private void comboClientes_TextChanged(object sender, EventArgs e)
        {
            if (clientesInicial == false)
            {
                string[] splitClientes = comboClientes.Text.Split('/');
                cliente clienteSeleccionado = managerCliente.BuscarPorId(int.Parse(splitClientes.First()));
                if (clienteSeleccionado != null)
                {
                    textRfc.Text = clienteSeleccionado.Rfc;
                    textNombre.Text = clienteSeleccionado.NombreContacto;
                    textCorreo.Text = clienteSeleccionado.Correo;
                }
            }
        }

        private void textClaveViaje_Click(object sender, EventArgs e)
        {
            if (textClaveViaje.Text == "Ingrese el número de viaje")
            {
                textClaveViaje.Text = string.Empty;
                textClaveViaje.ForeColor = Color.Black;
            }
        }

        private void textClaveViaje_Leave(object sender, EventArgs e)
        {
            if (textClaveViaje.Text == string.Empty)
            {
                textClaveViaje.Text = "Ingrese el número de viaje";
                textClaveViaje.ForeColor = Color.DarkGray;
            }
        }
    }
}
