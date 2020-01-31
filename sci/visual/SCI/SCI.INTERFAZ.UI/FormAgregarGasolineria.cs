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
    public partial class FormAgregarGasolineria : Form
    {
        IGasolineriaManager managerGasolineria;
        ITipoDeGastoManager managerTipoDeGasto;
        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        gasolineria entidadAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarGasolineria(string evento, int id)
        {
            InitializeComponent();
            managerGasolineria = Tools.FabricManager.GasolineriaManager();
            managerTipoDeGasto = Tools.FabricManager.TipoDeGastoManager();
            accion = evento;
            idAEditar = id;
        }

        private void FormAgregarGasolineria_Load(object sender, EventArgs e)
        {
            cargarTipoGasto();
            if (accion == "editar")
            {
                entidadAeditar = managerGasolineria.BuscarPorId(idAEditar.ToString());
                tipogasto Tgasto = managerTipoDeGasto.BuscarPorId(entidadAeditar.IdTipoGasto.ToString());
                textNombre.Text = entidadAeditar.Nombre;
                textDireccion.Text = entidadAeditar.Direccion.ToString();
                textRfc.Text = entidadAeditar.Rfc;
                textRazonSocial.Text = entidadAeditar.RazonSocial;
                textTelefono.Text = entidadAeditar.Telefono;
                textCorreo.Text = entidadAeditar.Correo;

                comboTipoDeGasto.Text = Tgasto.IdTipoGasto + "/" + Tgasto.Concepto;
                this.Text = "Actualizar los datos de la Gasolinería.";
                btnAgregarRuta.Text = "Actualizar";
            }
        }
        private void cargarTipoGasto()
        {
            tipogasto tiposDeGastoGasolina = managerTipoDeGasto.BuscaPorConcepto("Combustible");
            if(tiposDeGastoGasolina != null)
                comboTipoDeGasto.Text = tiposDeGastoGasolina.IdTipoGasto.ToString() + "/" + tiposDeGastoGasolina.Concepto;
        }

        private gasolineria CrearGasolineria(int idTipoGasto)
        {
            return new gasolineria
            {
                Nombre = textNombre.Text,
                Direccion = textDireccion.Text,
                Rfc = textRfc.Text,
                RazonSocial = textRazonSocial.Text,
                Telefono = textTelefono.Text,
                Correo = textCorreo.Text,
                IdTipoGasto = idTipoGasto
            };
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string[] cadenaTipoGasto;
            cadenaTipoGasto = comboTipoDeGasto.Text.Split('/');
            int idTipoGasto = int.Parse(cadenaTipoGasto.First());

            if (accion == "agregar")
            {
                try
                {
                    gasolineria gasolineriaNueva = CrearGasolineria(idTipoGasto);
                    if (managerGasolineria.Insertar(gasolineriaNueva))
                    {
                        resultado = "Se ha agregado correctamente la nueva Gasolinería.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerGasolineria.Error, "Error al ingresar la nueva Gasolinería.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Gasolinería.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        entidadAeditar.Nombre = textNombre.Text;
                        entidadAeditar.Direccion = textDireccion.Text;
                        entidadAeditar.Rfc = textRfc.Text;
                        entidadAeditar.RazonSocial = textRazonSocial.Text;
                        entidadAeditar.Telefono = textTelefono.Text;
                        entidadAeditar.Correo = textCorreo.Text;
                        entidadAeditar.IdTipoGasto = idTipoGasto;

                        if (managerGasolineria.Actualizar(entidadAeditar))
                        {
                            resultado = "Se ha actualizado correctamente los datos de la Gasolinería.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerGasolineria.Error, "Error al actualizar los datos de la Gasolinería.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la Gasolinería.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
