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
    public partial class FormRutas : Form
    {
        IRutaManager managerRuta;
        ITipoDeUnidadManager managerTipoDeUnidades;

        int filaSeleccionada = -1;

        public FormRutas()
        {
            InitializeComponent();
            managerRuta = Tools.FabricManager.RutaManager();
            managerTipoDeUnidades = Tools.FabricManager.TipoDeUnidadesManager();
        }

        private void btnMostrarRutas_Click(object sender, EventArgs e)
        {
            cargarTodasLasRutas();
        }

        private void btnCrearRuta_Click(object sender, EventArgs e)
        {
            FormAgregarRutas fm = new FormAgregarRutas("agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                cargarTodasLasRutas();
                mostrarLabelStatus(fm.Valor, true);
            }
        }
        private void btnEditarRuta_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                FormAgregarRutas fm = new FormAgregarRutas("editar", int.Parse(dgvRutas["idruta", filaSeleccionada].Value.ToString()));
                DialogResult DialogForm = fm.ShowDialog();
                if (fm.Valor != string.Empty)
                {
                    cargarTodasLasRutas();
                    mostrarLabelStatus(fm.Valor, true);
                }
            }
        }
        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {
            DialogResult dialogEliminar = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvRutas["nombre", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar la ruta: {nombre}?", "Eliminar Ruta.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminar == DialogResult.Yes)
                {
                    try
                    {
                        if (managerRuta.Eliminar(dgvRutas["idruta", filaSeleccionada].Value.ToString()))
                        {
                            cargarTodasLasRutas();
                            mostrarLabelStatus("Se ha eliminado Correctamente la ruta. " + nombre, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar la ruta seleccionada. " + managerRuta.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar la ruta seleccionada. " + ex.Message, false);
                    }
                }

            }
        }


        /*-------------------*/
        public void cargarTodasLasRutas()
        {
            dgvRutas.Columns.Clear();
            IEnumerable<ruta> TodasRutas = managerRuta.ObtenerTodos;
            dgvRutas.DataSource = TodasRutas;
            
            if (dgvRutas.Rows.Count > 0)
            {
                dgvRutas.Columns.Add("nombreUnidad", "NombreUnidad");
                //dgvRutas.Columns.Add("NumEconomico", "NumEconomico");
                tipounidad tUnidad;
                for (int i = 0; i < dgvRutas.Rows.Count; i++)
                {
                    tUnidad = managerTipoDeUnidades.BuscarPorId(dgvRutas["idTipoDeUnidad", i].Value.ToString());
                    dgvRutas["nombreUnidad", i].Value = tUnidad.Descripcion;
                }
                mostrarLabelStatus("Se han cargado toda las rutas.", true);
                filaSeleccionada = 0;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tienen rutas registradas.", false);
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
        private void dgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void FormRutas_Shown(object sender, EventArgs e)
        {
            cargarTodasLasRutas();
        }


        /*-------------------*/
    }
}
