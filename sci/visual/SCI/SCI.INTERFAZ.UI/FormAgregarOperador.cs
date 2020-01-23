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
    public partial class FormAgregarOperador : Form
    {
        IOperadorManager managerOperador;
        string resultado = string.Empty;
        string accion = string.Empty;
        int idOperadorAEditar = -1;
        operador operadorAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarOperador(string evento, int id)
        {
            InitializeComponent();
            managerOperador = Tools.FabricManager.OperadorManager();
            accion = evento;
            idOperadorAEditar = id;
        }

        private operador CrearOperador()
        {
            return new operador
            {
                Nombre = textNombre.Text,
                Apellidos = textApellidos.Text,
                FechaIngreso = DateTime.Parse(dateTimeFechaIngreso.Text),
                Salarioporhora = double.Parse(textSalarioXhora.Text),
                Direccion = textDireccion.Text
            };
        }

        private void btnAgregarOperador_Click(object sender, EventArgs e)
        {
            if (accion == "agregar")
            {
                try
                {
                    operador operadorNuevo = CrearOperador();
                    if (managerOperador.Insertar(operadorNuevo))
                    {
                        resultado = "Se ha agregado correctamente el nuevo Operador.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerOperador.Error, "Error al ingresar el nuevo Operador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el nuevo operador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        operadorAeditar.Nombre = textNombre.Text;
                        operadorAeditar.Apellidos = textApellidos.Text;
                        operadorAeditar.FechaIngreso = DateTime.Parse(dateTimeFechaIngreso.Text);
                        operadorAeditar.Salarioporhora = double.Parse(textSalarioXhora.Text);
                        operadorAeditar.Direccion = textDireccion.Text;

                        if (managerOperador.Actualizar(operadorAeditar))
                        {
                            resultado = "Se ha actualizado correctamente los datos de la unidad.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerOperador.Error, "Error al intentar actualizar el nuevo Operador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el nuevo Operador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormAgregarOperador_Load(object sender, EventArgs e)
        {
            if (accion == "editar")
            {
                operadorAeditar = managerOperador.BuscarPorId(idOperadorAEditar.ToString());
                textNombre.Text = operadorAeditar.Nombre;
                textApellidos.Text = operadorAeditar.Apellidos;
                dateTimeFechaIngreso.Value = operadorAeditar.FechaIngreso;
                textSalarioXhora.Text = operadorAeditar.Salarioporhora.ToString();
                textDireccion.Text = operadorAeditar.Direccion;
                this.Text = "Actualizar los datos del Operador.";
            }
        }
    }
}
