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
    public partial class FormAgregarViaje : Form
    {
        IViajeManager managerViajes;
        IStatusViajeManager managerStatus;
        IRutaManager managerRuta;
        IClienteManager managerCliete;
        IOperadorManager managerOperador;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        viaje entidadAeditar;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarViaje(string evento, int id)
        {
            InitializeComponent();
            managerViajes = Tools.FabricManager.ViajeManager();
            managerStatus = Tools.FabricManager.StatusViajeManager();
            managerRuta = Tools.FabricManager.RutaManager();
            managerCliete = Tools.FabricManager.ClienteManager();
            managerOperador = Tools.FabricManager.OperadorManager();
            accion = evento;
            idAEditar = id;
        }

        private void FormAgregarViaje_Load(object sender, EventArgs e)
        {
            cargarComboRutas();
            cargarComboClientes();
            cargarComboOperadores();
            cargarComboStatus();
            if (accion == "editar")
            {
                entidadAeditar = managerViajes.BuscarPorId(idAEditar.ToString());
                statusviaje entidadStatus = managerStatus.BuscarPorId(entidadAeditar.IdStatus.ToString());
                ruta entidadRuta = managerRuta.BuscarPorId(entidadAeditar.IdRuta.ToString());
                cliente entidadCliente = managerCliete.BuscarPorId(entidadAeditar.IdCliente.ToString());
                operador entidadOperador = managerOperador.BuscarPorId(entidadAeditar.IdOperador.ToString());

                textClaveViajeCliente.Text = entidadAeditar.IdViajeCliente;
                //dateTimeInicioSci.Value = entidadAeditar.FechaInicioSci;
                //dateTimeInicioCliente.Value = entidadAeditar.FechaInicioCliente;
                //dateTimeFinSci.Value = entidadAeditar.FechaFinSci;
                //dateTimeFinCliente.Value = entidadAeditar.FechaFinCliente;

                textDateInicioSci.Text = entidadAeditar.FechaInicioSci.ToString();
                textDateInicioCliente.Text = entidadAeditar.FechaInicioCliente.ToString();
                textDateFinSci.Text = entidadAeditar.FechaFinSci.ToString();
                textDateFinCliente.Text = entidadAeditar.FechaFinCliente.ToString();

                comboRutas.Text = entidadRuta.IdRuta.ToString() + "/" + entidadRuta.Nombre + "/" + entidadRuta.Costo.ToString();
                comboClientes.Text = entidadCliente.IdCliente.ToString() + "/" + entidadCliente.RazonSocial + "/" + entidadCliente.Telefono;
                comboOperadores.Text = entidadOperador.IdOperador.ToString() + "/" + entidadOperador.Nombre + "/" + entidadOperador.Salarioporhora.ToString();
                comboStatus.Text = entidadStatus.IdStatus.ToString() + "/" + entidadStatus.Nombre;
                comboStatus.Enabled = true;

                this.Text = "Actualizar los datos del Viaje.";
            }
            else
            {
                statusviaje estado = managerStatus.BuscaPorStatus("En Planeación");
                comboStatus.Text = estado.IdStatus + "/" + estado.Nombre;
            }
        }

        private void cargarComboStatus()
        {
            IEnumerable<statusviaje> StatusViaje = managerStatus.ObtenerTodos;
            comboStatus.DataSource = StatusViaje.Select(r => (r.IdStatus + "/ " + r.Nombre)).ToList();
            comboStatus.Text = string.Empty;
        }

        private void cargarComboOperadores()
        {
            IEnumerable<operador> operadores = managerOperador.ObtenerTodos;
            comboOperadores.DataSource = operadores.Select(r => (r.IdOperador + "/ " + r.Nombre + "/" + r.Salarioporhora)).ToList();
            comboOperadores.Text = string.Empty;
        }

        private void cargarComboClientes()
        {
            IEnumerable<cliente> cliente = managerCliete.ObtenerTodos;
            comboClientes.DataSource = cliente.Select(r => (r.IdCliente + "/ " + r.RazonSocial + "/" + r.Telefono)).ToList();
            comboClientes.Text = string.Empty;
        }

        private void cargarComboRutas()
        {
            IEnumerable<ruta> rutas = managerRuta.ObtenerTodos;
            comboRutas.DataSource = rutas.Select(r => (r.IdRuta + "/ " + r.Nombre + "/" + r.Costo)).ToList();
            comboRutas.Text = string.Empty;
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            
            try
            {
                string[] splitRutas;
                splitRutas = comboRutas.Text.Split('/');
                int idRuta = int.Parse(splitRutas[0]);

                string[] splitClientes;
                splitClientes = comboClientes.Text.Split('/');
                int idCliente = int.Parse(splitClientes[0]);

                string[] splitOperadores;
                splitOperadores = comboOperadores.Text.Split('/');
                int idOperador = int.Parse(splitOperadores[0]);

                string[] splitStatus;
                splitStatus = comboStatus.Text.Split('/');
                int idStatus = int.Parse(splitStatus[0]);

                if (accion == "agregar")
                {
                    try
                    {
                        viaje viajeNuevo = CrearViaje(idStatus, idRuta, idCliente, idOperador);
                        if (managerViajes.Insertar(viajeNuevo))
                        {
                            resultado = "Se ha agregado correctamente el Viaje.";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerViajes.Error, "Error al ingresar el nuevo Viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el nuevo Viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (accion == "editar")
                    {
                        try
                        {
                            entidadAeditar.IdViajeCliente = textClaveViajeCliente.Text;
                            entidadAeditar.FechaInicioSci = dateTimeInicioSci.Value;
                            entidadAeditar.FechaInicioCliente = dateTimeInicioCliente.Value;
                            entidadAeditar.FechaFinSci = dateTimeFinSci.Value;
                            entidadAeditar.FechaFinCliente = dateTimeFinCliente.Value;
                            entidadAeditar.IdRuta = idRuta;
                            entidadAeditar.IdCliente = idCliente;
                            entidadAeditar.IdOperador = idOperador;
                            entidadAeditar.IdStatus = idStatus;

                            if (managerViajes.Actualizar(entidadAeditar))
                            {
                                resultado = "Se ha actualizado correctamente los datos del Viaje.";
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(managerViajes.Error, "Error al actualizar los datos del Viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar los datos del Viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error al intentar Guardar El viaje. " + ex.Message, "Error al ingresar el Viaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            // MessageBox.Show("Fecha Inicio:" + cal1.SelectionStart + " Fecha de FIn:" + cal1.SelectionEnd);
        }

        private viaje CrearViaje(int idStatus, int idRuta, int idCliente, int idOperador)
        {
            return new viaje
            {
                IdViajeCliente = textClaveViajeCliente.Text,
                FechaInicioSci = DateTime.Parse(textDateInicioSci.Text), //dateTimeInicioSci.Value,
                FechaInicioCliente = DateTime.Parse(textDateInicioCliente.Text), //dateTimeInicioCliente.Value,
                FechaFinSci = DateTime.Parse(textDateFinSci.Text),// dateTimeFinSci.Value,
                FechaFinCliente = DateTime.Parse(textDateFinCliente.Text),// dateTimeFinCliente.Value,
                IdStatus = idStatus,
                IdRuta = idRuta,
                IdCliente = idCliente,
                IdOperador = idOperador
            };
        }

        private void calendarSci_DateSelected(object sender, DateRangeEventArgs e)
        {
            textDateInicioSci.Text = e.Start.ToString();
            textDateFinSci.Text = e.End.ToString();
        }

        private void CalendarCliente_DateSelected(object sender, DateRangeEventArgs e)
        {
            textDateInicioCliente.Text = e.Start.ToString();
            textDateFinCliente.Text = e.End.ToString();
        }

    }
}
