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
        //IUnidadesManager managerUnidades;
        IRutaManager managerRutas;
        ITipoDeUnidadManager managerTipoDeUnidades;

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
            managerTipoDeUnidades = Tools.FabricManager.TipoDeUnidadesManager();
            managerRutas = Tools.FabricManager.RutaManager();
            accion = evento;
            idAEditar = id;
        }

        private void cargarTiposDeUnidades()
        {
            IEnumerable<tipounidad> tiposDeUnidades = managerTipoDeUnidades.ObtenerTodos;
            comboTipoDeUnidad.DataSource = tiposDeUnidades.Select(u => (u.IdTipoDeUnidad + "/" + u.Descripcion)).ToList();
        }

        

        private void FormAgregarRutas_Load(object sender, EventArgs e)
        {
            cargarTiposDeUnidades();
            if (accion == "editar")
            {
                entidadAeditar = managerRutas.BuscarPorId(idAEditar.ToString());
                tipounidad Tunidad = managerTipoDeUnidades.BuscarPorId(entidadAeditar.IdTipoDeUnidad.ToString());
                textNombre.Text = entidadAeditar.Nombre;
                textCosto.Text = entidadAeditar.Costo.ToString();
                comboTipoDeUnidad.Text = Tunidad.IdTipoDeUnidad + "/" + Tunidad.Descripcion;
                this.Text = "Actualizar los datos de la Ruta.";
                btnAgregarRuta.Text = "Editar Ruta";
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string[] cadena;
            cadena = comboTipoDeUnidad.Text.Split('/');
            int idTipoUnidad = int.Parse(cadena.First());

            if (accion == "agregar")
            {
                try
                {
                    ruta rutaNueva = CrearRuta(idTipoUnidad);
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
                        entidadAeditar.IdTipoDeUnidad = idTipoUnidad;

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

        private ruta CrearRuta(int idTipoDeUnidad)
        {
            return new ruta
            {
                Nombre = textNombre.Text,
                Costo = double.Parse(textCosto.Text),
                IdTipoDeUnidad = idTipoDeUnidad
            };
        }
    }
}
