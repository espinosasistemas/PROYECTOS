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
    public partial class FormFacturas : Form
    {
        IFacturaManager managerFactura;

        bool primeraCarga = true;
        int filaSeleccionada = -1;
        usuario user;
        private Form activeForm = null;

        public FormFacturas(usuario u)
        {
            InitializeComponent();
            managerFactura = Tools.FabricManager.FacturaManager();
            user = u;
        }

        private void openDashBoardForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(childForm);
            groupBox1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //MessageBox.Show(childForm.DialogResult.ToString());
        }
        public void CargarTodasLasFacturas(string status)
        {
            IEnumerable<factura> TodasLasFacturas;
            int idViajeSci = 0;
            dgvFacturas.Columns.Clear();
            TodasLasFacturas = managerFactura.ObtenerTodos;
            dgvFacturas.DataSource = TodasLasFacturas.OrderByDescending(s => s.IdFactura).ToArray();
        }

        private void btnBuscarTodasFacturas_Click(object sender, EventArgs e)
        {
            CargarTodasLasFacturas(string.Empty);
        }
    }
}
