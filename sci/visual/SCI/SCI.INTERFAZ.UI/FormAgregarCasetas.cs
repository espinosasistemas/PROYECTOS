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
    public partial class FormAgregarCasetas : Form
    {
        ICasetaManager managerCasetas;
        ITipoDeUnidadManager managerTipoDeUnidades;
        ITipoDeGastoManager managerTipoDeGasto;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        caseta entidadAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarCasetas(string evento, int id)
        {
            InitializeComponent();
            managerCasetas = Tools.FabricManager.CasetaManager();
            managerTipoDeUnidades = Tools.FabricManager.TipoDeUnidadesManager();
            managerTipoDeGasto = Tools.FabricManager.TipoDeGastoManager();
            accion = evento;
            idAEditar = id;
        }

        private void FormAgregarCasetas_Load(object sender, EventArgs e)
        {
            cargarTiposDeUnidades();
            cargarTipoGasto();
            if (accion == "editar")
            {
                entidadAeditar = managerCasetas.BuscarPorId(idAEditar.ToString());
                tipounidad Tunidad = managerTipoDeUnidades.BuscarPorId(entidadAeditar.IdTipoDeUnidad.ToString());
                textNombre.Text = entidadAeditar.Nombre;
                textCosto.Text = entidadAeditar.Costo.ToString();
                comboTipoDeUnidad.Text = Tunidad.IdTipoDeUnidad + "/" + Tunidad.Descripcion;
                this.Text = "Actualizar los datos de la Ruta.";
                btnAgregarRuta.Text = "Actualizar";
            }
        }

        private void cargarTiposDeUnidades()
        {
            IEnumerable<tipounidad> tiposDeUnidades = managerTipoDeUnidades.ObtenerTodos;
            comboTipoDeUnidad.DataSource = tiposDeUnidades.Select(u => (u.IdTipoDeUnidad + "/" + u.Descripcion)).ToList();
        }

        private void cargarTipoGasto()
        {
            tipogasto tiposDeGastoGasolina = managerTipoDeGasto.BuscaPorConcepto("Casetas");
            comboTipoDeGasto.Text = tiposDeGastoGasolina.IdTipoGasto.ToString() + "/" + tiposDeGastoGasolina.Concepto;
        }

        private caseta CrearCaseta(int idTipoUnidad, int idTipoGasto)
        {
            return new caseta
            {
                Nombre = textNombre.Text,
                Costo = double.Parse(textCosto.Text),
                IdTipoDeUnidad = idTipoUnidad,
                IdTipoDeGasto = idTipoGasto
            };
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string[] cadena;
            cadena = comboTipoDeUnidad.Text.Split('/');
            int idTipoUnidad = int.Parse(cadena.First());

            string[] cadenaTipoGasto;
            cadenaTipoGasto = comboTipoDeGasto.Text.Split('/');
            int idTipoGasto = int.Parse(cadenaTipoGasto.First());

            if (accion == "agregar")
            {
                try
                {
                    caseta casetaNueva = CrearCaseta(idTipoUnidad, idTipoGasto);
                    if (managerCasetas.Insertar(casetaNueva))
                    {
                        resultado = "Se ha agregado correctamente la nueva Caseta.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerCasetas.Error, "Error al ingresar la nueva Caseta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Caseta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        entidadAeditar.IdTipoDeGasto = idTipoGasto;

                        if (managerCasetas.Actualizar(entidadAeditar))
                        {
                            resultado = "Se ha actualizado correctamente los datos de la caseta.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerCasetas.Error, "Error al actualizar los datos de la Caseta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la Caseta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
    }
}
