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
    public partial class FormAgregarTipoDeGasto : Form
    {
        ITipoDeGastoManager managerTipoDeGasto;
        ILogManager managerLog;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        tipogasto entidadAeditar;
        usuario user;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarTipoDeGasto(usuario u,string evento, int id)
        {
            InitializeComponent();
            managerTipoDeGasto = Tools.FabricManager.TipoDeGastoManager();
            managerLog = Tools.FabricManager.LogManager();
            accion = evento;
            idAEditar = id;
            user = u;
        }

        private void btnAgregarTipoGasto_Click(object sender, EventArgs e)
        {
            if (accion == "agregar")
            {
                try
                {
                    tipogasto nuevoTipoGasto = new tipogasto { Concepto = textConcepto.Text };
                    if (managerTipoDeGasto.Insertar(nuevoTipoGasto))
                    {
                        tipogasto lastTipoGasto = managerTipoDeGasto.BuscarUltimoIngresado();
                        log registro = new log
                        {
                            Accion = "agregar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "tipogasto-id:" + lastTipoGasto.IdTipoGasto
                        };
                        managerLog.Insertar(registro);

                        resultado = "Se ha agregado correctamente el nuevo tipo de Gasto.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerTipoDeGasto.Error, "Error al ingresar el Tipo de Gasto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar El tipo de Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        entidadAeditar.Concepto = textConcepto.Text;

                        if (managerTipoDeGasto.Actualizar(entidadAeditar))
                        {
                            log registro = new log
                            {
                                Accion = "editar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "tipogasto-id:" + entidadAeditar.IdTipoGasto
                            };
                            managerLog.Insertar(registro);

                            resultado = "Se han actualizado correctamente el tipo de Gasto.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerTipoDeGasto.Error, "Error al actualizar los datos del Tipo de Concepto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el tipo de Concepto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormAgregarTipoDeGasto_Load(object sender, EventArgs e)
        {
            if (accion == "editar")
            {
                entidadAeditar = managerTipoDeGasto.BuscarPorId(idAEditar);
                textConcepto.Text = entidadAeditar.Concepto;
                this.Text = "Actualizar los datos del conceptos.";
            }
        }
    }
}
