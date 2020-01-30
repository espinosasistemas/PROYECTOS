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
    public partial class FormViajes : Form
    {
        IViajeManager managerViajes;
        int filaSeleccionada = -1;

        public FormViajes()
        {
            InitializeComponent();
            managerViajes = Tools.FabricManager.ViajeManager();
        }

        public void CargarTodosLosViajes()
        {
            IEnumerable<viaje> TodosViajes = managerViajes.ObtenerTodos;
            dgvViajes.DataSource = TodosViajes;
            if (dgvViajes.Rows.Count > 0)
            {
                mostrarLabelStatus("Se han cargado todos los viajes dados de alta.", true);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarTodosViajes_Click(object sender, EventArgs e)
        {
            CargarTodosLosViajes();
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            FormAgregarViaje fm = new FormAgregarViaje("agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                CargarTodosLosViajes();
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void FormViajes_Load(object sender, EventArgs e)
        {
            CargarTodosLosViajes();
        }

        private void btnEditarViaje_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != -1)
            {
                FormAgregarViaje fm = new FormAgregarViaje("editar", int.Parse(dgvViajes["idViajeOps", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    CargarTodosLosViajes();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminar = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvViajes["idViajeCliente", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar el viaje del Cliente: {nombre}?", "Eliminar Viaje.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminar == DialogResult.Yes)
                {
                    try
                    {
                        if (managerViajes.Eliminar(dgvViajes["idViajeOps", filaSeleccionada].Value.ToString()))
                        {
                            CargarTodosLosViajes();
                            mostrarLabelStatus("Se ha eliminado Correctamente el Viaje del cliente. " + nombre, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar el viaje. " + managerViajes.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar el Viaje. " + ex.Message, false);
                    }
                }

            }
        }
    }
}