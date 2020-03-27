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
        ILogManager managerLog;
        IClienteManager managerCliente;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        ruta entidadAeditar;
        usuario user;
        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarRutas(usuario u,string evento, int id)
        {
            InitializeComponent();
            managerTipoDeUnidades = Tools.FabricManager.TipoDeUnidadesManager();
            managerRutas = Tools.FabricManager.RutaManager();
            managerLog = Tools.FabricManager.LogManager();
            managerCliente = Tools.FabricManager.ClienteManager();
            accion = evento;
            idAEditar = id;
            user = u;
        }

        private void cargarTodosLosClientes()
        {
            IEnumerable<cliente> todosLosClientes = managerCliente.ObtenerTodos;
            comboClientes.DataSource = todosLosClientes.Select(c => (c.IdCliente + "/" + c.RazonSocial)).ToList();
        }

        private void FormAgregarRutas_Load(object sender, EventArgs e)
        {
            //cargarTiposDeUnidades();
            cargarTodosLosClientes();

            if (accion == "editar")
            {
                entidadAeditar = managerRutas.BuscarPorId(idAEditar);
                cliente  clienteSeleccionado= managerCliente.BuscarPorId(entidadAeditar.IdCliente);
                textNombre.Text = entidadAeditar.Nombre;
                textCosto.Text = entidadAeditar.Costo.ToString();
                comboClientes.Text = clienteSeleccionado.IdCliente + "/" + clienteSeleccionado.RazonSocial;
                comboUnidadAFacturar.Text = entidadAeditar.UnidadAFacturar;
                this.Text = "Actualizar los datos de la Ruta.";
                btnAgregarRuta.Text = "Editar Ruta";
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            string[] cadena;
            cadena = comboClientes.Text.Split('/');
            int idCliente = int.Parse(cadena.First());

            if (accion == "agregar")
            {
                try
                {
                    ruta rutaNueva = CrearRuta(idCliente);
                    if (nombreRutaesValido(rutaNueva.Nombre))
                    {
                        if (managerRutas.Insertar(rutaNueva))
                        {
                            resultado = "Se ha agregado correctamente la nueva Ruta.";
                            ruta lastRuta = managerRutas.BuscarUltimoIngresado();
                            log registro = new log
                            {
                                Accion = "agregar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "ruta-id:" + lastRuta.IdRuta
                            };
                            managerLog.Insertar(registro);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerRutas.Error, "Error al ingresar la nueva Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Ya existe una ruta con ese mismo nombre, es necesario que sean diferentes.", "Error al ingresar la nueva Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (entidadAeditar.Nombre != textNombre.Text.Trim())
                        {
                            entidadAeditar.Nombre = textNombre.Text.Trim();
                            entidadAeditar.Costo = double.Parse(textCosto.Text);
                            entidadAeditar.UnidadAFacturar = comboUnidadAFacturar.Text;
                            entidadAeditar.IdCliente = idCliente;

                            if (nombreRutaesValido(entidadAeditar.Nombre))
                            {
                                //continuar
                                if (managerRutas.Actualizar(entidadAeditar))
                                {
                                    resultado = "Se ha actualizado correctamente los datos de la ruta.";
                                    log registro = new log
                                    {
                                        Accion = "editar",
                                        NombreUsuario = user.NombreUsuario,
                                        Fecha = DateTime.Now,
                                        ModuloAfectado = "ruta-id:" + entidadAeditar.IdRuta
                                    };
                                    managerLog.Insertar(registro);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(managerRutas.Error, "Error al actualizar los datos de la Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                                MessageBox.Show("Ya existe una ruta con ese mismo nombre, es necesario que sean diferentes.", "Error al ingresar la nueva Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            entidadAeditar.Nombre = textNombre.Text.Trim();
                            entidadAeditar.Costo = double.Parse(textCosto.Text);
                            entidadAeditar.UnidadAFacturar = comboUnidadAFacturar.Text;
                            entidadAeditar.IdCliente = idCliente;

                            if (managerRutas.Actualizar(entidadAeditar))
                            {
                                resultado = "Se ha actualizado correctamente los datos de la ruta.";
                                log registro = new log
                                {
                                    Accion = "editar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "ruta-id:" + entidadAeditar.IdRuta
                                };
                                managerLog.Insertar(registro);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(managerRutas.Error, "Error al actualizar los datos de la Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la Ruta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private bool nombreRutaesValido(string nombre)
        {
            ruta rutaEncontrada = managerRutas.BuscarPorNombreExacto(nombre);
            if (rutaEncontrada == null) return true;
            return false;
        }

        private ruta CrearRuta(int idCliente)
        {
            return new ruta
            {
                Nombre = textNombre.Text.Trim(),
                Costo = double.Parse(textCosto.Text),
                UnidadAFacturar = comboUnidadAFacturar.Text,
                IdCliente = idCliente
                //IdTipoDeUnidad = idTipoDeUnidad
            };
        }
    }
}
