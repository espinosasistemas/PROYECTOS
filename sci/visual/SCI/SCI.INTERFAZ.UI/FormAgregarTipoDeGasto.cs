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
        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        tipogasto entidadAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarTipoDeGasto(string evento, int id)
        {
            InitializeComponent();
            managerTipoDeGasto = Tools.FabricManager.TipoDeGastoManager();
            accion = evento;
            idAEditar = id;
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
                entidadAeditar = managerTipoDeGasto.BuscarPorId(idAEditar.ToString());
                textConcepto.Text = entidadAeditar.Concepto;
                this.Text = "Actualizar los datos del conceptos.";
            }
        }
    }
}
