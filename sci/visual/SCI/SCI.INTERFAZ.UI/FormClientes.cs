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
    public partial class FormClientes : Form
    {
        IClienteManager managerClientes;
        int filaSeleccionada = -1;

        public FormClientes()
        {
            InitializeComponent();
            managerClientes = Tools.FabricManager.ClienteManager();
        }

        private void btnBuscarTodosClientes_Click(object sender, EventArgs e)
        {
            cargarTodosLosCliente();
        }
        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            FormAgregarCliente fm = new FormAgregarCliente("agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                cargarTodosLosCliente();
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                FormAgregarCliente fm = new FormAgregarCliente("editar", int.Parse(dgvClientes["idcliente", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodosLosCliente();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminar = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvClientes["razonsocial", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar el cliente con razón social: {nombre}?", "Eliminar Cliente.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminar == DialogResult.Yes)
                {
                    try
                    {
                        if (managerClientes.Eliminar(dgvClientes["idcliente", filaSeleccionada].Value.ToString()))
                        {
                            cargarTodosLosCliente();
                            mostrarLabelStatus("Se ha eliminado Correctamente al Cliente. " + nombre, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar al Cliente. " + managerClientes.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar al Cliente. " + ex.Message, false);
                    }
                }

            }
        }

        public void cargarTodosLosCliente()
        {
            IEnumerable<cliente> TodosClientes = managerClientes.ObtenerTodos;
            dgvClientes.DataSource = TodosClientes;
            if (dgvClientes.Rows.Count > 0)
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

        private void mostrarLabelStatus(string mensaje, bool color)
        {
            panelResultado.Visible = true;
            if (mensaje == string.Empty)
                mensaje = "Sin Resultado.";
            labelResultado.Text = mensaje;
            if (color == true) panelResultado.BackColor = Color.FromArgb(76, 175, 80);
            else panelResultado.BackColor = Color.FromArgb(255, 87, 34);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargarTodosLosCliente();
        }
    }
}
