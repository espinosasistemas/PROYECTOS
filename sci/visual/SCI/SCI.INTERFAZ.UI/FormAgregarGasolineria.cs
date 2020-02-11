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
        ILogManager managerLog;
        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        gasolineria entidadAeditar;
        usuario user;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarGasolineria(usuario u, string evento, int id)
        {
            InitializeComponent();
            managerGasolineria = Tools.FabricManager.GasolineriaManager();
            managerTipoDeGasto = Tools.FabricManager.TipoDeGastoManager();
            managerLog = Tools.FabricManager.LogManager();
            accion = evento;
            idAEditar = id;
            user = u;
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
                if (rfcEstaDadoDeAlta() == true)
                {
                    MessageBox.Show("El Rfc de la Gaslinería ya esta dado de alta.", "No se pudo agregar La Gasolinería.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    gasolineria gasolineriaNueva = CrearGasolineria(idTipoGasto);
                    if (managerGasolineria.Insertar(gasolineriaNueva))
                    {
                        gasolineria lastGasolineria = managerGasolineria.BuscarUltimoIngresado();
                        log registro = new log
                        {
                            Accion = "agregar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "gasolineria-id:" + lastGasolineria.IdGasolineria
                        };
                        managerLog.Insertar(registro);

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
                            log registro = new log
                            {
                                Accion = "editar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "gasolineria-id:" + entidadAeditar.IdGasolineria
                            };
                            managerLog.Insertar(registro);

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

        private bool rfcEstaDadoDeAlta()
        {
            gasolineria gasNueva = managerGasolineria.BuscarPorRfc(textRfc.Text);
            if (gasNueva != null) return true;
            else return false; //ya esta agregada
        }

        private void textRfc_Leave(object sender, EventArgs e)
        {
            textRfc.Text = textRfc.Text.Trim();
            textRfc.Text = textRfc.Text.ToUpper();
        }
    }
}
