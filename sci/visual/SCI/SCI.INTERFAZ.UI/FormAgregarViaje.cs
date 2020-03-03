using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI.INTERFAZ.UI
{
    public partial class FormAgregarViaje : Form
    {
        #region Variables para Calendarios Inicial y Final
        string fechaInicialGeneral = string.Empty;
        int horaInicialGeneral = 0;
        int minutoInicialGeneral = 0;

        string fechaFinalGeneral = string.Empty;
        int horaFinalGeneral = 0;
        int minutoFinalGeneral = 0;

        string fechaDelGasto = string.Empty;
        int horaDelGasto = 0;
        int minutosDelGasto = 0;

        string fechaInicialCorte = string.Empty;
        int horaInicialCorte = 0;
        int minutoInicialCorte = 0;

        string fechaFinalCorte = string.Empty;
        int horaFinalCorte = 0;
        int minutoFinalCorte = 0;

        string fechaCobroAdicional = string.Empty;
        int horaCobroAdicional = 0;
        int minutoCobroAdicional = 0;

        #endregion

        #region primera parte
        IViajeManager managerViajes;
        IStatusViajeManager managerStatus;
        IRutaManager managerRuta;
        IClienteManager managerCliete;
        IOperadorManager managerOperador;
        ITipoDeGastoManager managerTiposDeGastos;
        IGastoManager managerGastos;
        ICortesOperadorManager managerCortes;
        ITipoDeUnidadManager managerTipoDeUnidad;
        IUnidadesManager managerUnidades;
        IGasolineriaManager managerGasolinerias;
        ICasetaManager managerCasetas;
        IOperadoresEnViajeManager managerOperadoresEnViaje;
        ILogManager managerLog;
        IDepositoManager managerDeposito;
        ICobroAdicionalManager managerCobrosAdicionales;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        string nombreArchivoPdf = string.Empty;
        string nombreArchivoXml = string.Empty;
        string nombreArchivoNuevoPdf = string.Empty;
        string nombreArchivoNuevoXml = string.Empty;
        string tipoDeGasto = string.Empty;
        int filaGastoSeleccionado = -1;
        int filaCorteSeleccionado = -1;
        int filaCobroAdicional = -1;
        bool editarGasto = false;
        bool editarCorte = false;
        bool editarCobroAdicional = false;
        int idGastoAeditar = 0;
        int idCorteAeditar = 0;
        int idCobroAdicional = 0;

        viaje entidadAeditar;
        statusviaje entidadStatus;
        ruta entidadRuta;
        cliente entidadCliente;
        unidades entidadUnidad;
        usuario user;


        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarViaje(usuario u, string evento, int id)
        {
            InitializeComponent();
            managerViajes = Tools.FabricManager.ViajeManager();
            managerStatus = Tools.FabricManager.StatusViajeManager();
            managerRuta = Tools.FabricManager.RutaManager();
            managerCliete = Tools.FabricManager.ClienteManager();
            managerOperador = Tools.FabricManager.OperadorManager();
            managerTiposDeGastos = Tools.FabricManager.TipoDeGastoManager();
            managerGastos = Tools.FabricManager.GastoManager();
            managerCortes = Tools.FabricManager.CortesOperadorManager();
            managerTipoDeUnidad = Tools.FabricManager.TipoDeUnidadesManager();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerGasolinerias = Tools.FabricManager.GasolineriaManager();
            managerCasetas = Tools.FabricManager.CasetaManager();
            managerOperadoresEnViaje = Tools.FabricManager.OperadoresEnViajeManager();
            managerLog = Tools.FabricManager.LogManager();
            managerDeposito = Tools.FabricManager.DepositoManager();
            managerCobrosAdicionales = Tools.FabricManager.CobrosAdicionalManager();

            accion = evento;
            idAEditar = id;
            user = u;
        }
        private void FormAgregarViaje_Load(object sender, EventArgs e)
        {
            //cargarComboRutas();
            cargarComboClientes();
            cargarComboStatus();
            
            //selectTipoDeGasto();
            cargarListaOperadores();
            cargarTodasLasUnidades();

            if (accion == "editar")
            {

                entidadAeditar = managerViajes.BuscarPorId(idAEditar.ToString()); //Se carga los datos del Viaje a editar
                if (entidadAeditar == null)
                {
                    Application.Exit();
                }

                //Se cargan las entidades ligadas con el viaje SCi
                entidadStatus = managerStatus.BuscarPorId(entidadAeditar.IdStatus.ToString());
                entidadRuta = managerRuta.BuscarPorId(entidadAeditar.IdRuta.ToString());
                entidadUnidad = managerUnidades.BuscarPorId(entidadAeditar.IdUnidad.ToString());
                entidadCliente = managerCliete.BuscarPorId(entidadRuta.IdCliente.ToString());

                //Se cargan los valores del viaje a los componentes
                #region Valores iniciales de las fechas
                textFechaInicial.Text = formatoFecha(entidadAeditar.FechaInicio);
                calendarInicialSci.SelectionRange.Start = entidadAeditar.FechaInicio;
                string[] cadenaFecha = textFechaInicial.Text.Split(' ');
                fechaInicialGeneral = cadenaFecha.First();
                horaInicialGeneral = entidadAeditar.FechaInicio.Hour;
                minutoInicialGeneral = entidadAeditar.FechaInicio.Minute;
                trackHorasInicio.Value = horaInicialGeneral;
                trackMinutosInicio.Value = minutoInicialGeneral;

                //Validación de la fechaInicial junto con sus elementos del Panel de fechas
                textFechaFinal.Text = formatoFecha(entidadAeditar.FechaFin);
                if (textFechaFinal.Text != "01/01/1 00:00:00")
                {
                    calendarFinalSci.SelectionRange.Start = entidadAeditar.FechaFin;
                    string[] cadenaFecha2 = textFechaFinal.Text.Split(' ');
                    fechaFinalGeneral = cadenaFecha2.First();
                    horaFinalGeneral = entidadAeditar.FechaFin.Hour;
                    minutoFinalGeneral = entidadAeditar.FechaFin.Minute;
                    trackHorasFinal.Value = horaFinalGeneral;
                    trackMinutosFinal.Value = minutoInicialGeneral;
                }
                else
                    textFechaFinal.Text = string.Empty;



                #endregion

                //Se inicializan los combos con los valores cargados del viaje
                textClaveViajeCliente.Text = entidadAeditar.IdViajeCliente;
                comboClientes.Text = entidadCliente.IdCliente.ToString() + "/" + entidadCliente.RazonSocial;
                comboRutas.Text = entidadRuta.IdRuta.ToString() + "/" + entidadRuta.Nombre;
                comboStatus.Text = entidadStatus.IdStatus.ToString() + "/" + entidadStatus.Nombre;
                comboUnidades.Text = entidadUnidad.NumeroEconomico.ToString() + "/" + entidadUnidad.Nombre;
                comboStatus.Enabled = true;

                //Carga todos los GASTOS relacionados con el Viaje en el dgv Del TabControl = Gastos
                cargarComboTipoDeGastos();
                cargarTodosLosGastosDelViaje();

                //Datos del operador y CORTES que se han hecho, tabControl = Cortes
                cargarTodosLosCortesDelViaje();
                cargarListaOperadoresAsignadosAlViaje();

                //Cargar los cobros adicionales
                cargarTodosCobrosAdicionales();

                labelTitulo.Text = "Editar el Viaje: " + entidadAeditar.IdViajeSci +  " Cliente: " + entidadCliente.RazonSocial ;
                btnAgregarViaje.Text = "Editar Viaje";
                textMontoGasto.Text = string.Empty;
                btnAgregarDeposito.Visible = true;
                btnArriba.Visible = true;
                btnAbajo.Visible = true;
            }
            else
            {
                //datos iniciales la orden es Agregar nuevo Viaje
                statusviaje estado = managerStatus.BuscaPorStatus("Iniciado");
                comboStatus.Text = estado.IdStatus + "/" + estado.Nombre;
                comboRutas.Text = string.Empty;
                comboClientes.Text = string.Empty;
                comboUnidades.Text = string.Empty;
                comboTipoGastos.Text = string.Empty;
                labelTotalDeGastos.Visible = false;
                labelSaldoTotalCortes.Visible = false;
                labelCobrosAdicionales.Visible = false;

                groupGastos.Enabled = false;
                groupCortesOPerador.Enabled = false;
                groupCobrosAdicionales.Enabled = false;
                labelTitulo.Text = "Viaje Nuevo de SCI";
            }

            limpiarFormularioRegistroDeGastos();
            editarGasto = false;

        }

        private void cargarTodosCobrosAdicionales()
        {
            dgvCobrosAdicionales.Columns.Clear();
            IEnumerable<cobrosadicionales> TodosLosCobrosAdicionales = managerCobrosAdicionales.BuscarCobrosPorViaje(entidadAeditar.IdViajeSci);
            dgvCobrosAdicionales.DataSource = TodosLosCobrosAdicionales.ToArray();
            labelCobrosAdicionales.Text = string.Format("{0:C2}", TodosLosCobrosAdicionales.Sum(g => g.Monto));
            labelCobrosAdicionales.Visible = true;
            if (dgvCobrosAdicionales.Rows.Count <= 0)
                labelCobrosAdicionales.Visible = false;
        }

        private void cargarListaOperadores()
        {
            IEnumerable<operador> operadores = managerOperador.ObtenerTodos;
            if (operadores != null)
            {
                comboOperadores.DataSource = operadores.OrderByDescending(s => s.Nombre).Select(r => (r.Nombre + " " + r.Apellidos)).ToList();
                comboOperadores.Text = string.Empty;
            }
        }
        private void cargarListaOperadoresAsignadosAlViaje()
        {
            //Se limpia el combo de Operadores Asignados para el corte
            comboOperadoresCortes.Items.Clear();
            comboOperadoresGasto.Items.Clear();

            //IEnumerable<operadoresenviaje> operadoresEnViaje = managerOperadoresEnViaje.ObtenerTodos;
            IEnumerable<operadoresenviaje> operadoresViaje = managerOperadoresEnViaje.BuscarPorIdViajeOps(entidadAeditar.IdViajeSci);
            if (operadoresViaje != null)
            {
                operadoresViaje = operadoresViaje.OrderBy(a => a.Posicion);
                operador op = new operador();
                foreach (var item in operadoresViaje)
                {
                    op = managerOperador.BuscarPorId(item.IdOperador.ToString());
                    listOperadoresAsignados.Items.Add(op.Nombre + " " + op.Apellidos);
                    comboOperadoresCortes.Items.Add(op.IdOperador + "/" + op.Nombre + " " + op.Apellidos);
                    comboOperadoresGasto.Items.Add(op.IdOperador + "/" + op.Nombre + " " + op.Apellidos);
                }
            }
            labelNombreOperador.Text = "--";
            labelTelOperador.Text = "--";
            labelSalarioPorHora.Text = "--";
            labelCorreoOperador.Text = "--";
        }
        private void cargarTodosLosCortesDelViaje()
        {
            dgvCortesOperador.Columns.Clear();
            IEnumerable<cortesoperador> TodosCortes = managerCortes.BuscarCortesPorIdViaje(entidadAeditar.IdViajeSci);
            dgvCortesOperador.DataSource = TodosCortes.ToArray();
            //labelSaldoTotalCortes.Text = "$" + TodosCortes.Sum(g => g.Costo).ToString();
            labelSaldoTotalCortes.Text = string.Format("{0:C2}", TodosCortes.Sum(g => g.Costo));


            dgvCortesOperador.Columns["idCorte"].Visible = false;
            dgvCortesOperador.Columns["idOperador"].Visible = false;
            dgvCortesOperador.Columns["idStatus"].Visible = false;
            dgvCortesOperador.Columns["idViajeSci"].Visible = false;

            if (dgvCortesOperador.Rows.Count > 0)
            {
                dgvCortesOperador.Columns.Add("Operador", "Operador");
                dgvCortesOperador.Columns.Add("Status", "Status");
                operador op = new operador();
                statusviaje status = new statusviaje();
                for (int i = 0; i < dgvCortesOperador.Rows.Count; i++)
                {
                    op = managerOperador.BuscarPorId(dgvCortesOperador["idOperador", i].Value.ToString());
                    status = managerStatus.BuscarPorId(dgvCortesOperador["idStatus", i].Value.ToString());
                    dgvCortesOperador["Operador", i].Value = op.Nombre + " " + op.Apellidos;
                    dgvCortesOperador["Status", i].Value = status.Nombre;
                }

                dgvCortesOperador.Columns["Operador"].DisplayIndex = 0;
                dgvCortesOperador.Columns["Horas"].DisplayIndex = 1;
                dgvCortesOperador.Columns["Costo"].DisplayIndex = 2;
                dgvCortesOperador.Columns["FechaInicio"].DisplayIndex = 3;
                dgvCortesOperador.Columns["FechaFin"].DisplayIndex = 4;
                dgvCortesOperador.Columns["Status"].DisplayIndex = 5;
            }
            else
                labelSaldoTotalCortes.Visible = false;
        }
        public void cargarTodosLosGastosDelViaje()
        {
            dgvGastos.Columns.Clear();
            IEnumerable<gasto> TodosLosGastos = managerGastos.BuscarPorIdViajeOps(entidadAeditar.IdViajeSci);
            dgvGastos.DataSource = TodosLosGastos.ToArray();
            //labelTotalDeGastos.Text = "$" + TodosLosGastos.Sum(g => g.Costo).ToString();
            labelTotalDeGastos.Text = string.Format("{0:C2}", TodosLosGastos.Sum(g => g.Costo));

            dgvGastos.Columns["idGasto"].Visible = false;
            dgvGastos.Columns["idTipoGasto"].Visible = false;
            dgvGastos.Columns["idOperador"].Visible = false;
            dgvGastos.Columns["idViajeSci"].Visible = false;

            if (dgvGastos.Rows.Count > 0)
            {
                dgvGastos.Columns.Add("TipoDeGasto", "TipoDeGasto");
                dgvGastos.Columns.Add("Operador", "Operador");
                tipogasto tGasto = new tipogasto();
                operador op = new operador();

                for (int i = 0; i < dgvGastos.Rows.Count; i++)
                {
                    tGasto = managerTiposDeGastos.BuscarPorId(dgvGastos["idTipoGasto", i].Value.ToString());
                    op = managerOperador.BuscarPorId(dgvGastos["idOperador", i].Value.ToString());

                    dgvGastos["TipoDeGasto", i].Value = tGasto.Concepto;
                    dgvGastos["Operador", i].Value = op.Nombre + " " + op.Apellidos;
                }
            }
            else
                labelTotalDeGastos.Visible = false;

        }
        private void cargarComboStatus()
        {
            IEnumerable<statusviaje> StatusViaje = managerStatus.ObtenerTodos;
            if (StatusViaje != null)
            {
                comboStatus.DataSource = StatusViaje.Select(r => (r.IdStatus + "/" + r.Nombre)).ToList();
                comboStatus.Text = string.Empty;
            }
        }
        private void cargarComboTipoDeGastos()
        {
            IEnumerable<tipogasto> tiposDeGastos = managerTiposDeGastos.ObtenerTodos;
            comboTipoGastos.DataSource = tiposDeGastos.Select(r => (r.IdTipoGasto + "/" + r.Concepto)).ToList();
            //comboTipoGastos.SelectedIndex = 0;
        }
        private void cargarComboClientes()
        {
            IEnumerable<cliente> cliente = managerCliete.ObtenerTodos;
            if (cliente != null)
            {
                comboClientes.DataSource = cliente.Select(r => (r.IdCliente + "/" + r.RazonSocial)).ToList();
                comboClientes.Text = string.Empty;
            }
        }
        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                string[] splitRutas;
                splitRutas = comboRutas.Text.Split('/');
                int idRuta = int.Parse(splitRutas.First());

                string[] splitClientes;
                splitClientes = comboClientes.Text.Split('/');
                int idCliente = int.Parse(splitClientes.First());

                string[] splitStatus;
                splitStatus = comboStatus.Text.Split('/');
                int idStatus = int.Parse(splitStatus.First());
                if (splitStatus[1] == "Cerrado")
                {
                    if (textFechaFinal.Text == string.Empty)
                    {
                        MessageBox.Show("Para cerrar el viaje es necesario que se tenga una fecha de fin del viaje.", "Error al cerrar el Viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textFechaFinal.Focus();
                        return;
                    }
                }

                string[] splitUnidades;
                splitUnidades = comboUnidades.Text.Split('/');
                int numEconomico = int.Parse(splitUnidades.First());
                unidades Unidad = managerUnidades.BuscarPorNumEco(numEconomico);

                if (accion == "agregar")
                {
                    try
                    {
                        viaje viajeNuevo = CrearViaje(idStatus, idRuta, idCliente, Unidad.IdUnidad);
                        if (managerViajes.Insertar(viajeNuevo))
                        {
                            viaje lastViaje = managerViajes.BuscarUltimoIngresado();
                            log registro = new log
                            {
                                Accion = "agregar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "viaje-id:" + lastViaje.IdViajeSci
                            };
                            managerLog.Insertar(registro);
                            agregarOperaresAlViaje(lastViaje);
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
                            entidadAeditar.FechaInicio = DateTime.Parse(textFechaInicial.Text); //dateTimeInicioSci.Value;
                            entidadAeditar.FechaFin = fechaValida(textFechaFinal.Text); //dateTimeFinSci.Value;
                            entidadAeditar.IdRuta = idRuta;
                            entidadAeditar.IdStatus = idStatus;
                            entidadAeditar.IdUnidad = Unidad.IdUnidad;

                            if (managerViajes.Actualizar(entidadAeditar))
                            {
                                log registro = new log
                                {
                                    Accion = "editar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "viaje-id:" + entidadAeditar.IdViajeSci
                                };
                                managerLog.Insertar(registro);

                                resultado = "Se ha actualizado correctamente los datos del Viaje.";
                                MessageBox.Show("Se han actualizado correctamente los datos del viaje.", "Actualización de Viaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //this.Close();
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
                MessageBox.Show("Ha ocurrido un Error al intentar Guardar El viaje. " + ex.Message, "Error al ingresar el Viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void agregarOperaresAlViaje(viaje lastViaje)
        {
            if (listOperadoresAsignados.Items.Count > 0)
            {
                operador opSeleccionado;
                for (int i = 0; i < listOperadoresAsignados.Items.Count; i++)
                {
                    opSeleccionado = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[i].ToString());
                    if (opSeleccionado != null)
                    {
                        operadoresenviaje opEnViaje = new operadoresenviaje { IdOperador = opSeleccionado.IdOperador, IdViajeSci = lastViaje.IdViajeSci, SaldoActual = 0 };

                        //Validamos si ya esta el Operadore asgnado al viaje
                        operadoresenviaje opYaAgregado = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(lastViaje.IdViajeSci, opSeleccionado.IdOperador);
                        if (opYaAgregado == null)
                        {
                            if (managerOperadoresEnViaje.Insertar(opEnViaje))
                            {
                                operadoresenviaje lastOperadorEnViaje = managerOperadoresEnViaje.BuscarUltimoIngresado();
                                log registro = new log
                                {
                                    Accion = "agregar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "viaje-id:" + lastOperadorEnViaje.IdViajeSci + " -- operador-id:" + lastOperadorEnViaje.IdOperador
                                };
                                managerLog.Insertar(registro);
                                //listOperadoresAsignados.Items.Clear();
                                //cargarListaOperadoresAsignadosAlViaje();
                            }
                        }
                        else
                            MessageBox.Show("Lo sentimos el operador ya esta agregado.", "Agregar Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //Validamos si ya esta el Operadore asgnado al viaje
            }
        }
        private DateTime fechaValida(string fecha)
        {
            DateTime fechaFIn = new DateTime(DateTime.MinValue.Ticks);
            if (fecha != string.Empty)
            {
                fechaFIn = DateTime.Parse(fecha);
            }

            return fechaFIn;
        }
        private viaje CrearViaje(int idStatus, int idRuta, int idCliente, /*int idOperador,*/ int idUni)
        {
            return new viaje
            {
                IdViajeCliente = textClaveViajeCliente.Text,
                FechaInicio = DateTime.Parse(textFechaInicial.Text),
                FechaFin = fechaValida(textFechaFinal.Text),
                IdStatus = idStatus,
                IdRuta = idRuta,
                IdUnidad = idUni
            };
        }
        private void comboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
            if (comboStatus.Text.Contains("Iniciado"))
                habilitarComponentes(true);
            else
                habilitarComponentes(false);
                */
        }
        private void habilitarComponentes(bool habilitar)
        {
            calendarInicialSci.Enabled = habilitar;
            textFechaInicial.Enabled = habilitar;
            textFechaFinal.Enabled = habilitar;
            comboClientes.Enabled = habilitar;
            comboRutas.Enabled = habilitar;
            textClaveViajeCliente.Enabled = habilitar;
            comboUnidades.Enabled = habilitar;
        }
        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            if (editarGasto == false)
            {
                if (comboTipoGastos.Text != string.Empty)
                {
                    try
                    {
                        //if (validarFechaDelGasto() == false)
                        //{
                        // MessageBox.Show("La fecha del Gasto esta fuera del rango de las fechas del Viaje de Sci.", "Erro al ingresar el nuevo gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //  return;
                        //}

                        string[] cadena = comboTipoGastos.Text.Split('/');
                        int idTipoGasto = int.Parse(cadena.First());
                        gasto nuevoGasto = new gasto();
                        nuevoGasto.IdTipoGasto = idTipoGasto;

                        string[] cadenaOp = comboOperadoresGasto.Text.Split('/');
                        int idOpAGasto = int.Parse(cadenaOp.First());
                        nuevoGasto.IdOperador = idOpAGasto;

                        if (validarSaldoOperador(idOpAGasto) == false)
                        {
                            MessageBox.Show("El Saldo del Operador es insuficiente para registrar este gasto.", "Operador sin saldo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (tipoDeGasto == "Combustible")
                        {
                            nuevoGasto.Concepto = comboGasolinerias.Text;
                        }
                        else
                        {
                            if (tipoDeGasto == "Casetas")
                            {
                                nuevoGasto.Concepto = comboCasetas.Text;
                            }
                            else
                            {
                                nuevoGasto.Concepto = textConceptoGasto.Text;
                            }
                        }

                        nuevoGasto.Costo = double.Parse(textMontoGasto.Text);
                        subirFicherosPdfyXml();
                        nuevoGasto.RutaPdf = nombreArchivoNuevoPdf;
                        nuevoGasto.RutaXml = nombreArchivoNuevoXml;
                        nuevoGasto.Fecha = DateTime.Parse(textFechaDelGasto.Text);
                        nuevoGasto.IdViajeSci = entidadAeditar.IdViajeSci;
                        nuevoGasto.NumeroDePoliza = int.Parse(textPoliza.Text);
                        nuevoGasto.FolioFactura = textNumFactura.Text;
                        nuevoGasto.NumTicket = textTicket.Text;
                        nuevoGasto.FormaDePago = comboFormaPago.Text;

                        if (managerGastos.Insertar(nuevoGasto))
                        {
                            gasto lastGasto = managerGastos.BuscarUltimoIngresado();
                            log registro = new log
                            {
                                Accion = "agregar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "viaje-id:" + lastGasto.IdViajeSci + " -- gasto-id:" + lastGasto.IdGasto
                            };
                            managerLog.Insertar(registro);

                            operadoresenviaje opEnViaje = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, idOpAGasto);
                            if (opEnViaje != null)
                            {
                                opEnViaje.SaldoActual = opEnViaje.SaldoActual - nuevoGasto.Costo;
                                if (managerOperadoresEnViaje.Actualizar(opEnViaje)==false)
                                {
                                    MessageBox.Show("Ha ocurrido un error al intentar guardar nuevo saldo del operador, el gasto no pudo registrarse.", "Error al actualizar el saldo del Operador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    managerGastos.Eliminar(lastGasto.IdGasto.ToString());
                                }
                            }
                            cargarTodosLosGastosDelViaje();
                            limpiarFormularioRegistroDeGastos();
                        }
                        else
                            MessageBox.Show("No Se ha podido ingresar el nuevo Gasto. " + managerGastos.Error, "Error al regitrar el nuevo Gasto.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Se ha podido ingresar el nuevo Gasto. " + ex.Message, "Error al regitrar el nuevo Gasto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (comboTipoGastos.Text != string.Empty)
                {
                    try
                    {
                        //if (validarFechaDelGasto() == false)
                        //{
                          //  MessageBox.Show("La fecha del Gasto esta fuera del rango de las fechas del Viaje de Sci.", "Erro al ingresar el nuevo gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //return;
                        //}
                        string[] cadena = comboTipoGastos.Text.Split('/');
                        int idTipoGasto = int.Parse(cadena.First());
                        gasto gastoAEditar = managerGastos.BuscarPorId(idGastoAeditar.ToString());
                        gastoAEditar.IdTipoGasto = idTipoGasto;

                        string[] cadenaOp = comboOperadoresGasto.Text.Split('/');
                        int idOpAGasto = int.Parse(cadenaOp.First());
                        gastoAEditar.IdOperador = idOpAGasto;

                        if (tipoDeGasto == "Combustible")
                        {
                            gastoAEditar.Concepto = comboGasolinerias.Text;
                        }
                        else
                        {
                            if (tipoDeGasto == "Casetas")
                            {
                                gastoAEditar.Concepto = comboCasetas.Text;
                            }
                            else
                            {
                                gastoAEditar.Concepto = textConceptoGasto.Text;
                            }
                        }

                        gastoAEditar.Costo = double.Parse(textMontoGasto.Text);
                        subirFicherosPdfyXml();
                        gastoAEditar.RutaPdf = nombreArchivoNuevoPdf;
                        gastoAEditar.RutaXml = nombreArchivoNuevoXml;
                        gastoAEditar.Fecha = DateTime.Parse(textFechaDelGasto.Text);
                        gastoAEditar.IdViajeSci = entidadAeditar.IdViajeSci;
                        gastoAEditar.NumeroDePoliza = int.Parse(textPoliza.Text);
                        gastoAEditar.FolioFactura = textNumFactura.Text;
                        gastoAEditar.NumTicket = textTicket.Text;
                        gastoAEditar.FormaDePago = comboFormaPago.Text;

                        if (managerGastos.Actualizar(gastoAEditar))
                        {
                            log registro = new log
                            {
                                Accion = "editar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "viaje-id:" + gastoAEditar.IdViajeSci + " -- gasto-id:" + gastoAEditar.IdGasto
                            };
                            managerLog.Insertar(registro);

                            cargarTodosLosGastosDelViaje();
                            limpiarFormularioRegistroDeGastos();
                        }
                        else
                            MessageBox.Show("No Se ha podido ingresar el nuevo Gasto. " + managerGastos.Error, "Error al regitrar el nuevo Gasto.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        editarGasto = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Se ha podido ingresar el nuevo Gasto. " + ex.Message, "Error al regitrar el nuevo Gasto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            nombreArchivoNuevoPdf = string.Empty;
            nombreArchivoNuevoXml = string.Empty;
        }
        private bool validarSaldoOperador(int idOpAGasto)
        {
            operadoresenviaje opSeleccionado = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, idOpAGasto);
            if (opSeleccionado != null)
            {
                try
                {
                    double montoDelGasto = double.Parse(textMontoGasto.Text);
                    if (opSeleccionado.SaldoActual < montoDelGasto)
                        return false;
                }
                catch {
                    return false;
                }
                return true;
            }

            return false;
        }
        private bool validarFechaDelGasto()
        {
            DateTime fechayHora = DateTime.Parse(textFechaDelGasto.Text);
            if (fechayHora < entidadAeditar.FechaFin && fechayHora >= entidadAeditar.FechaInicio)
                return true;
            else return false;
        }
        private void limpiarFormularioRegistroDeGastos()
        {
            comboOperadoresGasto.Text = string.Empty;
            comboTipoGastos.Text = string.Empty;
            textConceptoGasto.Clear();
            comboCasetas.Visible = false;
            comboGasolinerias.Visible = true;
            textConceptoGasto.Visible = false;
            

            textMontoGasto.Clear();
            textRutaPdf.Clear();
            textRutaXml.Clear();

            textPoliza.Text = "0";
            textTicket.Text = string.Empty;
            textNumFactura.Text = string.Empty;
            comboFormaPago.Text = string.Empty;

            calendarGastos.SelectionStart = DateTime.Now;
            calendarGastos.SelectionEnd = DateTime.Now;

            textFechaDelGasto.Text = string.Empty;
        }
        private void subirFicherosPdfyXml()
        {
            string directoryPath = Path.GetDirectoryName(@"\\Srvopssci\ops_sci\SCI\SISTEMA_SCI\COMPROBANTES\VALIDACION");

            //Si el gasto es un gasto nuevo
            if (editarGasto == false)
            {
                if (Directory.Exists(directoryPath)) //revisamos si existe y podemos acceder al folder.
                {
                    if (nombreArchivoPdf != string.Empty && textRutaPdf.Text != string.Empty) //En caso de que haya algo en el text de la Ruta del PDF
                    {
                        try
                        {
                            nombreArchivoNuevoPdf = getNuevoNombreDelGasto(nombreArchivoPdf);
                            File.Copy(textRutaPdf.Text, directoryPath + @"\" + nombreArchivoNuevoPdf); //intenta subir el archivo al servidor
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("PDF Ha ocurrido un problema al intentar guardar el archivo. " + ex.Message, "Erro al subir el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (nombreArchivoXml != string.Empty && textRutaXml.Text != string.Empty) //En caso de que haya algo en el text de la Ruta del Xml
                    {
                        try
                        {
                            nombreArchivoNuevoXml = getNuevoNombreDelGasto(nombreArchivoXml);
                            File.Copy(textRutaXml.Text, directoryPath + @"\" + nombreArchivoNuevoXml);//intenta subir el archivo al servidor
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("XML Ha ocurrido un problema al intentar guardar el archivo. " + ex.Message, "Erro al subir el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: El directorio no existe.");
                }
            }
            //hacemos todo esto para cuando hay q editar el gasto
            else
            {
                if (Directory.Exists(directoryPath)) //revisamos si existe y podemos acceder al folder.
                {
                    if (nombreArchivoPdf != string.Empty && textRutaPdf.Text != string.Empty) //En caso de que haya algo en el text de la Ruta del PDF
                    {
                        try
                        {
                            nombreArchivoNuevoPdf = getNuevoNombreDelGasto(nombreArchivoPdf);
                            if (textRutaPdf.Text.Contains("C:"))
                                File.Copy(textRutaPdf.Text, directoryPath + @"\" + nombreArchivoNuevoPdf); //intenta subir el archivo al servidor
                            else
                            {
                                nombreArchivoNuevoPdf = textRutaPdf.Text;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("PDF Ha ocurrido un problema al intentar guardar el archivo. " + ex.Message, "Erro al subir el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (nombreArchivoXml != string.Empty && textRutaXml.Text != string.Empty) //En caso de que haya algo en el text de la Ruta del Xml
                    {
                        try
                        {
                            nombreArchivoNuevoXml = getNuevoNombreDelGasto(nombreArchivoXml);
                            if (textRutaXml.Text.Contains("C:"))
                                File.Copy(textRutaXml.Text, directoryPath + @"\" + nombreArchivoNuevoXml);//intenta subir el archivo al servidor
                            else
                            {
                                nombreArchivoNuevoXml = textRutaXml.Text;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("XML Ha ocurrido un problema al intentar guardar el archivo. " + ex.Message, "Erro al subir el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: El directorio no existe.");
                }
            }
        }
        private string getNuevoNombreDelGasto(string nombreArchivo)
        {
            string[] cadenas;
            DateTime fechaHora = DateTime.Now;
            Random r = new Random();
            string nombre = "V" + entidadAeditar.IdViajeSci.ToString() + "-" + fechaHora.Year.ToString() + fechaHora.Month.ToString() + fechaHora.Day.ToString();
            nombre += "-" + fechaHora.Hour.ToString() + fechaHora.Minute.ToString() + fechaHora.Second.ToString() + fechaHora.Millisecond.ToString() + "-" + r.Next(100, 1000).ToString();

            cadenas = nombreArchivo.Split('.');
            nombre += "." + cadenas.Last();
            return nombre;
        }
        private void btnExaminarPdf_Click(object sender, EventArgs e)
        {
            nombreArchivoPdf = string.Empty;

            textRutaPdf.Clear();
            nombreArchivoPdf = string.Empty;
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado != DialogResult.Cancel)
            {
                textRutaPdf.Text = openFileDialog1.FileName;
                nombreArchivoPdf = openFileDialog1.SafeFileName;
            }

        }
        private void btnExaminarXml_Click(object sender, EventArgs e)
        {
            nombreArchivoXml = string.Empty;
            textRutaXml.Clear();
            nombreArchivoXml = string.Empty;
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado != DialogResult.Cancel)
            {
                textRutaXml.Text = openFileDialog1.FileName;
                nombreArchivoXml = openFileDialog1.SafeFileName;
            }
        }
        private void calendarCortesOperador_DateChanged(object sender, DateRangeEventArgs e)
        {
            textFechaHoraInicialCorte.Text = e.Start.ToString();
            textFechaHoraFinalCorte.Text = e.End.ToString();
            calcularMontoPorHorasOperador();
        }
        private void calcularMontoPorHorasOperador()
        {
            if (textFechaHoraInicialCorte.Text != string.Empty && textFechaHoraFinalCorte.Text != string.Empty && textFechaHoraFinalCorte.Text != "01/01/0001 12:00:00 a. m.")
            {
                try
                {
                    DateTime fechaInicio = DateTime.Parse(textFechaHoraInicialCorte.Text);
                    DateTime fechaFinal = fechaValida(textFechaHoraFinalCorte.Text);
                    double resultado = (fechaFinal - fechaInicio).TotalHours;
                    textTotalHoras.Text = resultado.ToString("N2");
                    textCostoTotal.Text = (resultado * double.Parse(textCostoHoraOperador.Text)).ToString("N2");
                }
                catch
                {
                    textTotalHoras.Text = "0";
                    textCostoTotal.Text = "0";
                    //MessageBox.Show("No se ha podido calcular el costo por horas Laboradas. Es necesario que selecciones un Operador." + ex.Message, "No se pudo calcular el sueldo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    comboOperadoresCortes.Focus();
                }
            }
        }
        private void textTotalHoras_Click(object sender, EventArgs e)
        {
            calcularMontoPorHorasOperador();
        }
        private void btnRedondear_Click(object sender, EventArgs e)
        {
            try { textCostoTotal.Text = Math.Round(double.Parse(textCostoTotal.Text)).ToString(); }
            catch { textCostoTotal.Text = "0"; }
        }
        private void btnAgregarCorteOperador_Click(object sender, EventArgs e)
        {
            if (editarCorte == false)
            {
                if (validarCortesCerrados() == false)
                {
                    MessageBox.Show("No se puede agregar un nuevo corte porque se tiene uno abierto.", "No se pudo guardar el corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cortesoperador nuevoCorte = new cortesoperador();
                try
                {
                    nuevoCorte.FechaInicio = DateTime.Parse(textFechaHoraInicialCorte.Text);
                    nuevoCorte.FechaFin = fechaValida(textFechaHoraFinalCorte.Text);
                    if (textCostoTotal.Text == string.Empty) textCostoTotal.Text = "0";
                    nuevoCorte.Costo = double.Parse(textCostoTotal.Text);
                    nuevoCorte.IdViajeSci = entidadAeditar.IdViajeSci;
                    nuevoCorte.IdStatus = entidadAeditar.IdStatus;
                    if (textTotalHoras.Text == string.Empty)
                        textTotalHoras.Text = "0";
                    nuevoCorte.Horas = double.Parse(textTotalHoras.Text);

                    string[] cadenaOp = comboOperadoresCortes.Text.Split('/');
                    nuevoCorte.IdOperador = int.Parse(cadenaOp.First());

                    if (managerCortes.Insertar(nuevoCorte))
                    {
                        cortesoperador lastCorte = managerCortes.BuscarUltimoIngresado();
                        log registro = new log
                        {
                            Accion = "agregar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "viaje-id:" + lastCorte.IdViajeSci + " -- cortesoperador-id:" + lastCorte.IdCorte
                        };
                        managerLog.Insertar(registro);

                        cargarTodosLosCortesDelViaje();
                        limpiarFormularioCortes();

                    }
                    else
                        MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo corte. " + managerCortes.Error, "No se pudo guardar el corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo corte. " + ex.Message, "No se pudo guardar el corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cortesoperador corteAEditar = managerCortes.BuscarPorId(idCorteAeditar.ToString());
                try
                {
                    corteAEditar.FechaInicio = DateTime.Parse(textFechaHoraInicialCorte.Text);
                    corteAEditar.FechaFin = fechaValida(textFechaHoraFinalCorte.Text);
                    corteAEditar.Costo = double.Parse(textCostoTotal.Text);
                    corteAEditar.IdStatus = entidadAeditar.IdStatus;
                    corteAEditar.Horas = double.Parse(textTotalHoras.Text);

                    string[] cadenaOp = comboOperadoresCortes.Text.Split('/');
                    corteAEditar.IdOperador = int.Parse(cadenaOp.First());

                    if (managerCortes.Actualizar(corteAEditar))
                    {
                        log registro = new log
                        {
                            Accion = "editar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "viaje-id:" + corteAEditar.IdViajeSci + " -- cortesoperador-id:" + corteAEditar.IdCorte
                        };
                        managerLog.Insertar(registro);

                        cargarTodosLosCortesDelViaje();
                        limpiarFormularioCortes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo corte. " + managerCortes.Error, "No se pudo guardar el corte", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    editarCorte = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo corte. " + ex.Message, "No se pudo guardar el corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool validarCortesCerrados()
        {
            IEnumerable<cortesoperador> cortes = managerCortes.BuscarCortesPorIdViaje(entidadAeditar.IdViajeSci);
            foreach (var item in cortes)
            {
                if (item.FechaFin.ToString() == "01/01/0001 12:00:00 a. m.")
                    return false;
            }

            return true;
        }
        private void limpiarFormularioCortes()
        {
            comboOperadoresCortes.Text = string.Empty;
            textFechaHoraInicialCorte.Clear();
            textFechaHoraFinalCorte.Clear();
            textTotalHoras.Clear();
            textCostoTotal.Clear();
            textCostoHoraOperador.Clear();
            calendarInicioCortes.SelectionStart = DateTime.Now;
            calendarInicioCortes.SelectionEnd = DateTime.Now;
            calendarFinCorte.SelectionStart = DateTime.Now;
            calendarFinCorte.SelectionEnd = DateTime.Now;
        }
        private void textFechaHoraFinalOperador_Leave(object sender, EventArgs e)
        {
            calcularMontoPorHorasOperador();
        }
        private void cargarTodasLasUnidades()
        {
            IEnumerable<unidades> TodasLasUnidades = managerUnidades.ObtenerTodos;
            if(TodasLasUnidades != null)
                comboUnidades.DataSource = TodasLasUnidades.Select(r => (r.NumeroEconomico + "/" + r.Nombre)).ToList();
        }
        private void cargarComboRutas(int idCliente)
        {
            IEnumerable<ruta> rutas = managerRuta.BuscarPorIdCliente(idCliente);
            comboRutas.DataSource = rutas.Select(r => (r.IdRuta + "/" + r.Nombre)).ToList();
            /*if (comboClientes.Text == string.Empty)
            {
                comboRutas.Items.Clear();
                
            }*/
            comboRutas.Text = string.Empty;
        }
        private void comboRutas_TextChanged(object sender, EventArgs e)
        {
            if (comboRutas.Text != string.Empty)
            {
                string[] cadenaRutaSeleccionada = comboRutas.Text.Split('/');
                ruta rutaSeleccionada = managerRuta.BuscarPorId(cadenaRutaSeleccionada.First());
                labelNombreRuta.Text = rutaSeleccionada.Nombre;
                labelCostoRuta.Text = "$" + rutaSeleccionada.Costo.ToString();
                //tipounidad tUnidad = managerTipoDeUnidad.BuscarPorId(rutaSeleccionada.IdTipoDeUnidad.ToString());
                // labelTipoUnidad.Text = tUnidad.Descripcion;
                //cargarTodasLasUnidades(tUnidad.IdTipoDeUnidad);
                //
                //comboUnidades.Text = string.Empty;
            }
            else
            {
                labelNombreRuta.Text = "--";
                labelCostoRuta.Text = "--";
                //labelTipoUnidad.Text = "--";
            }
        }
        private void comboUnidades_TextChanged(object sender, EventArgs e)
        {
            if (comboUnidades.Text != string.Empty)
            {
                string[] cadenaUnidades = comboUnidades.Text.Split('/');
                unidades unidadSeleccionada = managerUnidades.BuscarPorNumEco(int.Parse(cadenaUnidades.First()));
                tipounidad tipoU = managerTipoDeUnidad.BuscarPorId(unidadSeleccionada.IdTipoDeUnidad.ToString());

                labelNombreUnidad.Text = unidadSeleccionada.Nombre;
                labelNumEco.Text = unidadSeleccionada.NumeroEconomico.ToString();
                labelPlacas.Text = unidadSeleccionada.Placas;
                labelCombustible.Text = unidadSeleccionada.TipoCombustible;
                labelTipoUnidad.Text = tipoU.Descripcion;
            }
            else
            {
                labelNombreUnidad.Text = "--";
                labelNumEco.Text = "--";
                labelPlacas.Text = "--";
                labelCombustible.Text = "--";
                labelTipoUnidad.Text = "--";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboClientes_TextChanged(object sender, EventArgs e)
        {
            if (comboClientes.Text != string.Empty)
            {
                string[] cadenaCliente = comboClientes.Text.Split('/');
                cargarComboRutas(int.Parse(cadenaCliente.First()));
                cliente clienteSeleccionado = managerCliete.BuscarPorId(cadenaCliente.First());
                labelNombreCliente.Text = clienteSeleccionado.RazonSocial;
                labelTelCliente.Text = clienteSeleccionado.Telefono;
                labelRfcCliente.Text = clienteSeleccionado.Rfc;

            }
            else
            {
                comboRutas.DataSource = null;
                comboRutas.Text = string.Empty;
                labelNombreCliente.Text = "--";
                labelTelCliente.Text = "--";
                labelRfcCliente.Text = "--";
            }

        }
        private void comboTipoGastos2_TextChanged(object sender, EventArgs e)
        {
            if (comboTipoGastos.SelectedIndex == 0)
            {
                comboGasolinerias.Visible = true;
                comboCasetas.Visible = false;
                textConceptoGasto.Visible = false;

                comboCasetas.Text = string.Empty;
                textConceptoGasto.Text = string.Empty;
                tipoDeGasto = "Combustible";
                cargarTodasLasGasolinerias();
                
                return;
            }
            if (comboTipoGastos.SelectedIndex == 1)
            {
                comboCasetas.Visible = true;
                comboGasolinerias.Visible = false;
                textConceptoGasto.Visible = false;

                comboGasolinerias.Text = string.Empty;
                textConceptoGasto.Text = string.Empty;
                tipoDeGasto = "Casetas";
                cargarTodasLasCasetas();
                return;
            }

            tipoDeGasto = "Otros";
            textConceptoGasto.Visible = true;
            comboCasetas.Visible = false;
            comboGasolinerias.Visible = false;
            comboTipoGastos.Text = string.Empty;
            comboCasetas.Text = string.Empty;
            comboGasolinerias.Text = string.Empty;


            /*
            if (comboTipoGastos.Text != string.Empty)
            {
                if (comboTipoGastos.Text.Contains("Combustible"))
                {
                    comboGasolinerias.Visible = true;
                    comboCasetas.Visible = false;
                    textConceptoGasto.Visible = false;

                    comboCasetas.Text = string.Empty;
                    textConceptoGasto.Text = string.Empty;
                    tipoDeGasto = "Combustible";
                    cargarTodasLasGasolinerias();
                    return;
                }
                if (comboTipoGastos.Text.Contains("Casetas"))
                {
                    comboCasetas.Visible = true;
                    comboGasolinerias.Visible = false;
                    textConceptoGasto.Visible = false;

                    comboGasolinerias.Text = string.Empty;
                    textConceptoGasto.Text = string.Empty;
                    tipoDeGasto = "Casetas";
                    cargarTodasLasCasetas();
                    return;
                }
            }

            tipoDeGasto = "Otros";
            textConceptoGasto.Visible = true;
            comboCasetas.Visible = false;
            comboGasolinerias.Visible = false;
            comboTipoGastos.Text = string.Empty;
            comboCasetas.Text = string.Empty;
            comboGasolinerias.Text = string.Empty;
            */
        }
        private void cargarTodasLasGasolinerias()
        {
            IEnumerable<gasolineria> todasGasolinerias = managerGasolinerias.ObtenerTodos;
            comboGasolinerias.DataSource = todasGasolinerias.Select(r => (r.Nombre)).ToList();
            comboGasolinerias.Text = string.Empty;
        }
        private void cargarTodasLasCasetas()
        {
            unidades UnidadEnViaje = managerUnidades.BuscarPorId(entidadAeditar.IdUnidad.ToString());
            //IEnumerable<caseta> todasCasetas = managerCasetas.ObtenerTodos;
            IEnumerable<caseta> todasCasetas = managerCasetas.BuscarCasetaPorTipoDeUnidad(UnidadEnViaje.IdTipoDeUnidad);
            comboCasetas.DataSource = todasCasetas.Select(r => (r.Nombre)).ToList();
            comboCasetas.Text = string.Empty;
        }
        private void comboCasetas_TextChanged(object sender, EventArgs e)
        {
            textMontoGasto.Text = string.Empty;
            try
            {
                if (comboCasetas.Text != string.Empty)
                {
                    unidades unidadSeleccionada = managerUnidades.BuscarPorId(entidadAeditar.IdUnidad.ToString());
                    caseta casetaN = managerCasetas.BuscarCasetaPorNombre(comboCasetas.Text, unidadSeleccionada.IdTipoDeUnidad);
                    if (casetaN != null)
                    {
                        textMontoGasto.Text = casetaN.Costo.ToString();
                        textMontoGasto.Enabled = false;
                    }
                    textMontoGasto.Enabled = false;
                }
                else
                {
                    textMontoGasto.Enabled = true;
                }
            }
            catch { }
        }
        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaGastoSeleccionado = e.RowIndex;
        }
        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (filaGastoSeleccionado >= 0)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el gasto?", "Eliminar Gasto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string idGastoSeleccionado = dgvGastos["idGasto", filaGastoSeleccionado].Value.ToString();
                    gasto gastoSeleccionado = managerGastos.BuscarPorId(idGastoSeleccionado);
                    operadoresenviaje opEnViaje = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, gastoSeleccionado.IdOperador);

                    opEnViaje.SaldoActual = opEnViaje.SaldoActual + gastoSeleccionado.Costo;
                    if (managerOperadoresEnViaje.Actualizar(opEnViaje))
                    {
                        if (managerGastos.Eliminar(idGastoSeleccionado))
                        {
                            log registro = new log
                            {
                                Accion = "eliminar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "viaje-id:" + gastoSeleccionado.IdViajeSci.ToString() + " -- gasto-id:" + gastoSeleccionado.IdGasto.ToString()
                            };
                            managerLog.Insertar(registro);
                            limpiarFormularioRegistroDeGastos();
                            cargarTodosLosGastosDelViaje();
                        }
                        else
                            MessageBox.Show("El gasto no se ha podido eliminar.", "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void dgvGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        if (dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString() != string.Empty)
                        {
                            try { System.Diagnostics.Process.Start(@"\\Srvopssci\ops_sci\SCI\SISTEMA_SCI\COMPROBANTES\" + dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString()); }
                            catch { }
                        }
                        break;
                    case 4:
                        if (dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString() != string.Empty)
                        {
                            try { System.Diagnostics.Process.Start(@"\\Srvopssci\ops_sci\SCI\SISTEMA_SCI\COMPROBANTES\" + dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString()); }
                            catch { }
                        }
                        break;
                    default:
                        filaGastoSeleccionado = e.RowIndex;
                        idGastoAeditar = int.Parse(dgvGastos["idGasto", filaGastoSeleccionado].Value.ToString());
                        cargarDatosGastoAeditar();
                        editarGasto = true;
                        break;
                }
            }

        }
        private void cargarDatosGastoAeditar()
        {
            string idGasto = dgvGastos["idGasto", filaGastoSeleccionado].Value.ToString();
            gasto gastoSeleccionado = managerGastos.BuscarPorId(idGasto);
            tipogasto tipoGastoSeleccionado = managerTiposDeGastos.BuscarPorId(gastoSeleccionado.IdTipoGasto.ToString());
            comboTipoGastos.Text = tipoGastoSeleccionado.IdTipoGasto.ToString() + "/" + tipoGastoSeleccionado.Concepto;

            operador opSeleccionado = managerOperador.BuscarPorId(gastoSeleccionado.IdOperador.ToString());
            comboOperadoresGasto.Text = opSeleccionado.IdOperador.ToString() + "/" + opSeleccionado.Nombre + " " + opSeleccionado.Apellidos;

            if (textConceptoGasto.Visible == true)
            {
                textConceptoGasto.Text = gastoSeleccionado.Concepto;
            }
            else
            {
                if (comboCasetas.Visible == true)
                {
                    comboCasetas.Text = gastoSeleccionado.Concepto;
                }
                else
                {
                    comboGasolinerias.Text = gastoSeleccionado.Concepto;
                }
            }

            textFechaDelGasto.Text = formatoFecha(gastoSeleccionado.Fecha);
            calendarGastos.SelectionRange.Start = gastoSeleccionado.Fecha;
            string[] cadenaFecha = textFechaDelGasto.Text.Split(' ');
            fechaDelGasto = cadenaFecha.First();
            horaDelGasto = gastoSeleccionado.Fecha.Hour;
            minutosDelGasto = gastoSeleccionado.Fecha.Minute;
            trackHoraGastos.Value = horaDelGasto;
            trackMinutosGastos.Value = minutosDelGasto;

            textRutaPdf.Text = gastoSeleccionado.RutaPdf;
            textRutaXml.Text = gastoSeleccionado.RutaXml;
            textMontoGasto.Text = gastoSeleccionado.Costo.ToString();
            textPoliza.Text = gastoSeleccionado.NumeroDePoliza.ToString();
            textNumFactura.Text = gastoSeleccionado.FolioFactura;
            textTicket.Text = gastoSeleccionado.NumTicket;
            comboFormaPago.Text = gastoSeleccionado.FormaDePago;
        }
        private void listOperadoresAsignados_DoubleClick(object sender, EventArgs e)
        {
            if (listOperadoresAsignados.Items.Count > 0 && listOperadoresAsignados.SelectedIndex >= 0)
            {
                if (accion == "editar")
                {
                    DialogResult result = MessageBox.Show("¿Esta Seguro que de sea eliminar este operador de forma permanente del Viaje?", "Eliminar Operador", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        operador opSeleccionado = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[listOperadoresAsignados.SelectedIndex].ToString());
                        
                        //Validamos si ya esta el Operadore asgnado al viaje
                        operadoresenviaje opYaAgregado = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);
                        IEnumerable<cortesoperador> corteAgregado = managerCortes.BuscarCortesPorOperadorEnViaje(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);
                        IEnumerable<gasto> gastosAgregados = managerGastos.BuscarPorIdViajeyOperador(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);
                        IEnumerable<deposito> depositosAgregados = managerDeposito.BuscarPorIdViajeyOperador(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);

                        int contaCortes = corteAgregado.ToArray().Count();
                        int contaGastos = gastosAgregados.ToArray().Count();
                        int contaDepositos = depositosAgregados.ToArray().Count();

                        if (opYaAgregado != null && contaCortes == 0 && contaGastos == 0 && contaDepositos == 0) // && gastosAgregados == null) //El operador no puede eliminarse si tiene cortes o gastos asociados.
                        {
                            if (managerOperadoresEnViaje.Eliminar(opYaAgregado.IdRegistro.ToString()))
                            {
                                log registro = new log
                                {
                                    Accion = "eliminar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "viaje-id:" + opYaAgregado.IdViajeSci + " -- operador-id:" + opYaAgregado.IdOperador
                                };
                                managerLog.Insertar(registro);

                                listOperadoresAsignados.Items.Clear();
                                cargarListaOperadoresAsignadosAlViaje();
                            }
                        }
                        else
                            MessageBox.Show("Lo sentimos el operador no se ha podido eliminar del viaje. Revisa que no tenga Cortes, Gastos o Depósitos ya registrados.", "Eliminar Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    listOperadoresAsignados.Items.RemoveAt(listOperadoresAsignados.SelectedIndex);
                }
            }
        }
        private void comboOperadoresCortes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboOperadoresCortes.Text != string.Empty)
            {
                string[] cadena = comboOperadoresCortes.Text.Split('/');
                operador op = managerOperador.BuscarPorId(cadena.First());
                textCostoHoraOperador.Text = op.Salarioporhora.ToString();
            }

        }
        private void textCostoHoraOperador_TextChanged(object sender, EventArgs e)
        {
            calcularMontoPorHorasOperador();
        }
        private void btnEliminarCorte_Click(object sender, EventArgs e)
        {
            if (filaCorteSeleccionado >= 0)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el corte seleccionado?", "Eliminar Corte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string idCorteSeleccionado = dgvCortesOperador["idCorte", filaCorteSeleccionado].Value.ToString();
                    cortesoperador corteSeleccionado = managerCortes.BuscarPorId(idCorteSeleccionado);
                    if (managerCortes.Eliminar(idCorteSeleccionado))
                    {
                        log registro = new log
                        {
                            Accion = "eliminar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "viaje-id:" + corteSeleccionado.IdViajeSci + " -- cortesoperador-id:" + corteSeleccionado.IdCorte
                        };
                        managerLog.Insertar(registro);

                        cargarTodosLosCortesDelViaje();
                    }
                    else
                        MessageBox.Show("El gasto no se ha podido eliminar.", "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void dgvCortesOperador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaCorteSeleccionado = e.RowIndex;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                cargarTodosLosGastosDelViaje();
                cargarTodosLosCortesDelViaje();
            }
            catch { }
        }
        private void dgvCortesOperador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaCorteSeleccionado = e.RowIndex;
                idCorteAeditar = int.Parse(dgvCortesOperador["idCorte", filaCorteSeleccionado].Value.ToString());
                cargarDatosCorteAeditar();
                editarCorte = true;
            }
        }
        private void cargarDatosCorteAeditar()
        {
            cortesoperador corteSeleccionado = managerCortes.BuscarPorId(idCorteAeditar.ToString());
            operador opSeleccionado = managerOperador.BuscarPorId(corteSeleccionado.IdOperador.ToString());
            comboOperadoresCortes.Text = opSeleccionado.IdOperador.ToString() + "/" + opSeleccionado.Nombre + " " + opSeleccionado.Apellidos;
            textFechaHoraInicialCorte.Text = formatoFecha(corteSeleccionado.FechaInicio);


            //Validación de la fechaInicial del Corte junto con sus elementos del Panel de fechas
            textFechaHoraFinalCorte.Text = formatoFecha(corteSeleccionado.FechaFin);
            if (textFechaHoraFinalCorte.Text != "01/01/1 00:00:00")
            {
                calendarFinCorte.SelectionRange.Start = corteSeleccionado.FechaFin;
                string[] cadenaFecha2 = textFechaHoraFinalCorte.Text.Split(' ');
                fechaFinalCorte = cadenaFecha2.First();
                horaFinalCorte = corteSeleccionado.FechaFin.Hour;
                minutoFinalCorte = corteSeleccionado.FechaFin.Minute;
                trackHoraFinCorte.Value = horaFinalCorte;
                trackMinutoFinCorte.Value = minutoFinalCorte;
            }
            else
                textFechaHoraFinalCorte.Text = string.Empty;

            textTotalHoras.Text = corteSeleccionado.Horas.ToString();
            textCostoHoraOperador.Text = opSeleccionado.Salarioporhora.ToString();
            textCostoTotal.Text = corteSeleccionado.Costo.ToString();

        }
        private void btnAgregarOperador_Click(object sender, EventArgs e)
        {
            if (comboOperadores.Text != string.Empty)
            {
                for (int i = 0; i < listOperadoresAsignados.Items.Count; i++)
                {
                    if (listOperadoresAsignados.Items[i].ToString() == comboOperadores.Text)
                    {
                        MessageBox.Show("Este operador ya esta asignado al viaje.", "Operador en el viaje.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (accion == "editar")
                {
                    operador opSeleccionado = managerOperador.BuscarPorNombreExacto(comboOperadores.Text);
                    if (opSeleccionado != null)
                    {
                        int PosicionSiguiente = obtenerPosicionSiguienteOpEnViaje(entidadAeditar.IdViajeSci);
                        operadoresenviaje opEnViaje = new operadoresenviaje { IdOperador = opSeleccionado.IdOperador, IdViajeSci = entidadAeditar.IdViajeSci, SaldoActual = 0,Posicion = PosicionSiguiente};
                        
                        //Validamos si ya esta el Operadore asgnado al viaje
                        operadoresenviaje opYaAgregado = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);
                        if (opYaAgregado == null)
                        {
                            if (managerOperadoresEnViaje.Insertar(opEnViaje))
                            {
                                operadoresenviaje lastOperadorEnViaje = managerOperadoresEnViaje.BuscarUltimoIngresado();
                                log registro = new log
                                {
                                    Accion = "agregar",
                                    NombreUsuario = user.NombreUsuario,
                                    Fecha = DateTime.Now,
                                    ModuloAfectado = "viaje-id:" + lastOperadorEnViaje.IdViajeSci + " -- operador-id:" + lastOperadorEnViaje.IdOperador
                                };
                                managerLog.Insertar(registro);
                                listOperadoresAsignados.Items.Clear();
                                cargarListaOperadoresAsignadosAlViaje();
                            }
                        }
                        else
                            MessageBox.Show("Lo sentimos el operador ya esta agregado.", "Agregar Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                    listOperadoresAsignados.Items.Add(comboOperadores.Text);

            }
        }
        private int obtenerPosicionSiguienteOpEnViaje(int idViajeSci)
        {
            IEnumerable<operadoresenviaje> oprsEnViaje = managerOperadoresEnViaje.BuscarPorIdViajeOps(idViajeSci);
            try
            {
                if (oprsEnViaje == null) return 0; //significa que no hay operadore asignados al viaje, la primera posición es cero.
                else
                    return oprsEnViaje.Max(o => o.Posicion) + 1;
            }
            catch { return 0; };
        }
        private void comboOperadores_Click(object sender, EventArgs e)
        {
            comboOperadores.DroppedDown = true;
        }
        private void listOperadoresAsignados_Click(object sender, EventArgs e)
        {

            if (listOperadoresAsignados.Items.Count > 0 && listOperadoresAsignados.SelectedIndex >= 0)
            {
                //string[] cadena = listOperadoresAsignados.SelectedItem.ToString().Split('/');
                operador opSeleccionado = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[listOperadoresAsignados.SelectedIndex].ToString());
                labelNombreOperador.Text = opSeleccionado.Nombre + " " + opSeleccionado.Apellidos;
                labelTelOperador.Text = opSeleccionado.Celular;
                labelSalarioPorHora.Text = "$" + opSeleccionado.Salarioporhora.ToString();
                labelCorreoOperador.Text = opSeleccionado.Correo;

                if (accion == "agregar")
                {
                    labelSaldoOperador.Text = "0";
                }
                else
                {
                    operadoresenviaje opEnViaje = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);
                    if (opEnViaje != null)
                        labelSaldoOperador.Text = opEnViaje.SaldoActual.ToString();
                    else
                        labelSaldoOperador.Text = "0";
                }
            }
            /*
            if (listOperadoresAsignados.Items.Count > 0 && listOperadoresAsignados.SelectedIndex>=0)
            {
                string[] cadena = listOperadoresAsignados.SelectedItem.ToString().Split('/');
                operador opSeleccionado = managerOperador.BuscarPorId(cadena.First());
                labelNombreOperador.Text = opSeleccionado.Nombre + " " + opSeleccionado.Apellidos;
                labelTelOperador.Text = opSeleccionado.Celular;
                labelSalarioPorHora.Text = "$" + opSeleccionado.Salarioporhora.ToString();
                labelCorreoOperador.Text = opSeleccionado.Correo;

                operadoresenviaje opEnViaje = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opSeleccionado.IdOperador);
                labelSaldoOperador.Text = opEnViaje.SaldoActual.ToString();
            }
            */
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string formatoFecha(DateTime f)
        {
            string fechaCorrecta = string.Empty;
            if (f.Day < 10)
                fechaCorrecta = "0" + f.Day+"/";
            else
                fechaCorrecta = f.Day + "/";
            if(f.Month<10)
                fechaCorrecta += "0" + f.Month + "/";
            else
                fechaCorrecta += f.Month + "/";

            fechaCorrecta += f.Year + " ";

            if(f.Hour<10)
                fechaCorrecta += "0" + f.Hour + ":";
            else
                fechaCorrecta += f.Hour + ":";
            if (f.Minute < 10)
                fechaCorrecta += "0" + f.Minute + ":";
            else
                fechaCorrecta += f.Minute + ":";
            if (f.Second < 10)
                fechaCorrecta += "0" + f.Second;
            else
                fechaCorrecta += f.Second;

            return fechaCorrecta;
        }
        private void btnAgregarDeposito_Click(object sender, EventArgs e)
        {
            if (listOperadoresAsignados.SelectedIndex >= 0)
            {
                FormAgregarDeposito fm = new FormAgregarDeposito(user, listOperadoresAsignados.Items[listOperadoresAsignados.SelectedIndex].ToString(), entidadAeditar.IdViajeSci);
                DialogResult DialogForm = fm.ShowDialog();
            }
        }
        private void btnNuevoGasto_Click(object sender, EventArgs e)
        {
            editarGasto = false;
            limpiarFormularioRegistroDeGastos();
        }
        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (filaGastoSeleccionado >= 0)
            {
                idGastoAeditar = int.Parse(dgvGastos["idGasto", filaGastoSeleccionado].Value.ToString());
                cargarDatosGastoAeditar();
                editarGasto = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (filaCorteSeleccionado >= 0)
            {
                idCorteAeditar = int.Parse(dgvCortesOperador["idCorte", filaCorteSeleccionado].Value.ToString());
                cargarDatosCorteAeditar();
                editarCorte = true;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            editarCorte = false;
            limpiarFormularioCortes();
        }
        private void btnNuevoCobro_Click(object sender, EventArgs e)
        {
            editarCobroAdicional = false;
            limpiarFormularioCobros();
        }
        private void limpiarFormularioCobros()
        {
            comboTipoCobro.Text = string.Empty;
            textMontoCobro.Clear();
            textFechaCobroAdicional.Clear();
        }
        private void btnEditarCobro_Click(object sender, EventArgs e)
        {
            if (filaCobroAdicional >= 0)
            {
                idCobroAdicional = int.Parse(dgvCobrosAdicionales["idCobroAdicional", filaCobroAdicional].Value.ToString());
                cargarDatosCobroAdiciaonAeditar();
                editarCobroAdicional = true;
            }
        }
        private void cargarDatosCobroAdiciaonAeditar()
        {
            cobrosadicionales cobroAeditar = managerCobrosAdicionales.BuscarPorId(idCobroAdicional.ToString());
            comboTipoCobro.Text = cobroAeditar.TipoCobro;
            textMontoCobro.Text = cobroAeditar.Monto.ToString();
            textFechaCobroAdicional.Text = formatoFecha(cobroAeditar.Fecha);
        }
        private void btnGuardarCobroAdicional_Click(object sender, EventArgs e)
        {
            if (editarCobroAdicional == false)
            {
                cobrosadicionales nuevoCobroAdicional = new cobrosadicionales();
                try
                {
                    nuevoCobroAdicional.IdViajeSci = entidadAeditar.IdViajeSci;
                    nuevoCobroAdicional.TipoCobro = comboTipoCobro.Text;
                    nuevoCobroAdicional.Monto = double.Parse(textMontoCobro.Text);
                    nuevoCobroAdicional.Fecha = fechaValida(textFechaCobroAdicional.Text);

                    if (managerCobrosAdicionales.Insertar(nuevoCobroAdicional))
                    {
                        cobrosadicionales lastCobro = managerCobrosAdicionales.BuscarUltimoIngresado();
                        log registro = new log
                        {
                            Accion = "agregar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "cobro adicional-id:" + lastCobro.IdCobroAdicional + " -- viaje-id:" + lastCobro.IdViajeSci
                        };
                        managerLog.Insertar(registro);

                        cargarTodosCobrosAdicionales();
                        limpiarFormularioCobros();

                    }
                    else
                        MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo cobro adicional. " + managerCobrosAdicionales.Error, "No se pudo guardar el cobro Adicional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo Cobro. " + ex.Message, "No se pudo guardar el nuevo Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cobrosadicionales cobroAEditar = managerCobrosAdicionales.BuscarPorId(idCobroAdicional.ToString());
                try
                {
                    cobroAEditar.TipoCobro = comboTipoCobro.Text;
                    cobroAEditar.Monto = double.Parse(textMontoCobro.Text);
                    cobroAEditar.Fecha = DateTime.Parse(textFechaCobroAdicional.Text);

                    if (managerCobrosAdicionales.Actualizar(cobroAEditar))
                    {
                        log registro = new log
                        {
                            Accion = "editar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "cobrosadicionales-id:" + cobroAEditar.IdCobroAdicional + " -- viajes-id:" + cobroAEditar.IdViajeSci
                        };
                        managerLog.Insertar(registro);

                        cargarTodosCobrosAdicionales();
                        limpiarFormularioCobros();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo cobro. " + managerCobrosAdicionales.Error, "No se pudo guardar el cobro.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    editarCorte = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un problema al intentar guardar el nuevo cobro. " + ex.Message, "No se pudo guardar el cobro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvCobrosAdicionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaCobroAdicional = e.RowIndex;
        }
        private void dgvCobrosAdicionales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaCobroAdicional = e.RowIndex;
                idCobroAdicional = int.Parse(dgvCobrosAdicionales["idCobroAdicional", filaCobroAdicional].Value.ToString());
                cargarDatosCobroAdiciaonAeditar();
                editarCobroAdicional = true;
            }
        }
        private void btnEliminarCobro_Click(object sender, EventArgs e)
        {
            if (filaCobroAdicional >= 0)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el cobro adicional seleccionado?", "Eliminar Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string idCobroSeleccionado = dgvCobrosAdicionales["idCobroAdicional", filaCobroAdicional].Value.ToString();
                    cobrosadicionales cobroSeleccionado = managerCobrosAdicionales.BuscarPorId(idCobroSeleccionado);
                    if (managerCobrosAdicionales.Eliminar(idCobroSeleccionado))
                    {
                        log registro = new log
                        {
                            Accion = "eliminar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "cobrosadicionales-id:" + cobroSeleccionado.IdCobroAdicional + " -- viaje-id:" + cobroSeleccionado.IdViajeSci
                        };
                        managerLog.Insertar(registro);

                        cargarTodosCobrosAdicionales();
                    }
                    else
                        MessageBox.Show("El cobro no se ha podido eliminar.", "Eliminar Cobro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        #endregion

        #region Calendario Inicial SCI
        private void trackHoras_Scroll(object sender, EventArgs e)
        {
            horaInicialGeneral = trackHorasInicio.Value;
            completarFechaHoraMinutos();
        }
        private void trackMinutos_Scroll(object sender, EventArgs e)
        {
            minutoInicialGeneral = trackMinutosInicio.Value;
            completarFechaHoraMinutos();
        }
        private void completarFechaHoraMinutos()
        {
            textFechaInicial.Text = string.Empty;
            if (horaInicialGeneral < 10)
            {
                textFechaInicial.Text = fechaInicialGeneral + " 0" + horaInicialGeneral.ToString();
                if (minutoInicialGeneral < 10)
                {
                    textFechaInicial.Text = fechaInicialGeneral + " 0" + horaInicialGeneral.ToString() + ":0" + minutoInicialGeneral.ToString() + ":00";
                }
                else
                {
                    textFechaInicial.Text = fechaInicialGeneral + " 0" + horaInicialGeneral.ToString() + ":" + minutoInicialGeneral.ToString() + ":00";
                }
            }
            else
            {
                textFechaInicial.Text = fechaInicialGeneral + " " + horaInicialGeneral.ToString();
                if (minutoInicialGeneral < 10)
                {
                    textFechaInicial.Text = fechaInicialGeneral + " " + horaInicialGeneral.ToString() + ":0" + minutoInicialGeneral.ToString() + ":00";
                }
                else
                {
                    textFechaInicial.Text = fechaInicialGeneral + " " + horaInicialGeneral.ToString() + ":" + minutoInicialGeneral.ToString() + ":00";
                }
            }
        }
        private void calendarSci_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = calendarInicialSci.SelectionRange.Start.Year;
            int month = calendarInicialSci.SelectionRange.Start.Month;
            int day = calendarInicialSci.SelectionRange.Start.Day;

            if (day < 10)
                fechaInicialGeneral = "0" + day.ToString();
            else
                fechaInicialGeneral = day.ToString();

            fechaInicialGeneral += "/";

            if (month < 10)
                fechaInicialGeneral += "0" + month.ToString();
            else
                fechaInicialGeneral += month.ToString();

            fechaInicialGeneral += "/";
            fechaInicialGeneral += year.ToString();

            textFechaInicial.Text = fechaInicialGeneral;
            completarFechaHoraMinutos();
        }
        private void textFechaInicial_Click(object sender, EventArgs e)
        {
            if (panelFechaInicial.Visible == true)
                panelFechaInicial.Visible = false;
            else
            {
                if (textFechaInicial.Text == string.Empty)
                {
                    int year = calendarInicialSci.SelectionRange.Start.Year;
                    int month = calendarInicialSci.SelectionRange.Start.Month;
                    int day = calendarInicialSci.SelectionRange.Start.Day;
                    if (day < 10)
                        fechaInicialGeneral = "0" + day.ToString();
                    else
                        fechaInicialGeneral = day.ToString();

                    fechaInicialGeneral += "/";

                    if (month < 10)
                        fechaInicialGeneral += "0" + month.ToString();
                    else
                        fechaInicialGeneral += month.ToString();

                    fechaInicialGeneral += "/";
                    fechaInicialGeneral += year.ToString();

                    trackHorasInicio.Value = DateTime.Now.Hour;
                    trackMinutosInicio.Value = DateTime.Now.Minute;
                    horaInicialGeneral = trackHorasInicio.Value;
                    minutoInicialGeneral = trackMinutosInicio.Value;
                }
                else
                {
                    calendarInicialSci.SelectionStart = DateTime.Parse(textFechaInicial.Text);
                    calendarInicialSci.SelectionEnd = DateTime.Parse(textFechaInicial.Text);
                    trackHorasInicio.Value = calendarInicialSci.SelectionStart.Hour;
                    trackMinutosInicio.Value = calendarInicialSci.SelectionStart.Minute;

                    horaInicialGeneral = trackHorasInicio.Value;
                    minutoInicialGeneral = trackMinutosInicio.Value;
                }
                panelFechaInicial.Location = new Point(textFechaInicial.Location.X + 4, textFechaInicial.Location.Y + 30);
                panelFechaInicial.Visible = true;
                panelFechaFinal.Visible = false;
            }

            /*
            if (textFechaInicial.Text == string.Empty)
                button2_Click(sender, e);
            panelFechaInicial.Location = new Point(textFechaInicial.Location.X + 4, textFechaInicial.Location.Y + 30);
            panelFechaInicial.Visible = true;
            panelFechaFinal.Visible = false;*/
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            panelFechaInicial.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            if (hoy.Day < 10)
                textFechaInicial.Text = "0" + hoy.Day + "/";
            else
                textFechaInicial.Text = hoy.Day + "/";
            if (hoy.Month < 10)
                textFechaInicial.Text += "0" + hoy.Month + "/";
            else
                textFechaInicial.Text += hoy.Month + "/";

            textFechaInicial.Text += hoy.Year;
            fechaInicialGeneral = textFechaInicial.Text;

            if (hoy.Hour < 10)
                textFechaInicial.Text += " 0" + hoy.Hour + ":";
            else
                textFechaInicial.Text += " " + hoy.Hour + ":";

            if (hoy.Minute < 10)
                textFechaInicial.Text += "0" + hoy.Minute + ":00";
            else
                textFechaInicial.Text += hoy.Minute + ":00";

            horaInicialGeneral = hoy.Hour;
            minutoInicialGeneral = hoy.Minute;
            trackHorasInicio.Value = horaInicialGeneral;
            trackMinutosInicio.Value = minutoInicialGeneral;
        }
        private void btnCancelarFechaInicio_Click(object sender, EventArgs e)
        {
            if (entidadAeditar == null)
            {
                textFechaInicial.Text = string.Empty;
                panelFechaInicial.Visible = false;
                return;
            }
            if (entidadAeditar.IdViajeSci > 0)
            {
                if (formatoFecha(entidadAeditar.FechaInicio) == "01/01/1 00:00:00")
                    textFechaInicial.Text = string.Empty;
                else
                    textFechaInicial.Text = formatoFecha(entidadAeditar.FechaInicio);
            }
            panelFechaInicial.Visible = false;
        }
        #endregion

        #region Calendario Final SCI
        private void completarFechaHoraMinutosFinal()
        {
            if (horaFinalGeneral < 10)
            {
                textFechaFinal.Text = fechaFinalGeneral + " 0" + horaFinalGeneral.ToString();
                if (minutoFinalGeneral < 10)
                {
                    textFechaFinal.Text = fechaFinalGeneral + " 0" + horaFinalGeneral.ToString() + ":0" + minutoFinalGeneral.ToString() + ":00";
                }
                else
                {
                    textFechaFinal.Text = fechaFinalGeneral + " 0" + horaFinalGeneral.ToString() + ":" + minutoFinalGeneral.ToString() + ":00";
                }
            }
            else
            {
                textFechaFinal.Text = fechaFinalGeneral + " " + horaFinalGeneral.ToString();
                if (minutoFinalGeneral < 10)
                {
                    textFechaFinal.Text = fechaFinalGeneral + " " + horaFinalGeneral.ToString() + ":0" + minutoFinalGeneral.ToString() + ":00";
                }
                else
                {
                    textFechaFinal.Text = fechaFinalGeneral + " " + horaFinalGeneral.ToString() + ":" + minutoFinalGeneral.ToString() + ":00";
                }
            }
        }
        private void textFechaFinal_Click(object sender, EventArgs e)
        {
            if (panelFechaFinal.Visible == true)
                panelFechaFinal.Visible = false;
            else
            {
                if (textFechaFinal.Text == string.Empty)
                {
                    int year = calendarFinalSci.SelectionRange.Start.Year;
                    int month = calendarFinalSci.SelectionRange.Start.Month;
                    int day = calendarFinalSci.SelectionRange.Start.Day;
                    if (day < 10)
                        fechaFinalGeneral = "0" + day.ToString();
                    else
                        fechaFinalGeneral = day.ToString();

                    fechaFinalGeneral += "/";

                    if (month < 10)
                        fechaFinalGeneral += "0" + month.ToString();
                    else
                        fechaFinalGeneral += month.ToString();

                    fechaFinalGeneral += "/";
                    fechaFinalGeneral += year.ToString();

                    trackHorasFinal.Value = DateTime.Now.Hour;
                    trackMinutosFinal.Value = DateTime.Now.Minute;
                    horaFinalGeneral = trackHorasFinal.Value;
                    minutoFinalGeneral = trackMinutosFinal.Value;
                }
                else
                {
                    calendarFinalSci.SelectionStart = DateTime.Parse(textFechaFinal.Text);
                    calendarFinalSci.SelectionEnd = DateTime.Parse(textFechaFinal.Text);
                    trackHorasFinal.Value = calendarFinalSci.SelectionStart.Hour;
                    trackMinutosFinal.Value = calendarFinalSci.SelectionStart.Minute;

                    horaFinalGeneral = trackHorasFinal.Value;
                    minutoFinalGeneral = trackMinutosFinal.Value;
                }
                panelFechaFinal.Location = new Point(textFechaFinal.Location.X + 4, textFechaFinal.Location.Y + 30);
                panelFechaFinal.Visible = true;
                panelFechaInicial.Visible = false;
            }

            /*if (textFechaFinal.Text == string.Empty)
                btnFechaHoyFinal_Click(sender, e);
            panelFechaFinal.Location = new Point(textFechaFinal.Location.X + 4, textFechaFinal.Location.Y + 30);
            panelFechaFinal.Visible = true;
            panelFechaInicial.Visible = false;*/
        }
        private void btnFechaHoyFinal_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            if (hoy.Day < 10)
                textFechaFinal.Text = "0" + hoy.Day + "/";
            else
                textFechaFinal.Text = hoy.Day + "/";
            if (hoy.Month < 10)
                textFechaFinal.Text += "0" + hoy.Month + "/";
            else
                textFechaFinal.Text += hoy.Month + "/";


            textFechaFinal.Text += hoy.Year;
            fechaFinalGeneral = textFechaFinal.Text;

            if (hoy.Hour < 10)
                textFechaFinal.Text += " 0" + hoy.Hour + ":";
            else
                textFechaFinal.Text += " " + hoy.Hour + ":";

            if (hoy.Minute < 10)
                textFechaFinal.Text += "0" + hoy.Minute + ":00";
            else
                textFechaFinal.Text += hoy.Minute + ":00";


            horaFinalGeneral = hoy.Hour;
            minutoFinalGeneral = hoy.Minute;

            trackHorasFinal.Value = horaFinalGeneral;
            trackMinutosFinal.Value = minutoFinalGeneral;
        }
        private void btnAceptarFechaFinal_Click(object sender, EventArgs e)
        {
            panelFechaFinal.Visible = false;
        }
        private void calendarFinalSci_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = calendarFinalSci.SelectionRange.Start.Year;
            int month = calendarFinalSci.SelectionRange.Start.Month;
            int day = calendarFinalSci.SelectionRange.Start.Day;

            if (day < 10)
                fechaFinalGeneral = "0" + day.ToString();
            else
                fechaFinalGeneral = day.ToString();

            fechaFinalGeneral += "/";

            if (month < 10)
                fechaFinalGeneral += "0" + month.ToString();
            else
                fechaFinalGeneral += month.ToString();

            fechaFinalGeneral += "/";
            fechaFinalGeneral += year.ToString();

            textFechaFinal.Text = fechaFinalGeneral;
            completarFechaHoraMinutosFinal();
        }
        private void trackHorasFinal_Scroll(object sender, EventArgs e)
        {
            horaFinalGeneral = trackHorasFinal.Value;
            completarFechaHoraMinutosFinal();
        }
        private void trackMinutosFinal_Scroll(object sender, EventArgs e)
        {
            minutoFinalGeneral = trackMinutosFinal.Value;
            completarFechaHoraMinutosFinal();
        }
        private void btnCancelarFechaFinal_Click(object sender, EventArgs e)
        {
            if (entidadAeditar == null)
            {
                textFechaFinal.Text = string.Empty;
                panelFechaFinal.Visible = false;
                return;
            }

            if (entidadAeditar.IdViajeSci > 0)
            {
                if (formatoFecha(entidadAeditar.FechaFin) == "01/01/1 00:00:00")
                    textFechaFinal.Text = string.Empty;
                else
                    formatoFecha(entidadAeditar.FechaFin);
            }
            panelFechaFinal.Visible = false;
        }
        #endregion

        #region Calendario de Gastos
        private void textFechaDelGasto_Click(object sender, EventArgs e)
        {
            if (panelFechaGastos.Visible == true)
                panelFechaGastos.Visible = false;
            else
            {
                if (textFechaDelGasto.Text == string.Empty)
                {
                    int year = calendarGastos.SelectionRange.Start.Year;
                    int month = calendarGastos.SelectionRange.Start.Month;
                    int day = calendarGastos.SelectionRange.Start.Day;
                    if (day < 10)
                        fechaDelGasto = "0" + day.ToString();
                    else
                        fechaDelGasto = day.ToString();

                    fechaDelGasto += "/";

                    if (month < 10)
                        fechaDelGasto += "0" + month.ToString();
                    else
                        fechaDelGasto += month.ToString();

                    fechaDelGasto += "/";
                    fechaDelGasto += year.ToString();

                    trackHoraGastos.Value = DateTime.Now.Hour;
                    trackMinutosGastos.Value = DateTime.Now.Minute;
                    horaDelGasto = trackHoraGastos.Value;
                    minutosDelGasto = trackMinutosGastos.Value;
                }
                else
                {
                    calendarGastos.SelectionStart = DateTime.Parse(textFechaDelGasto.Text);
                    calendarGastos.SelectionEnd = DateTime.Parse(textFechaDelGasto.Text);
                    trackHoraGastos.Value = calendarGastos.SelectionStart.Hour;
                    trackMinutosGastos.Value = calendarGastos.SelectionStart.Minute;

                    horaDelGasto = trackHoraGastos.Value;
                    minutosDelGasto = trackMinutosGastos.Value;
                }
                panelFechaGastos.Location = new Point(textFechaDelGasto.Location.X+6, textFechaDelGasto.Location.Y-70);
                panelFechaGastos.Visible = true;
            }
        }
        private void btnHoyGastos_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            if (hoy.Day < 10)
                textFechaDelGasto.Text = "0" + hoy.Day + "/";
            else
                textFechaDelGasto.Text = hoy.Day + "/";
            if (hoy.Month < 10)
                textFechaDelGasto.Text += "0" + hoy.Month + "/";
            else
                textFechaDelGasto.Text += hoy.Month + "/";


            textFechaDelGasto.Text += hoy.Year;
            fechaDelGasto = textFechaDelGasto.Text;

            if (hoy.Hour < 10)
                textFechaDelGasto.Text += " 0" + hoy.Hour + ":";
            else
                textFechaDelGasto.Text += " " + hoy.Hour + ":";

            if (hoy.Minute < 10)
                textFechaDelGasto.Text += "0" + hoy.Minute + ":00";
            else
                textFechaDelGasto.Text += hoy.Minute + ":00";


            horaDelGasto = hoy.Hour;
            minutosDelGasto = hoy.Minute;

            trackHoraGastos.Value = horaDelGasto;
            trackMinutosGastos.Value = minutosDelGasto;
        }
        private void calendarGastos_DateChanged(object sender, DateRangeEventArgs e)
        {
            int year = calendarGastos.SelectionRange.Start.Year;
            int month = calendarGastos.SelectionRange.Start.Month;
            int day = calendarGastos.SelectionRange.Start.Day;

            if (day < 10)
                fechaDelGasto = "0" + day.ToString();
            else
                fechaDelGasto = day.ToString();

            fechaDelGasto += "/";

            if (month < 10)
                fechaDelGasto += "0" + month.ToString();
            else
                fechaDelGasto += month.ToString();

            fechaDelGasto += "/";
            fechaDelGasto += year.ToString();

            textFechaDelGasto.Text = fechaDelGasto;
            completarFechaHoraMinutosGastos();
        }
        private void completarFechaHoraMinutosGastos()
        {
            textFechaDelGasto.Text = string.Empty;
            if (horaDelGasto < 10)
            {
                textFechaDelGasto.Text = fechaDelGasto + " 0" + horaDelGasto.ToString();
                if (minutosDelGasto < 10)
                {
                    textFechaDelGasto.Text = fechaDelGasto + " 0" + horaDelGasto.ToString() + ":0" + minutosDelGasto.ToString() + ":00";
                }
                else
                {
                    textFechaDelGasto.Text = fechaDelGasto + " 0" + horaDelGasto.ToString() + ":" + minutosDelGasto.ToString() + ":00";
                }
            }
            else
            {
                textFechaDelGasto.Text = fechaDelGasto + " " + horaDelGasto.ToString();
                if (minutosDelGasto < 10)
                {
                    textFechaDelGasto.Text = fechaDelGasto + " " + horaDelGasto.ToString() + ":0" + minutosDelGasto.ToString() + ":00";
                }
                else
                {
                    textFechaDelGasto.Text = fechaDelGasto + " " + horaDelGasto.ToString() + ":" + minutosDelGasto.ToString() + ":00";
                }
            }
        }
        private void trackHoraGastos_Scroll(object sender, EventArgs e)
        {
            horaDelGasto = trackHoraGastos.Value;
            completarFechaHoraMinutosGastos();
        }
        private void trackMinutosGastos_Scroll(object sender, EventArgs e)
        {
            minutosDelGasto = trackMinutosGastos.Value;
            completarFechaHoraMinutosGastos();
        }
        private void btnAceptarGastos_Click(object sender, EventArgs e)
        {
            panelFechaGastos.Visible = false;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (idGastoAeditar > 0)
            {
                gasto gastoSeleccionado = managerGastos.BuscarPorId(idGastoAeditar.ToString());
                textFechaDelGasto.Text = formatoFecha(gastoSeleccionado.Fecha);
            }
            else
                textFechaDelGasto.Text = string.Empty;
            panelFechaGastos.Visible = false;
        }
        #endregion

        #region Calendario Inicial de Cortes
        private void trackHorasInicioCorte_Scroll(object sender, EventArgs e)
        {
            horaInicialCorte = trackHorasInicioCorte.Value;
            completarFechaHoraMinutosCorte();
        }
        private void trackMinutosInicioCorte_Scroll(object sender, EventArgs e)
        {
            minutoInicialCorte = trackMinutosInicioCorte.Value;
            completarFechaHoraMinutosCorte();
        }
        private void completarFechaHoraMinutosCorte()
        {
            textFechaHoraInicialCorte.Text = string.Empty;
            if (horaInicialCorte < 10)
            {
                textFechaHoraInicialCorte.Text = fechaInicialCorte + " 0" + horaInicialCorte.ToString();
                if (minutoInicialCorte < 10)
                {
                    textFechaHoraInicialCorte.Text = fechaInicialCorte + " 0" + horaInicialCorte.ToString() + ":0" + minutoInicialCorte.ToString() + ":00";
                }
                else
                {
                    textFechaHoraInicialCorte.Text = fechaInicialCorte + " 0" + horaInicialCorte.ToString() + ":" + minutoInicialCorte.ToString() + ":00";
                }
            }
            else
            {
                textFechaHoraInicialCorte.Text = fechaInicialCorte + " " + horaInicialCorte.ToString();
                if (minutoInicialCorte < 10)
                {
                    textFechaHoraInicialCorte.Text = fechaInicialCorte + " " + horaInicialCorte.ToString() + ":0" + minutoInicialCorte.ToString() + ":00";
                }
                else
                {
                    textFechaHoraInicialCorte.Text = fechaInicialCorte + " " + horaInicialCorte.ToString() + ":" + minutoInicialCorte.ToString() + ":00";
                }
            }
        }
        private void calendarInicioCortes_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = calendarInicioCortes.SelectionRange.Start.Year;
            int month = calendarInicioCortes.SelectionRange.Start.Month;
            int day = calendarInicioCortes.SelectionRange.Start.Day;

            if (day < 10)
                fechaInicialCorte = "0" + day.ToString();
            else
                fechaInicialCorte = day.ToString();

            fechaInicialCorte += "/";

            if (month < 10)
                fechaInicialCorte += "0" + month.ToString();
            else
                fechaInicialCorte += month.ToString();

            fechaInicialCorte += "/";
            fechaInicialCorte += year.ToString();

            textFechaHoraInicialCorte.Text = fechaInicialCorte;
            completarFechaHoraMinutosCorte();
        }
        private void textFechaHoraInicialOperador_Click(object sender, EventArgs e)
        {
            if (panelFechaInicioCorte.Visible == true)
                panelFechaInicioCorte.Visible = false;
            else
            {
                if (textFechaHoraInicialCorte.Text == string.Empty)
                {
                    int year = calendarInicioCortes.SelectionRange.Start.Year;
                    int month = calendarInicioCortes.SelectionRange.Start.Month;
                    int day = calendarInicioCortes.SelectionRange.Start.Day;
                    if (day < 10)
                        fechaInicialCorte = "0" + day.ToString();
                    else
                        fechaInicialCorte = day.ToString();

                    fechaInicialCorte += "/";

                    if (month < 10)
                        fechaInicialCorte += "0" + month.ToString();
                    else
                        fechaInicialCorte += month.ToString();

                    fechaInicialCorte += "/";
                    fechaInicialCorte += year.ToString();

                    trackHorasInicioCorte.Value = DateTime.Now.Hour;
                    trackMinutosInicioCorte.Value = DateTime.Now.Minute;
                    horaInicialCorte = trackHorasInicioCorte.Value;
                    minutoInicialCorte = trackMinutosInicioCorte.Value;
                }
                else
                {
                    calendarInicioCortes.SelectionStart = DateTime.Parse(textFechaHoraInicialCorte.Text);
                    calendarInicioCortes.SelectionEnd = DateTime.Parse(textFechaHoraInicialCorte.Text);
                    trackHorasInicioCorte.Value = calendarInicioCortes.SelectionStart.Hour;
                    trackMinutosInicioCorte.Value = calendarInicioCortes.SelectionStart.Minute;

                    horaInicialCorte = trackHorasInicioCorte.Value;
                    minutoInicialCorte = trackMinutosInicioCorte.Value;
                }
                panelFechaInicioCorte.Location = new Point(textFechaHoraInicialCorte.Location.X + 34, textFechaHoraInicialCorte.Location.Y - 63);// -332);
                panelFechaInicioCorte.Visible = true;
                panelFechaFinalCorte.Visible = false;
            }

            /*
            if (textFechaHoraInicialCorte.Text == string.Empty)
                btnHoyInicioCorte_Click(sender, e);
            panelFechaInicioCorte.Location = new Point(textFechaHoraInicialCorte.Location.X+7, textFechaHoraInicialCorte.Location.Y - 332);
            panelFechaInicioCorte.Visible = true;
            panelFechaFinalCorte.Visible = false;*/
        }
        private void btnFechaInicioAceptar_Click(object sender, EventArgs e)
        {
            panelFechaInicioCorte.Visible = false;
        }
        private void btnHoyInicioCorte_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            if (hoy.Day < 10)
                textFechaHoraInicialCorte.Text = "0" + hoy.Day + "/";
            else
                textFechaHoraInicialCorte.Text = hoy.Day + "/";
            if (hoy.Month < 10)
                textFechaHoraInicialCorte.Text += "0" + hoy.Month + "/";
            else
                textFechaHoraInicialCorte.Text += hoy.Month + "/";


            textFechaHoraInicialCorte.Text += hoy.Year;
            fechaInicialCorte = textFechaHoraInicialCorte.Text;

            if (hoy.Hour < 10)
                textFechaHoraInicialCorte.Text += " 0" + hoy.Hour + ":";
            else
                textFechaHoraInicialCorte.Text += " " + hoy.Hour + ":";

            if (hoy.Minute < 10)
                textFechaHoraInicialCorte.Text += "0" + hoy.Minute + ":00";
            else
                textFechaHoraInicialCorte.Text += hoy.Minute + ":00";


            horaInicialCorte = hoy.Hour;
            minutoInicialCorte = hoy.Minute;

            trackHorasInicioCorte.Value = horaInicialCorte;
            trackMinutosInicioCorte.Value = minutoInicialCorte;
        }
        private void btnFechaInicioCancelar_Click(object sender, EventArgs e)
        {
            if (idCorteAeditar > 0)
            {
                cortesoperador corteSeleccionado = managerCortes.BuscarPorId(idCorteAeditar.ToString());
                textFechaHoraInicialCorte.Text = formatoFecha(corteSeleccionado.FechaInicio);
            }
            else
                textFechaHoraInicialCorte.Text = string.Empty;
            panelFechaInicioCorte.Visible = false;
        }
        #endregion

        #region Calendario Final de Corte
        private void trackHoraFinCorte_Scroll(object sender, EventArgs e)
        {
            horaFinalCorte = trackHoraFinCorte.Value;
            completarFechaHoraMinutosCorteFinal();
        }
        private void trackMinutoFinCorte_Scroll(object sender, EventArgs e)
        {
            minutoFinalCorte = trackMinutoFinCorte.Value;
            completarFechaHoraMinutosCorteFinal();
        }
        private void completarFechaHoraMinutosCorteFinal()
        {
            textFechaHoraFinalCorte.Text = string.Empty;
            if (horaFinalCorte < 10)
            {
                textFechaHoraFinalCorte.Text = fechaFinalCorte + " 0" + horaFinalCorte.ToString();
                if (minutoFinalCorte < 10)
                {
                    textFechaHoraFinalCorte.Text = fechaFinalCorte + " 0" + horaFinalCorte.ToString() + ":0" + minutoFinalCorte.ToString() + ":00";
                }
                else
                {
                    textFechaHoraFinalCorte.Text = fechaFinalCorte + " 0" + horaFinalCorte.ToString() + ":" + minutoFinalCorte.ToString() + ":00";
                }
            }
            else
            {
                textFechaHoraFinalCorte.Text = fechaFinalCorte + " " + horaFinalCorte.ToString();
                if (minutoFinalCorte < 10)
                {
                    textFechaHoraFinalCorte.Text = fechaFinalCorte + " " + horaFinalCorte.ToString() + ":0" + minutoFinalCorte.ToString() + ":00";
                }
                else
                {
                    textFechaHoraFinalCorte.Text = fechaFinalCorte + " " + horaFinalCorte.ToString() + ":" + minutoFinalCorte.ToString() + ":00";
                }
            }
        }
        private void calendarFinCorte_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = calendarFinCorte.SelectionRange.Start.Year;
            int month = calendarFinCorte.SelectionRange.Start.Month;
            int day = calendarFinCorte.SelectionRange.Start.Day;

            if (day < 10)
                fechaFinalCorte = "0" + day.ToString();
            else
                fechaFinalCorte = day.ToString();

            fechaFinalCorte += "/";

            if (month < 10)
                fechaFinalCorte += "0" + month.ToString();
            else
                fechaFinalCorte += month.ToString();

            fechaFinalCorte += "/";
            fechaFinalCorte += year.ToString();

            textFechaHoraFinalCorte.Text = fechaFinalCorte;
            completarFechaHoraMinutosCorteFinal();
        }
        private void textFechaHoraFinalCorte_Click(object sender, EventArgs e)
        {
            if (panelFechaFinalCorte.Visible == true)
                panelFechaFinalCorte.Visible = false;
            else
            {
                if (textFechaHoraFinalCorte.Text == string.Empty)
                {
                    int year = calendarFinCorte.SelectionRange.Start.Year;
                    int month = calendarFinCorte.SelectionRange.Start.Month;
                    int day = calendarFinCorte.SelectionRange.Start.Day;
                    if (day < 10)
                        fechaFinalCorte = "0" + day.ToString();
                    else
                        fechaFinalCorte = day.ToString();

                    fechaFinalCorte += "/";

                    if (month < 10)
                        fechaFinalCorte += "0" + month.ToString();
                    else
                        fechaFinalCorte += month.ToString();

                    fechaFinalCorte += "/";
                    fechaFinalCorte += year.ToString();

                    trackHoraFinCorte.Value = DateTime.Now.Hour;
                    trackMinutoFinCorte.Value = DateTime.Now.Minute;
                    horaFinalCorte = trackHoraFinCorte.Value;
                    minutoFinalCorte = trackMinutoFinCorte.Value;
                }
                else
                {
                    calendarFinCorte.SelectionStart = DateTime.Parse(textFechaHoraFinalCorte.Text);
                    calendarFinCorte.SelectionEnd = DateTime.Parse(textFechaHoraFinalCorte.Text);
                    trackHoraFinCorte.Value = calendarFinCorte.SelectionStart.Hour;
                    trackMinutoFinCorte.Value = calendarFinCorte.SelectionStart.Minute;

                    horaFinalCorte = trackHoraFinCorte.Value;
                    minutoFinalCorte = trackMinutoFinCorte.Value;
                }
                panelFechaFinalCorte.Location = new Point(textFechaHoraFinalCorte.Location.X + 34, textFechaHoraFinalCorte.Location.Y - 63);
                panelFechaFinalCorte.Visible = true;
                panelFechaInicioCorte.Visible = false;
            }
            
        }
        private void btnAceptarFinCorte_Click(object sender, EventArgs e)
        {
            panelFechaFinalCorte.Visible = false;
        }
        private void btnHoyFinCorte_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            if (hoy.Day < 10)
                textFechaHoraFinalCorte.Text = "0" + hoy.Day + "/";
            else
                textFechaHoraFinalCorte.Text = hoy.Day + "/";
            if (hoy.Month < 10)
                textFechaHoraFinalCorte.Text += "0" + hoy.Month + "/";
            else
                textFechaHoraFinalCorte.Text += hoy.Month + "/";


            textFechaHoraFinalCorte.Text += hoy.Year;
            fechaFinalCorte = textFechaHoraFinalCorte.Text;

            if (hoy.Hour < 10)
                textFechaHoraFinalCorte.Text += " 0" + hoy.Hour + ":";
            else
                textFechaHoraFinalCorte.Text += " " + hoy.Hour + ":";

            if (hoy.Minute < 10)
                textFechaHoraFinalCorte.Text += "0" + hoy.Minute + ":00";
            else
                textFechaHoraFinalCorte.Text += hoy.Minute + ":00";


            horaFinalCorte = hoy.Hour;
            minutoFinalCorte = hoy.Minute;

            trackHoraFinCorte.Value = horaFinalCorte;
            trackMinutoFinCorte.Value = minutoFinalCorte;
        }
        private void btnFechaFinalCancelar_Click(object sender, EventArgs e)
        {
            if (idCorteAeditar > 0)
            {
                cortesoperador corteSeleccionado = managerCortes.BuscarPorId(idCorteAeditar.ToString());
                textFechaHoraFinalCorte.Text = formatoFecha(corteSeleccionado.FechaFin);
            }
            else
                textFechaHoraFinalCorte.Text = string.Empty;
            panelFechaFinalCorte.Visible = false;
        }
        #endregion

        #region Calendario Final de Cobros
        private void trackHoraFechaCobro_Scroll(object sender, EventArgs e)
        {
            horaCobroAdicional = trackHoraFechaCobro.Value;
            completarFechaHoraMinutosCobroAdicional();
        }
        private void trackMinutosHoraCobro_Scroll(object sender, EventArgs e)
        {
            minutoCobroAdicional = trackMinutosHoraCobro.Value;
            completarFechaHoraMinutosCobroAdicional();
        }
        private void completarFechaHoraMinutosCobroAdicional()
        {
            textFechaCobroAdicional.Text = string.Empty;
            if (horaCobroAdicional < 10)
            {
                textFechaCobroAdicional.Text = fechaCobroAdicional + " 0" + horaCobroAdicional.ToString();
                if (minutoCobroAdicional < 10)
                {
                    textFechaCobroAdicional.Text = fechaCobroAdicional + " 0" + horaCobroAdicional.ToString() + ":0" + minutoCobroAdicional.ToString() + ":00";
                }
                else
                {
                    textFechaCobroAdicional.Text = fechaCobroAdicional + " 0" + horaCobroAdicional.ToString() + ":" + minutoCobroAdicional.ToString() + ":00";
                }
            }
            else
            {
                textFechaCobroAdicional.Text = fechaCobroAdicional + " " + horaCobroAdicional.ToString();
                if (minutoCobroAdicional < 10)
                {
                    textFechaCobroAdicional.Text = fechaCobroAdicional + " " + horaCobroAdicional.ToString() + ":0" + minutoCobroAdicional.ToString() + ":00";
                }
                else
                {
                    textFechaCobroAdicional.Text = fechaCobroAdicional + " " + horaCobroAdicional.ToString() + ":" + minutoCobroAdicional.ToString() + ":00";
                }
            }
        }
        private void calendarFechaCobro_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = calendarFechaCobro.SelectionRange.Start.Year;
            int month = calendarFechaCobro.SelectionRange.Start.Month;
            int day = calendarFechaCobro.SelectionRange.Start.Day;

            if (day < 10)
                fechaCobroAdicional = "0" + day.ToString();
            else
                fechaCobroAdicional = day.ToString();

            fechaCobroAdicional += "/";

            if (month < 10)
                fechaCobroAdicional += "0" + month.ToString();
            else
                fechaCobroAdicional += month.ToString();

            fechaCobroAdicional += "/";
            fechaCobroAdicional += year.ToString();

            textFechaCobroAdicional.Text = fechaCobroAdicional;
            completarFechaHoraMinutosCobroAdicional();
        }
        private void textFechaCobroAdicional_Click(object sender, EventArgs e)
        {
            if (panelFechaCobroAdicional.Visible == true)
                panelFechaCobroAdicional.Visible = false;
            else
            {
                if (textFechaCobroAdicional.Text == string.Empty)
                {
                    int year = calendarFechaCobro.SelectionRange.Start.Year;
                    int month = calendarFechaCobro.SelectionRange.Start.Month;
                    int day = calendarFechaCobro.SelectionRange.Start.Day;
                    if (day < 10)
                        fechaCobroAdicional = "0" + day.ToString();
                    else
                        fechaCobroAdicional = day.ToString();

                    fechaCobroAdicional += "/";

                    if (month < 10)
                        fechaCobroAdicional += "0" + month.ToString();
                    else
                        fechaCobroAdicional += month.ToString();

                    fechaCobroAdicional += "/";
                    fechaCobroAdicional += year.ToString();

                    trackHoraFechaCobro.Value = DateTime.Now.Hour;
                    trackMinutosHoraCobro.Value = DateTime.Now.Minute;
                    horaCobroAdicional = trackHoraFechaCobro.Value;
                    minutoCobroAdicional = trackMinutosHoraCobro.Value;
                }
                else
                {
                    calendarFechaCobro.SelectionStart = DateTime.Parse(textFechaCobroAdicional.Text);
                    calendarFechaCobro.SelectionEnd = DateTime.Parse(textFechaCobroAdicional.Text);

                    trackHoraFechaCobro.Value = calendarFechaCobro.SelectionStart.Hour;
                    trackMinutosHoraCobro.Value = calendarFechaCobro.SelectionStart.Minute;

                    horaCobroAdicional = trackHoraFechaCobro.Value;
                    minutoCobroAdicional = trackMinutosHoraCobro.Value;
                }
                panelFechaCobroAdicional.Location = new Point(textFechaCobroAdicional.Location.X + 27, textFechaCobroAdicional.Location.Y - 67);
                panelFechaCobroAdicional.Visible = true;
            }
        }
        private void btnAceptarFechaCobro_Click(object sender, EventArgs e)
        {
            panelFechaCobroAdicional.Visible = false;
        }
        private void btnHoyFechaCobro_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            if (hoy.Day < 10)
                textFechaCobroAdicional.Text = "0" + hoy.Day + "/";
            else
                textFechaCobroAdicional.Text = hoy.Day + "/";
            if (hoy.Month < 10)
                textFechaCobroAdicional.Text += "0" + hoy.Month + "/";
            else
                textFechaCobroAdicional.Text += hoy.Month + "/";


            textFechaCobroAdicional.Text += hoy.Year;
            fechaCobroAdicional = textFechaCobroAdicional.Text;

            if (hoy.Hour < 10)
                textFechaCobroAdicional.Text += " 0" + hoy.Hour + ":";
            else
                textFechaCobroAdicional.Text += " " + hoy.Hour + ":";

            if (hoy.Minute < 10)
                textFechaCobroAdicional.Text += "0" + hoy.Minute + ":00";
            else
                textFechaCobroAdicional.Text += hoy.Minute + ":00";


            horaCobroAdicional = hoy.Hour;
            minutoCobroAdicional = hoy.Minute;

            trackHoraFechaCobro.Value = horaCobroAdicional;
            trackMinutosHoraCobro.Value = minutoCobroAdicional;
        }
        private void btnCancelarFechaCobro_Click(object sender, EventArgs e)
        {
            if (idCobroAdicional > 0)
            {
                cobrosadicionales cobroSeleccionado = managerCobrosAdicionales.BuscarPorId(idCobroAdicional.ToString());
                textFechaCobroAdicional.Text = formatoFecha(cobroSeleccionado.Fecha);
            }
            else
                textFechaCobroAdicional.Text = string.Empty;
            panelFechaCobroAdicional.Visible = false;
        }
        #endregion

        #region Botones Subir y Bajar Operador
        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (listOperadoresAsignados.SelectedIndex > 0)
            {
                int idTemporal = 0;
                int selectIndex = listOperadoresAsignados.SelectedIndex;
                operador opArriba = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[selectIndex - 1].ToString());
                operador opAbajo = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[selectIndex].ToString());
                operadoresenviaje opUp = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci,opArriba.IdOperador);
                operadoresenviaje opDown = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opAbajo.IdOperador);

                idTemporal = opDown.Posicion;
                opDown.Posicion = opUp.Posicion;
                opUp.Posicion = idTemporal;

                managerOperadoresEnViaje.Actualizar(opDown);
                managerOperadoresEnViaje.Actualizar(opUp);

                listOperadoresAsignados.Items.Clear();
                cargarListaOperadoresAsignadosAlViaje();

                listOperadoresAsignados.SelectedIndex = selectIndex - 1;
            }
        }
        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (listOperadoresAsignados.SelectedIndex < listOperadoresAsignados.Items.Count-1)
            {
                int idTemporal = 0;
                int selectIndex = listOperadoresAsignados.SelectedIndex;
                operador opAbajo = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[selectIndex + 1].ToString());
                operador opArriba = managerOperador.BuscarPorNombreExacto(listOperadoresAsignados.Items[selectIndex].ToString());
                operadoresenviaje opUp = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opArriba.IdOperador);
                operadoresenviaje opDown = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opAbajo.IdOperador);

                idTemporal = opDown.Posicion;
                opDown.Posicion = opUp.Posicion;
                opUp.Posicion = idTemporal;

                managerOperadoresEnViaje.Actualizar(opDown);
                managerOperadoresEnViaje.Actualizar(opUp);

                listOperadoresAsignados.Items.Clear();
                cargarListaOperadoresAsignadosAlViaje();

                listOperadoresAsignados.SelectedIndex = selectIndex + 1;
            }
        }

        #endregion

        
    }
}
