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

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarUnidad()
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
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
            if (ValidadFormulario())
            {
                unidades nuevaUnidad = CrearUnidad();
                if (managerUnidades.Insertar(nuevaUnidad))
                    resultado = "Se ha agregado correctamente la nueva unidad.";
                else
                    resultado = managerUnidades.Error;

                this.Close();
            }

        }

        private bool ValidadFormulario()
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
        }
    }
}
