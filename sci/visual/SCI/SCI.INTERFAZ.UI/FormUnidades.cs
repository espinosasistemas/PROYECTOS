using SCI.COMMON.Interfaces;
using SCI.COMMON.Entidades;
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
    public partial class FormUnidades : Form
    {
        IUnidadesManager managerUnidades;
        IUsuarioManager managerUsuarios;
        

        public FormUnidades()
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerUsuarios = Tools.FabricManager.UsuarioManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarTodasUnidades_Click(object sender, EventArgs e)
        {
            IEnumerable<unidades> TodasUnidades = managerUnidades.ObtenerTodos;
            dgvUnidades.DataSource = TodasUnidades;
        }

        private void btnCrearUnidad_Click(object sender, EventArgs e)
        {
            FormAgregarUnidad fm = new FormAgregarUnidad();
            DialogResult DialogFormEditAlumno = fm.ShowDialog();
            labelResultado.Text = fm.Valor;
            panelResultado.Visible = true;
        }
    }
}
