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
        ITipoDeUnidadManager managerTipoDeUnidad;
        ILogManager managerLog;
        int filaSeleccionada = -1;
        usuario user;

        public FormUnidades(usuario u)
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerTipoDeUnidad = Tools.FabricManager.TipoDeUnidadesManager();
            managerLog = Tools.FabricManager.LogManager();
            user = u;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarTodasUnidades()
        {
            dgvUnidades.Columns.Clear();
            IEnumerable<unidades> TodasUnidades = managerUnidades.ObtenerTodos;
            dgvUnidades.DataSource = TodasUnidades;
            if (dgvUnidades.Rows.Count > 0)
            {
                dgvUnidades.Columns.Add("tipoDeUnidad", "tipoDeUnidad");
                dgvUnidades.Columns["idUnidad"].Visible = false;
                tipounidad tUnidad = new tipounidad();
                for (int i = 0; i < dgvUnidades.Rows.Count; i++)
                {
                    tUnidad = managerTipoDeUnidad.BuscarPorId(int.Parse(dgvUnidades["idTipoDeUnidad", i].Value.ToString()));
                    dgvUnidades["tipoDeUnidad", i].Value = tUnidad.Descripcion;
                }
                dgvUnidades.Columns["idTipoDeUnidad"].Visible = false;
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
            FormAgregarUnidad fm = new FormAgregarUnidad(user,"agregar",-1);
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
                FormAgregarUnidad fm = new FormAgregarUnidad(user,"editar", int.Parse(dgvUnidades["idUnidad",filaSeleccionada].Value.ToString()));
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
                        if (managerUnidades.Eliminar(int.Parse(dgvUnidades["idUnidad", filaSeleccionada].Value.ToString())))
                        {
                            log registro = new log
                            {
                                Accion = "eliminar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "unidades-id:" + dgvUnidades["idUnidad", filaSeleccionada].Value.ToString()
                            };
                            managerLog.Insertar(registro);

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
            //cargarTodasUnidades();
        }

        private void FormUnidades_Shown(object sender, EventArgs e)
        {
            cargarTodasUnidades();
        }

        private void dgvUnidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0)
            {
                FormAgregarUnidad fm = new FormAgregarUnidad(user, "editar", int.Parse(dgvUnidades["idUnidad", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasUnidades();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }
    }
}
