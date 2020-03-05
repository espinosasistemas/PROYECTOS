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
    public partial class FormGasolinerias : Form
    {
        IGasolineriaManager managerGasolineria;
        ITipoDeGastoManager managerTipoDeGasto;
        ILogManager managerLog;
        int filaSeleccionada = -1;
        usuario user;

        public FormGasolinerias(usuario u)
        {
            InitializeComponent();
            managerGasolineria = Tools.FabricManager.GasolineriaManager();
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

        public void cargarTodasLasGasolinerias()
        {
            dgvGasolinerias.Columns.Clear();
            IEnumerable<gasolineria> TodosClientes = managerGasolineria.ObtenerTodos;
            dgvGasolinerias.DataSource = TodosClientes;
            dgvGasolinerias.Columns["idTipoGasto"].Visible = false;

            if (dgvGasolinerias.Rows.Count > 0)
            {
                dgvGasolinerias.Columns.Add("tipoDeGasto", "TipoDeGasto");
                tipogasto tGasto = new tipogasto();

                for (int i = 0; i < dgvGasolinerias.Rows.Count; i++)
                {
                    tGasto = managerTipoDeGasto.BuscarPorId(dgvGasolinerias["idTipoGasto", i].Value.ToString());
                    dgvGasolinerias["tipoDeGasto", i].Value = tGasto.Concepto;
                }

                mostrarLabelStatus("Se han cargado todas los gasolinerías dadas de alta.", true);
                filaSeleccionada = 0;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tienen gasolinerías registradas.", false);
                filaSeleccionada = -1;
            
            }
        }

        private void dgvGasolinerias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void btnBuscarTodasGasolinerias_Click(object sender, EventArgs e)
        {
            cargarTodasLasGasolinerias();
        }

        private void btnElminarGasolineria_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminar = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvGasolinerias["nombre", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar la Gasolinería: {nombre}?", "Eliminar Gasolinería.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminar == DialogResult.Yes)
                {
                    try
                    {
                        if (managerGasolineria.Eliminar(dgvGasolinerias["idGasolineria", filaSeleccionada].Value.ToString()))
                        {
                            log registro = new log
                            {
                                Accion = "eliminar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "gasolineria-id:" + dgvGasolinerias["idGasolineria", filaSeleccionada].Value.ToString()
                            };
                            managerLog.Insertar(registro);

                            cargarTodasLasGasolinerias();
                            mostrarLabelStatus("Se ha eliminado Correctamente La Gasolinería. " + nombre, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar La Gasolinería. " + managerGasolineria.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar la Gasolinería. " + ex.Message, false);
                    }
                }

            }
        }

        private void btnCrearGasolineria_Click(object sender, EventArgs e)
        {
            FormAgregarGasolineria fm = new FormAgregarGasolineria(user,"agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                cargarTodasLasGasolinerias();
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void btnEditarGasolineria_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                FormAgregarGasolineria fm = new FormAgregarGasolineria(user,"editar", int.Parse(dgvGasolinerias["idGasolineria", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasLasGasolinerias();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }

        private void FormGasolinerias_Load(object sender, EventArgs e)
        {
            //cargarTodasLasGasolinerias();
        }

        private void FormGasolinerias_Shown(object sender, EventArgs e)
        {
            cargarTodasLasGasolinerias();
        }

        private void dgvGasolinerias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0)
            {
                FormAgregarGasolineria fm = new FormAgregarGasolineria(user, "editar", int.Parse(dgvGasolinerias["idGasolineria", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasLasGasolinerias();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }
    }
}
