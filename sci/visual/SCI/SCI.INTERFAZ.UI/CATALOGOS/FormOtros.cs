﻿using SCI.COMMON.Entidades;
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
    public partial class FormOtros : Form
    {
        ITipoDeGastoManager managerGasto;
        IStatusViajeManager managerStatus;
        ILogManager managerLog;

        int filaSeleccionadaGasto = -1;
        int filaSeleccionadaStatus = -1;
        usuario user;

        public FormOtros(usuario u)
        {
            InitializeComponent();
            managerGasto = Tools.FabricManager.TipoDeGastoManager();
            managerStatus = Tools.FabricManager.StatusViajeManager();
            managerLog = Tools.FabricManager.LogManager();
            user = u;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionadaGasto = e.RowIndex;
        }

        private void dataEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionadaStatus = e.RowIndex;
        }

        private void btnBuscarTodosGastos_Click(object sender, EventArgs e)
        {
            cargarTodosLosGastos();
        }

        public void cargarTodosLosGastos()
        {
            IEnumerable<tipogasto> TodosLosTipos = managerGasto.ObtenerTodos;
            dgvGastos.DataSource = TodosLosTipos;
            if (dgvGastos.Rows.Count > 0)
            {
                mostrarLabelStatus("Se han cargado todos los Tipos de Gastos.", true);
                filaSeleccionadaGasto = 0;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tienen Tipos de Gastos registrados.", false);
                filaSeleccionadaGasto = -1;
            }
        }

        public void cargarTodosLosStatus()
        {
            IEnumerable<statusviaje> TodosLosStatus = managerStatus.ObtenerTodos;
            dgvStatus.DataSource = TodosLosStatus;
            if (dgvStatus.Rows.Count > 0)
            {
                mostrarLabelStatus("Se han cargado todos los status de los viajes.", true);
                filaSeleccionadaStatus = 0;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tiene registrados Status de los viajes.", false);
                filaSeleccionadaStatus = -1;
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

        private void btnMostrarEstados_Click(object sender, EventArgs e)
        {
            cargarTodosLosStatus();
        }

        private void btnCrearTipoGasto_Click(object sender, EventArgs e)
        {
            FormPermiso fp = new FormPermiso();
            DialogResult DialogForm2 = fp.ShowDialog();

            if (fp.Valor == true)
            {

                FormAgregarTipoDeGasto fm = new FormAgregarTipoDeGasto(user, "agregar", -1);
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodosLosGastos();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (filaSeleccionadaGasto >= 0)
            {
                FormPermiso fp = new FormPermiso();
                DialogResult DialogForm2 = fp.ShowDialog();

                if (fp.Valor == true)
                {

                    FormAgregarTipoDeGasto fm = new FormAgregarTipoDeGasto(user, "editar", int.Parse(dgvGastos["idTipoGasto", filaSeleccionadaGasto].Value.ToString()));
                    DialogResult DialogForm = fm.ShowDialog();
                    if (fm.Valor != string.Empty)
                    {
                        cargarTodosLosGastos();
                        mostrarLabelStatus(fm.Valor, true);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            FormPermiso fp = new FormPermiso();
            DialogResult DialogForm2 = fp.ShowDialog();

            if (fp.Valor == true)
            {
                DialogResult dialogEliminar = new DialogResult();
                if (filaSeleccionadaGasto >= 0)
                {
                    string nombre = dgvGastos["concepto", filaSeleccionadaGasto].Value.ToString();
                    dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar el tipo de gasto: {nombre}?", "Eliminar Gasto.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogEliminar == DialogResult.Yes)
                    {
                        try
                        {
                            if (managerGasto.Eliminar(int.Parse(dgvGastos["idTipoGasto", filaSeleccionadaGasto].Value.ToString())))
                            {
                                log registro = new log
                                {
                                    Accion = "eliminar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "tipogasto-id:" + dgvGastos["idTipoGasto", filaSeleccionadaGasto].Value.ToString()
                                };
                                managerLog.Insertar(registro);

                                cargarTodosLosGastos();
                                mostrarLabelStatus("Se ha eliminado Correctamente el tipo de Gasto. " + nombre, true);
                            }
                            else
                                mostrarLabelStatus("No se ha podido Eliminar el tipo de Gasto. " + managerGasto.Error, false);

                        }
                        catch (Exception ex)
                        {
                            mostrarLabelStatus("No se ha podido Eliminar el tipo de gasto. " + ex.Message, false);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormOtros_Load(object sender, EventArgs e)
        {
            cargarTodosLosGastos();
            cargarTodosLosStatus();
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            FormPermiso fp = new FormPermiso();
            DialogResult DialogForm2 = fp.ShowDialog();

            if (fp.Valor == true)
            {
                FormAgregarStatus fm = new FormAgregarStatus(user, "agregar", -1);
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodosLosStatus();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            if (filaSeleccionadaGasto >= 0)
            {
                FormPermiso fp = new FormPermiso();
                DialogResult DialogForm2 = fp.ShowDialog();

                if (fp.Valor == true)
                {

                    FormAgregarStatus fm = new FormAgregarStatus(user, "editar", int.Parse(dgvStatus["idStatus", filaSeleccionadaStatus].Value.ToString()));
                    DialogResult DialogForm = fm.ShowDialog();
                    if (fm.Valor != string.Empty)
                    {
                        cargarTodosLosStatus();
                        mostrarLabelStatus(fm.Valor, true);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            FormPermiso fp = new FormPermiso();
            DialogResult DialogForm2 = fp.ShowDialog();

            if (fp.Valor == true)
            {

                DialogResult dialogEliminar = new DialogResult();
                if (filaSeleccionadaStatus >= 0)
                {
                    string nombre = dgvStatus["nombre", filaSeleccionadaStatus].Value.ToString();
                    dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar el status: {nombre}?", "Eliminar Status.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogEliminar == DialogResult.Yes)
                    {
                        try
                        {
                            if (managerStatus.Eliminar(int.Parse(dgvStatus["idStatus", filaSeleccionadaStatus].Value.ToString())))
                            {
                                log registro = new log
                                {
                                    Accion = "eliminar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "statusviaje-id:" + dgvStatus["idStatus", filaSeleccionadaStatus].Value.ToString()
                                };
                                managerLog.Insertar(registro);

                                cargarTodosLosStatus();
                                mostrarLabelStatus("Se ha eliminado Correctamente el Status. " + nombre, true);
                            }
                            else
                                mostrarLabelStatus("No se ha podido Eliminar el status. " + managerStatus.Error, false);

                        }
                        catch (Exception ex)
                        {
                            mostrarLabelStatus("No se ha podido Eliminar el status. " + ex.Message, false);
                        }
                    }

                }
            }
            else
                MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
