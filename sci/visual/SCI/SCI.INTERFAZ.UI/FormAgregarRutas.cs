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
    public partial class FormAgregarRutas : Form
    {
        IUnidadesManager managerUnidades;
        IRutaManager managerRutas;
        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        ruta entidadAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarRutas(string evento, int id)
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerRutas = Tools.FabricManager.RutaManager();
            accion = evento;
            idAEditar = id;
        }

        public void cargarComboUnidades()
        {
            IEnumerable<unidades> unidades = managerUnidades.ObtenerTodos;
            comboUnidades.DataSource = unidades.Select(u=> (u.IdUnidad + "/ " +u.Nombre + "/" + u.NumeroEconomico)).ToList();
        }

        private void FormAgregarRutas_Load(object sender, EventArgs e)
        {
            cargarComboUnidades();
            if (accion == "editar")
            {
                entidadAeditar = managerRutas.BuscarPorId(idAEditar.ToString());
                unidades unidad = managerUnidades.BuscarPorId(entidadAeditar.IdUnidad.ToString());
                textNombre.Text = entidadAeditar.Nombre;
                textCosto.Text = entidadAeditar.Costo.ToString();
                comboUnidades.Text = unidad.IdUnidad + "/" + unidad.Nombre + "/" + unidad.NumeroEconomico;
                this.Text = "Actualizar los datos de la Ruta.";
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string[] cadenaUnidades;
            cadenaUnidades = comboUnidades.Text.Split('/');
            int idUnidadSeleccionada = int.Parse(cadenaUnidades[0]);

            if (accion == "agregar")
            {
                try
                {
                    ruta rutaNueva = CrearRuta(idUnidadSeleccionada);
                    if (managerRutas.Insertar(rutaNueva))
                    {
                        resultado = "Se ha agregado correctamente la nueva Ruta.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerRutas.Error, "Error al ingresar la nueva Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        entidadAeditar.Nombre = textNombre.Text;
                        entidadAeditar.Costo = double.Parse(textCosto.Text);
                        entidadAeditar.IdUnidad = idUnidadSeleccionada;

                        if (managerRutas.Actualizar(entidadAeditar))
                        {
                            resultado = "Se ha actualizado correctamente los datos de la ruta.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerRutas.Error, "Error al actualizar los datos de la Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private ruta CrearRuta(int idUnidadSeleccionada)
        {
            return new ruta
            {
                Nombre = textNombre.Text,
                Costo = double.Parse(textCosto.Text),
                IdUnidad = idUnidadSeleccionada
            };
        }
    }
}
