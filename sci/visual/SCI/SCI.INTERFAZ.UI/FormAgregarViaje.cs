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
        bool editarGasto = false;
        bool editarCorte = false;
        int idGastoAeditar = 0;
        int idCorteAeditar = 0;

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

            accion = evento;
            idAEditar = id;
            user = u;
        }
        private void FormAgregarViaje_Load(object sender, EventArgs e)
        {
            //cargarComboRutas();
            cargarComboClientes();
            cargarComboStatus();
            cargarComboTipoDeGastos();
            cargarListaOperadores();
            cargarTodasLasUnidades();

            if (accion == "editar")
            {

                textFechaDelGasto.Text = dateTimeFechaGasto.Value.ToString(); //Se inicializa la fecha del gasto
                entidadAeditar = managerViajes.BuscarPorId(idAEditar.ToString()); //Se carga los datos del Viaje a editar

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

                textClaveViajeCliente.Text = entidadAeditar.IdViajeCliente;

                //Se inicializan los combos con los valores cargados del viaje
                comboClientes.Text = entidadCliente.IdCliente.ToString() + "/" + entidadCliente.RazonSocial;
                comboRutas.Text = entidadRuta.IdRuta.ToString() + "/" + entidadRuta.Nombre;
                comboStatus.Text = entidadStatus.IdStatus.ToString() + "/" + entidadStatus.Nombre;
                comboUnidades.Text = entidadUnidad.NumeroEconomico.ToString() + "/" + entidadUnidad.Nombre;
                comboStatus.Enabled = true;

                //Carga todos los GASTOS relacionados con el Viaje en el dgv Del TabControl = Gastos
                cargarTodosLosGastosDelViaje();

                //Datos del operador y CORTES que se han hecho, tabControl = Cortes
                cargarTodosLosCortesDelViaje();
                cargarListaOperadoresAsignadosAlViaje();
                textFechaHoraInicialOperador.Text = calendarCortesOperador.SelectionRange.Start.ToString();
                textFechaHoraFinalOperador.Text = calendarCortesOperador.SelectionRange.End.ToString();

                this.Text = "Actualizar los datos del Viaje.";
                btnAgregarViaje.Text = "Editar Viaje";
                textMontoGasto.Text = string.Empty;
                comboFormaPago.SelectedIndex = 0;

                /*if (comboStatus.Text.Contains("Iniciado"))
                {
                    groupGastos.Enabled = false;
                    groupCortesOPerador.Enabled = false;
                }
                else
                {
                    groupGastos.Enabled = true;
                    groupCortesOPerador.Enabled = true;
                }*/

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
                labelTotalGastos.Visible = false;
                labelSaldoTotalCortes.Visible = false;
                labelSueldoCortes.Visible = false;
                groupGastos.Enabled = false;
                groupCortesOPerador.Enabled = false;

            }

            comboTipoGastos.Text = "";
            editarGasto = false;

        }
        private void cargarListaOperadores()
        {
            IEnumerable<operador> operadores = managerOperador.ObtenerTodos;
            //listTotalOperadores.DataSource = operadores.Select(r => (r.IdOperador + "/" + r.Nombre)).ToList();
            comboOperadores.DataSource = operadores.OrderByDescending(s=>s.Nombre).Select(r => (r.Nombre + " " + r.Apellidos)).ToList();
            comboOperadores.Text = string.Empty;
        }
        private void cargarListaOperadoresAsignadosAlViaje()
        {
            //Se limpia el combo de Operadores Asignados para el corte
            comboOperadoresCortes.Items.Clear();
            comboOperadoresGasto.Items.Clear();

            IEnumerable<operadoresenviaje> operadoresEnViaje = managerOperadoresEnViaje.ObtenerTodos;
            if (operadoresEnViaje != null)
            {
                IEnumerable<operadoresenviaje> operadoresViaje = managerOperadoresEnViaje.BuscarPorIdViajeOps(entidadAeditar.IdViajeSci);
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
            labelSaldoTotalCortes.Text = "$" + TodosCortes.Sum(g => g.Costo).ToString();

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

            }
        }
        public void cargarTodosLosGastosDelViaje()
        {
            dgvGastos.Columns.Clear();
            IEnumerable<gasto> TodosLosGastos = managerGastos.BuscarPorIdViajeOps(entidadAeditar.IdViajeSci);
            dgvGastos.DataSource = TodosLosGastos.ToArray();
            labelTotalDeGastos.Text = "$" + TodosLosGastos.Sum(g => g.Costo).ToString();
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

        }
        private void cargarComboStatus()
        {
            IEnumerable<statusviaje> StatusViaje = managerStatus.ObtenerTodos;
            comboStatus.DataSource = StatusViaje.Select(r => (r.IdStatus + "/" + r.Nombre)).ToList();
            comboStatus.Text = string.Empty;
        }
        private void cargarComboTipoDeGastos()
        {
            IEnumerable<tipogasto> tiposDeGastos = managerTiposDeGastos.ObtenerTodos;
            comboTipoGastos.DataSource = tiposDeGastos.Select(r => (r.IdTipoGasto + "/" + r.Concepto)).ToList();
        }
        private void cargarComboClientes()
        {
            IEnumerable<cliente> cliente = managerCliete.ObtenerTodos;
            comboClientes.DataSource = cliente.Select(r => (r.IdCliente + "/" + r.RazonSocial)).ToList();
            comboClientes.Text = string.Empty;
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
                        if (validarFechaDelGasto() == false)
                        {
                            MessageBox.Show("La fecha del Gasto esta fuera del rango de las fechas del Viaje de Sci.", "Erro al ingresar el nuevo gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string[] cadena = comboTipoGastos.Text.Split('/');
                        int idTipoGasto = int.Parse(cadena.First());
                        gasto nuevoGasto = new gasto();
                        nuevoGasto.IdTipoGasto = idTipoGasto;

                        string[] cadenaOp = comboOperadoresGasto.Text.Split('/');
                        int idOpAGasto = int.Parse(cadenaOp.First());
                        nuevoGasto.IdOperador = idOpAGasto;

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
                        if (validarFechaDelGasto() == false)
                        {
                            MessageBox.Show("La fecha del Gasto esta fuera del rango de las fechas del Viaje de Sci.", "Erro al ingresar el nuevo gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
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
        private bool validarFechaDelGasto()
        {
            DateTime fechayHora = DateTime.Parse(textFechaDelGasto.Text);
            if (fechayHora < entidadAeditar.FechaFin && fechayHora >= entidadAeditar.FechaInicio)
                return true;
            else return false;
        }
        private void limpiarFormularioRegistroDeGastos()
        {
            comboTipoGastos.Text = "";
            textConceptoGasto.Clear();
            textMontoGasto.Clear();
            textRutaPdf.Clear();
            textRutaXml.Clear();

            textPoliza.Text = "0";
            textTicket.Text = string.Empty;
            textNumFactura.Text = string.Empty;
            comboFormaPago.Text = string.Empty;
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
        private void dateTimeFechaGasto_ValueChanged(object sender, EventArgs e)
        {
            textFechaDelGasto.Text = dateTimeFechaGasto.Value.ToString();
        }
        private void calendarCortesOperador_DateChanged(object sender, DateRangeEventArgs e)
        {
            textFechaHoraInicialOperador.Text = e.Start.ToString();
            textFechaHoraFinalOperador.Text = e.End.ToString();
            calcularMontoPorHorasOperador();
        }
        private void calcularMontoPorHorasOperador()
        {
            if (textFechaHoraInicialOperador.Text != string.Empty && textFechaHoraFinalOperador.Text != string.Empty && textFechaHoraFinalOperador.Text != "01/01/0001 12:00:00 a. m.")
            {
                try
                {
                    DateTime fechaInicio = DateTime.Parse(textFechaHoraInicialOperador.Text);
                    DateTime fechaFinal = fechaValida(textFechaHoraFinalOperador.Text);
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
            textCostoTotal.Text = Math.Round(double.Parse(textCostoTotal.Text)).ToString();
        }
        private void btnAgregarCorteOperador_Click(object sender, EventArgs e)
        {
            if (editarCorte == false)
            {
                cortesoperador nuevoCorte = new cortesoperador();
                try
                {
                    nuevoCorte.FechaInicio = DateTime.Parse(textFechaHoraInicialOperador.Text);
                    nuevoCorte.FechaFin = fechaValida(textFechaHoraFinalOperador.Text);
                    nuevoCorte.Costo = double.Parse(textCostoTotal.Text);
                    nuevoCorte.IdViajeSci = entidadAeditar.IdViajeSci;
                    nuevoCorte.IdStatus = entidadAeditar.IdStatus;
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
                    corteAEditar.FechaInicio = DateTime.Parse(textFechaHoraInicialOperador.Text);
                    corteAEditar.FechaFin = fechaValida(textFechaHoraFinalOperador.Text);
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
        private void limpiarFormularioCortes()
        {
            textFechaHoraInicialOperador.Clear();
            textFechaHoraFinalOperador.Clear();
            textTotalHoras.Clear();
            textCostoTotal.Clear();
        }
        private void textFechaHoraFinalOperador_Leave(object sender, EventArgs e)
        {
            calcularMontoPorHorasOperador();
        }
        private void cargarTodasLasUnidades()
        {
            IEnumerable<unidades> TodasLasUnidades = managerUnidades.ObtenerTodos;
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
            tipoDeGasto = "Otros";
            textConceptoGasto.Visible = true;
            comboCasetas.Visible = false;
            comboGasolinerias.Visible = false;
            comboCasetas.Text = string.Empty;
            comboGasolinerias.Text = string.Empty;

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

                        cargarTodosLosGastosDelViaje();
                    }
                    else
                        MessageBox.Show("El gasto no se ha podido eliminar.", "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            dateTimeFechaGasto.Value = gastoSeleccionado.Fecha;
            textRutaPdf.Text = gastoSeleccionado.RutaPdf;
            textRutaXml.Text = gastoSeleccionado.RutaXml;
            textMontoGasto.Text = gastoSeleccionado.Costo.ToString();
            textPoliza.Text = gastoSeleccionado.NumeroDePoliza.ToString();
            textNumFactura.Text = gastoSeleccionado.FolioFactura;
            textTicket.Text = gastoSeleccionado.NumTicket;
            comboFormaPago.Text = gastoSeleccionado.FormaDePago;
        }
        /*private void listTotalOperadores_DoubleClick(object sender, EventArgs e)
        {
            string[] cadena = listTotalOperadores.SelectedItem.ToString().Split('/');
            DialogResult result = MessageBox.Show("¿Esta Seguro que de sea agregar este operador al Viaje?", "Agregar Operador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                operadoresenviaje opEnViaje = new operadoresenviaje { IdOperador = int.Parse(cadena.First()), IdViajeSci = entidadAeditar.IdViajeSci, SaldoActual = 0 };

                //Validamos si ya esta el Operadore asgnado al viaje
                operadoresenviaje opYaAgregado = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeSci, opEnViaje.IdOperador);
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
        }*/
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
                        int contaCortes = corteAgregado.ToArray().Count();
                        int contaGastos = gastosAgregados.ToArray().Count();
                        if (opYaAgregado != null && contaCortes == 0 && contaGastos == 0) // && gastosAgregados == null) //El operador no puede eliminarse si tiene cortes o gastos asociados.
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
                            MessageBox.Show("Lo sentimos el operador no se ha podido eliminar del viaje. Revisa que no tenga Cortes o Gastos ya registrados.", "Eliminar Operador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            textFechaHoraInicialOperador.Text = corteSeleccionado.FechaInicio.ToString();
            textFechaHoraFinalOperador.Text = corteSeleccionado.FechaFin.ToString();
            textTotalHoras.Text = corteSeleccionado.Horas.ToString();
            textCostoHoraOperador.Text = opSeleccionado.Salarioporhora.ToString();
            textCostoTotal.Text = corteSeleccionado.Costo.ToString();

            calendarCortesOperador.SelectionRange.Start = corteSeleccionado.FechaInicio;
            calendarCortesOperador.SelectionRange.End = corteSeleccionado.FechaFin;
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
                        operadoresenviaje opEnViaje = new operadoresenviaje { IdOperador = opSeleccionado.IdOperador, IdViajeSci = entidadAeditar.IdViajeSci, SaldoActual = 0 };

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
            if (textFechaInicial.Text == string.Empty)
                button2_Click(sender, e);
            panelFechaInicial.Location = new Point(textFechaInicial.Location.X + 4, textFechaInicial.Location.Y + 30);
            panelFechaInicial.Visible = true;
            panelFechaFinal.Visible = false;
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
            if (textFechaFinal.Text == string.Empty)
                btnFechaHoyFinal_Click(sender, e);
            panelFechaFinal.Location = new Point(textFechaFinal.Location.X + 4, textFechaFinal.Location.Y + 30);
            panelFechaFinal.Visible = true;
            panelFechaInicial.Visible = false;
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

        #endregion

        private void btnAgregarDeposito_Click(object sender, EventArgs e)
        {
            //listBoxStatus.Visible = false;
            FormAgregarDeposito fm = new FormAgregarDeposito(user, listOperadoresAsignados.Items[listOperadoresAsignados.SelectedIndex].ToString(), entidadAeditar.IdViajeSci);
            DialogResult DialogForm = fm.ShowDialog();
            //if (fm.Valor != string.Empty)
            //{
                //CargarTodosLosViajes(comboStatus.Text);
               // CargarTodosLosViajes(btnStatus.Text);
                //mostrarLabelStatus(fm.Valor, true);
            //}
        }
    }
}
