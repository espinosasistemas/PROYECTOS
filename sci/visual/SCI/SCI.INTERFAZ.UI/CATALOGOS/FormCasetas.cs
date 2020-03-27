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
    public partial class FormCasetas : Form
    {
        ICasetaManager managerCaseta;
        ITipoDeUnidadManager managerTipoDeUnidad;
        ITipoDeGastoManager managerTipoDeGasto;
        ILogManager managerLog;
        int filaSeleccionada = -1;
        usuario user;

        public FormCasetas(usuario u)
        {
            InitializeComponent();
            managerCaseta = Tools.FabricManager.CasetaManager();
            managerTipoDeUnidad = Tools.FabricManager.TipoDeUnidadesManager();
            managerTipoDeGasto = Tools.FabricManager.TipoDeGastoManager();
            managerLog = Tools.FabricManager.LogManager();
            user = u;
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
        public void cargarTodasLasCasetas()
        {
            dgvCasetas.Columns.Clear();
            IEnumerable<caseta> TodosClientes = managerCaseta.ObtenerTodos;
            dgvCasetas.DataSource = TodosClientes;

            dgvCasetas.Columns["idTipoDeUnidad"].Visible = false;
            dgvCasetas.Columns["idTipoDeGasto"].Visible = false;

            if (dgvCasetas.Rows.Count > 0)
            {
                dgvCasetas.Columns.Add("TipoDeUnidad", "TipoDeUnidad");
                dgvCasetas.Columns.Add("TipoDeGasto", "TipoDeGasto");
                tipounidad tUnidad = new tipounidad();
                tipogasto tGasto = new tipogasto();
                for (int i = 0; i < dgvCasetas.Rows.Count; i++)
                {
                    tUnidad = managerTipoDeUnidad.BuscarPorId(int.Parse(dgvCasetas["idTipoDeUnidad", i].Value.ToString()));
                    tGasto = managerTipoDeGasto.BuscarPorId(int.Parse(dgvCasetas["idTipoDeGasto", i].Value.ToString()));

                    dgvCasetas["TipoDeUnidad", i].Value = tUnidad.Descripcion;
                    dgvCasetas["TipoDeGasto", i].Value = tGasto.Concepto;
                }

                mostrarLabelStatus("Se han cargado todas los casetas dadas de alta.", true);
                filaSeleccionada = 0;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tienen casetas registradas.", false);
                filaSeleccionada = -1;
            }
        }

        private void btnBuscarTodasCasetas_Click(object sender, EventArgs e)
        {
            cargarTodasLasCasetas();
        }
        private void btnElminarCaseta_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminar = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvCasetas["nombre", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar las caseta: {nombre}?", "Eliminar Caseta.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminar == DialogResult.Yes)
                {
                    try
                    {
                        if (managerCaseta.Eliminar(int.Parse(dgvCasetas["idCaseta", filaSeleccionada].Value.ToString())))
                        {
                            log registro = new log
                            {
                                Accion = "eliminar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "caseta-id:" + dgvCasetas["idCaseta", filaSeleccionada].Value.ToString()
                            };
                            managerLog.Insertar(registro);

                            cargarTodasLasCasetas();
                            mostrarLabelStatus("Se ha eliminado Correctamente La Caseta. " + nombre, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar La Caseta. " + managerCaseta.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar la Caseta. " + ex.Message, false);
                    }
                }

            }
        }

        private void btnCrearCaseta_Click(object sender, EventArgs e)
        {
            FormAgregarCasetas fm = new FormAgregarCasetas(user,"agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                cargarTodasLasCasetas();
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void btnEditarCaseta_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                FormAgregarCasetas fm = new FormAgregarCasetas(user,"editar", int.Parse(dgvCasetas["idCaseta", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasLasCasetas();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }

        private void FormCasetas_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvCasetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCasetas_Shown(object sender, EventArgs e)
        {
            cargarTodasLasCasetas();
        }

        private void dgvCasetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0)
            {
                FormAgregarCasetas fm = new FormAgregarCasetas(user, "editar", int.Parse(dgvCasetas["idCaseta", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasLasCasetas();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }
    }
}
