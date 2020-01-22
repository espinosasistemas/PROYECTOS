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
    public partial class FormOperadores : Form
    {
        IOperadorManager managerOperadores;
        int filaSeleccionada = -1;

        public FormOperadores()
        {
            InitializeComponent();
            managerOperadores = Tools.FabricManager.OperadorManager();
        }

        private void btnMostrarOperadores_Click(object sender, EventArgs e)
        {
            cargarTodosOperadores();
        }
        public void cargarTodosOperadores()
        {
            IEnumerable<operador> TodosOperadores = managerOperadores.ObtenerTodos;
            dgvOperadores.DataSource = TodosOperadores;
            if (dgvOperadores.Rows.Count > 0)
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
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearOperador_Click(object sender, EventArgs e)
        {
            FormAgregarOperador fm = new FormAgregarOperador("agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                cargarTodosOperadores();
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void btnEditarOperador_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                FormAgregarOperador fm = new FormAgregarOperador("editar", int.Parse(dgvOperadores["idOperador", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodosOperadores();
                    mostrarLabelStatus(fm.Valor, true);
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

        private void dgvOperadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void btnEliminarOperador_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminarOperador = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombreOperador = dgvOperadores["Nombre", filaSeleccionada].Value.ToString() + " " + dgvOperadores["Apellidos", filaSeleccionada].Value.ToString();
                dialogEliminarOperador = MessageBox.Show($"¿Esta seguro de eliminar el operador con nombre: {nombreOperador}?", "Eliminar Operador.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminarOperador == DialogResult.Yes)
                {
                    try
                    {
                        if (managerOperadores.Eliminar(dgvOperadores["idoperador", filaSeleccionada].Value.ToString()))
                        {
                            cargarTodosOperadores();
                            mostrarLabelStatus("Se ha eliminado Correctamente al Operador. " + nombreOperador, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar el operador. " + managerOperadores.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar el Operador. " + ex.Message, false);
                    }
                }

            }
        }
    }
}