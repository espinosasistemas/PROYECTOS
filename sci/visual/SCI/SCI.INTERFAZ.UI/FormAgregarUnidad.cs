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
    public partial class FormAgregarUnidad : Form
    {
        IUnidadesManager managerUnidades;
        string resultado = string.Empty;
        string accion = string.Empty;
        int idUnidadAEditar = 0;
        unidades unidadAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarUnidad(string evento, int id)
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
            accion = evento;
            idUnidadAEditar = id;
        }

        private void FormAgregarUnidad_Load(object sender, EventArgs e)
        {
            if (accion == "editar")
            {
                unidadAeditar = managerUnidades.BuscarPorId(idUnidadAEditar.ToString());
                textNombreUnidad.Text = unidadAeditar.Nombre;
                textNumEco.Text = unidadAeditar.NumeroEconomico.ToString();
                textPlacas.Text = unidadAeditar.Placas;
                textNumSerie.Text = unidadAeditar.NumeroSerie;
                comboTipoCombustible.Text = unidadAeditar.TipoCombustible;
                this.Text = "Actualizar los datos de la Unidad.";
            }
        }

        private unidades CrearUnidad()
        {
            return new unidades
            {
                Nombre = textNombreUnidad.Text,
                NumeroEconomico = int.Parse(textNumEco.Text),
                Placas = textPlacas.Text,
                NumeroSerie = textNumSerie.Text,
                TipoCombustible = comboTipoCombustible.Text
            };
        }

        private void btnCrearUnidad_Click(object sender, EventArgs e)
        {
            if (accion == "agregar")
            {
                try
                {
                    unidades nuevaUnidad = CrearUnidad();
                    if (managerUnidades.Insertar(nuevaUnidad))
                        resultado = "Se ha agregado correctamente la nueva unidad.";
                    else
                        resultado = managerUnidades.Error;

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        unidadAeditar.Nombre = textNombreUnidad.Text;
                        unidadAeditar.NumeroEconomico = int.Parse(textNumEco.Text);
                        unidadAeditar.Placas = textPlacas.Text;
                        unidadAeditar.NumeroSerie = textNumSerie.Text;
                        unidadAeditar.TipoCombustible = comboTipoCombustible.Text;

                        if (managerUnidades.Actualizar(unidadAeditar))
                            resultado = "Se ha actualizado correctamente los datos de la unidad.";
                        else
                            resultado = managerUnidades.Error;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

        /* private bool ValidadFormulario()
         {
             if (textNombreUnidad.Text == string.Empty)
             {
                 textNombreUnidad.Focus();
                 return false;
             }
             if (textNumEco.Text == string.Empty)
             {
                 textNumEco.Focus();
                 return false;
             }

             if (textPlacas.Text == string.Empty)
             {
                 textPlacas.Focus();
                 return false;
             }
             if (textNumSerie.Text == string.Empty)
             {
                 textNumSerie.Focus();
                 return false;
             }
             if (comboTipoCombustible.Text == string.Empty)
             {
                 comboTipoCombustible.Focus();
                 return false;
             }
             try
             {
                 int.Parse(textNumEco.Text);
             }
             catch (Exception)
             {
                 return false;
             }

             return true;
         }*/
    }
}
