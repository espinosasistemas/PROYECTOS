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
        int filaSeleccionada = -1;

        public FormUnidades()
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTodasUnidades()
        {
            IEnumerable<unidades> TodasUnidades = managerUnidades.ObtenerTodos;
            dgvUnidades.DataSource = TodasUnidades;
            if (dgvUnidades.Rows.Count > 0)
            {
                mostrarLabelStatus("Se han cargado toda las unidades dadas de alta.", true);
                filaSeleccionada = 0;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tienen unidades registradas.", false);
                filaSeleccionada = -1;
            }
        }

        private void btnBuscarTodasUnidades_Click(object sender, EventArgs e)
        {
            cargarTodasUnidades();
        }

        private void btnCrearUnidad_Click(object sender, EventArgs e)
        {
            FormAgregarUnidad fm = new FormAgregarUnidad("agregar",-1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                cargarTodasUnidades();
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void btnEditarUnidad_Click(object sender, EventArgs e)
        {
            if(filaSeleccionada>=0)
            {
                FormAgregarUnidad fm = new FormAgregarUnidad("editar", int.Parse(dgvUnidades["idUnidad",filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasUnidades();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }

        private void btnEliminarUnidad_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminarUnidad = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombreUnidad = dgvUnidades["Nombre", filaSeleccionada].Value.ToString();
                dialogEliminarUnidad = MessageBox.Show($"¿Esta seguro de eliminar la unidad con nombre: {nombreUnidad}?", "Eliminar Unidad.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminarUnidad == DialogResult.Yes)
                {
                    try
                    {
                        if (managerUnidades.Eliminar(dgvUnidades["idUnidad", filaSeleccionada].Value.ToString()))
                        {
                            cargarTodasUnidades();
                            mostrarLabelStatus("Se ha eliminado Correctamente la unidad. " + nombreUnidad, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar la unidad. " + managerUnidades.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar la unidad. " + ex.Message, false);
                    }
                }
                
            }
        }

        private void mostrarLabelStatus(string mensaje, bool color)
        {
            panelResultado.Visible = true;
            if (mensaje == string.Empty)
                mensaje = "Sin Resultado.";
            labelResultado.Text = mensaje;
            if (color == true) panelResultado.BackColor = Color.FromArgb(76, 175, 80);
            else panelResultado.BackColor = Color.FromArgb(255, 87, 34);
        }

        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void FormUnidades_Load(object sender, EventArgs e)
        {
            cargarTodasUnidades();
        }
    }
}
