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
    public partial class FormAgregarStatus : Form
    {
        IStatusViajeManager managerStatus;
        ILogManager managerLog;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        statusviaje entidadAeditar;
        usuario user;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarStatus(usuario u, string evento, int id)
        {
            InitializeComponent();
            managerStatus = Tools.FabricManager.StatusViajeManager();
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
                    statusviaje nuevoStatusViaje = new statusviaje { Nombre = textNombre.Text };
                    if (managerStatus.Insertar(nuevoStatusViaje))
                    {
                        statusviaje lastStatusViaje = managerStatus.BuscarUltimoIngresado();
                        log registro = new log
                        {
                            Accion = "agregar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "statusviaje-id:" + lastStatusViaje.IdStatus
                        };
                        managerLog.Insertar(registro);

                        resultado = "Se ha agregado correctamente el nuevo status del Viaje.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerStatus.Error, "Error al ingresar el Status.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar El status del Viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        entidadAeditar.Nombre = textNombre.Text;

                        if (managerStatus.Actualizar(entidadAeditar))
                        {
                            log registro = new log
                            {
                                Accion = "editar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "statusviaje-id:" + entidadAeditar.IdStatus
                            };
                            managerLog.Insertar(registro);
                            resultado = "Se han actualizado correctamente el status.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerStatus.Error, "Error al actualizar el nombre del Status.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el status.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormAgregarStatus_Load(object sender, EventArgs e)
        {
            if (accion == "editar")
            {
                entidadAeditar = managerStatus.BuscarPorId(idAEditar);
                textNombre.Text = entidadAeditar.Nombre;
                this.Text = "Actualizar los datos del Status.";
            }
        }
    }
}
