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

        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        viaje entidadAeditar;
        string nombreArchivoPdf = string.Empty;
        string nombreArchivoXml = string.Empty;
        //string rutaArchivoPDF = string.Empty;
        //tring rutaArchivoXml = string.Empty;
        string nombreArchivoNuevoPdf = string.Empty;
        string nombreArchivoNuevoXml = string.Empty;
        string tipoDeGasto = string.Empty;
        int filaGastoSeleccionado = -1;

        statusviaje entidadStatus;
        ruta entidadRuta;
        cliente entidadCliente;
        operador entidadOperador;
        cortesoperador entidadCortes;
        unidades entidadUnidad;

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
            managerTiposDeGastos = Tools.FabricManager.TipoDeGastoManager();
            managerGastos = Tools.FabricManager.GastoManager();
            managerCortes = Tools.FabricManager.CortesOperadorManager();
            managerTipoDeUnidad = Tools.FabricManager.TipoDeUnidadesManager();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerGasolinerias = Tools.FabricManager.GasolineriaManager();
            managerCasetas = Tools.FabricManager.CasetaManager();
            managerOperadoresEnViaje = Tools.FabricManager.OperadoresEnViajeManager();

            accion = evento;
            idAEditar = id;
        }

        private void FormAgregarViaje_Load(object sender, EventArgs e)
        {
            cargarComboRutas();
            cargarComboClientes();
            cargarComboOperadores();
            cargarComboStatus();
            cargarComboTipoDeGastos();            
            cargarListaOperadores();

            if (accion == "editar")
            {
                
                textFechaDelGasto.Text = dateTimeFechaGasto.Value.ToString(); //Se inicializa la fecha del gasto
                entidadAeditar = managerViajes.BuscarPorId(idAEditar.ToString()); //Se carga los datos del Viaje a editar

                //Se cargan las entidades ligadas con el viaje SCi
                entidadStatus = managerStatus.BuscarPorId(entidadAeditar.IdStatus.ToString());
                entidadRuta = managerRuta.BuscarPorId(entidadAeditar.IdRuta.ToString());
                entidadCliente = managerCliete.BuscarPorId(entidadAeditar.IdCliente.ToString());
                entidadOperador = managerOperador.BuscarPorId(entidadAeditar.IdOperador.ToString());
                entidadUnidad = managerUnidades.BuscarPorId(entidadAeditar.IdUnidad.ToString());

                //Se cargan los valores del viaje a los componentes
                textClaveViajeCliente.Text = entidadAeditar.IdViajeCliente;
                calendarSci.SelectionStart = entidadAeditar.FechaInicioSci;
                calendarSci.SelectionEnd = entidadAeditar.FechaFinSci;
                CalendarCliente.SelectionStart = entidadAeditar.FechaInicioCliente;
                CalendarCliente.SelectionEnd = entidadAeditar.FechaFinCliente;
                textDateInicioSci.Text = entidadAeditar.FechaInicioSci.ToString();
                textDateInicioCliente.Text = entidadAeditar.FechaInicioCliente.ToString();
                textDateFinSci.Text = entidadAeditar.FechaFinSci.ToString();
                textDateFinCliente.Text = entidadAeditar.FechaFinCliente.ToString();

                //Se inicializan los combos con los valores cargados del viaje
                comboRutas.Text = entidadRuta.IdRuta.ToString() + "/" + entidadRuta.Nombre;
                comboClientes.Text = entidadCliente.IdCliente.ToString() + "/" + entidadCliente.RazonSocial;
                comboOperadores.Text = entidadOperador.IdOperador.ToString() + "/" + entidadOperador.Nombre;
                comboStatus.Text = entidadStatus.IdStatus.ToString() + "/" + entidadStatus.Nombre;
                comboUnidades.Text = entidadUnidad.IdUnidad.ToString() + "/" + entidadUnidad.Nombre;
                comboStatus.Enabled = true;

                //Carga todos los gastos relacionados con el Viaje en el dgv Del TabControl = Gastos
                cargarTodosLosGastosDelViaje(entidadAeditar.IdViajeOps);

                //Datos del operador y cortes que se han hecho, tabControl = Cortes
                textCostoHoraOperador.Text = entidadOperador.Salarioporhora.ToString();
                cargarTodosLosCortesDelViaje(entidadAeditar.IdViajeOps);
                cargarListaOperadoresAsignadosAlViaje();


                this.Text = "Actualizar los datos del Viaje.";
                btnAgregarViaje.Text = "Editar Viaje";
                textMontoGasto.Text = string.Empty;
                comboFormaPago.SelectedIndex = 0;
            }
            else
            {
                //datos iniciales la orden es Agregar nuevo Viaje
                statusviaje estado = managerStatus.BuscaPorStatus("En Planeación");
                comboStatus.Text = estado.IdStatus + "/" + estado.Nombre;
                comboRutas.Text = string.Empty;
                comboClientes.Text = string.Empty;
                comboOperadores.Text = string.Empty;
                comboUnidades.DataSource = null;
                comboTipoGastos.Text = string.Empty;
                groupGastos.Enabled = false;
                groupCortesOPerador.Enabled = false;
                labelTotalDeGastos.Visible = false;
                labelTotalGastos.Visible = false;
                labelSaldoTotalCortes.Visible = false;
                labelSueldoCortes.Visible = false;

            }

            comboTipoGastos.Text = "";
        }

        private void cargarListaOperadores()
        {
            IEnumerable<operador> operadores = managerOperador.ObtenerTodos;
            listTotalOperadores.DataSource = operadores.Select(r => (r.IdOperador + "/" + r.Nombre)).ToList();
        }

        private void cargarListaOperadoresAsignadosAlViaje()
        {
            IEnumerable<operadoresenviaje> operadoresEnViaje = managerOperadoresEnViaje.ObtenerTodos;
            if (operadoresEnViaje!=null)
            {
                IEnumerable<operadoresenviaje> operadoresViaje = managerOperadoresEnViaje.BuscarPorIdViajeOps(entidadAeditar.IdViajeOps);
                operador op = new operador();
                foreach (var item in operadoresViaje)
                {
                    op = managerOperador.BuscarPorId(item.IdOperador.ToString());
                    listOperadoresAsignados.Items.Add(op.Nombre + " " + op.Apellidos);
                }
            }
        }
            private void cargarTodosLosCortesDelViaje(int idViajeOps)
        {
            IEnumerable<cortesoperador> TodosCortes = managerCortes.BuscarCortesPorIdViaje(idViajeOps);
            dgvCortesOperador.DataSource = TodosCortes.ToArray();
            labelSaldoTotalCortes.Text = "$"+TodosCortes.Sum(g => g.Costo).ToString();
        }

        public void cargarTodosLosGastosDelViaje(int idViajeOps)
        {
            IEnumerable<gasto> TodosLosGastos = managerGastos.BuscarPorIdViajeOps(idViajeOps);
            dgvGastos.DataSource = TodosLosGastos.ToArray();
            labelTotalDeGastos.Text = "$"+TodosLosGastos.Sum(g => g.Costo).ToString();
        }

        private void cargarComboStatus()
        {
            IEnumerable<statusviaje> StatusViaje = managerStatus.ObtenerTodos;
            comboStatus.DataSource = StatusViaje.Select(r => (r.IdStatus + "/" + r.Nombre)).ToList();
            comboStatus.Text = string.Empty;
        }

        private void cargarComboOperadores()
        {
            IEnumerable<operador> operadores = managerOperador.ObtenerTodos;
            comboOperadores.DataSource = operadores.Select(r => (r.IdOperador + "/" + r.Nombre)).ToList();
            //listTotalOperadores.DataSource = operadores.Select(r => (r.IdOperador + "/" + r.Nombre)).ToList();
            comboOperadores.Text = string.Empty;
        }

        private void cargarComboTipoDeGastos()
        {
            IEnumerable<tipogasto> tiposDeGastos = managerTiposDeGastos.ObtenerTodos;
            comboTipoGastos.DataSource = tiposDeGastos.Select(r => (r.IdTipoGasto + "/" + r.Concepto)).ToList();
            //comboTipoGastos2.Text = "Hola";
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

                string[] splitOperadores;
                splitOperadores = comboOperadores.Text.Split('/');
                int idOperador = int.Parse(splitOperadores.First());

                string[] splitStatus;
                splitStatus = comboStatus.Text.Split('/');
                int idStatus = int.Parse(splitStatus.First());

                string[] splitUnidades;
                splitUnidades = comboUnidades.Text.Split('/');
                int idUnidad = int.Parse(splitUnidades.First());

                if (accion == "agregar")
                {
                    try
                    {
                        viaje viajeNuevo = CrearViaje(idStatus, idRuta, idCliente, idOperador, idUnidad);
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
                            entidadAeditar.FechaInicioSci = DateTime.Parse(textDateInicioSci.Text); //dateTimeInicioSci.Value;
                            entidadAeditar.FechaInicioCliente = DateTime.Parse(textDateInicioCliente.Text); //dateTimeInicioCliente.Value;
                            entidadAeditar.FechaFinSci = DateTime.Parse(textDateFinSci.Text); //dateTimeFinSci.Value;
                            entidadAeditar.FechaFinCliente = DateTime.Parse(textDateFinCliente.Text); //dateTimeFinCliente.Value;
                            entidadAeditar.IdRuta = idRuta;
                            entidadAeditar.IdCliente = idCliente;
                            entidadAeditar.IdOperador = idOperador;
                            entidadAeditar.IdStatus = idStatus;
                            entidadAeditar.IdUnidad = idUnidad;

                            if (managerViajes.Actualizar(entidadAeditar))
                            {
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
                MessageBox.Show("Ha ocurrido un Error al intentar Guardar El viaje. " + ex.Message, "Error al ingresar el Viaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private viaje CrearViaje(int idStatus, int idRuta, int idCliente, int idOperador, int idUni)
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
                IdOperador = idOperador,
                IdUnidad = idUni
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

        private void comboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboStatus.Text == "6/En Planeación")
                habilitarComponentes(true);
            else
                habilitarComponentes(false);
        }

        private void habilitarComponentes(bool habilitar)
        {
            calendarSci.Enabled = habilitar;
            CalendarCliente.Enabled = habilitar;
            textDateInicioSci.Enabled = habilitar;
            textDateInicioCliente.Enabled = habilitar;
            textDateFinSci.Enabled = habilitar;
            textDateFinCliente.Enabled = habilitar;
            comboClientes.Enabled = habilitar;
            comboOperadores.Enabled = habilitar;
            comboRutas.Enabled = habilitar;
            textClaveViajeCliente.Enabled = habilitar;
            comboUnidades.Enabled = habilitar;
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            if (comboTipoGastos.Text != string.Empty)
            {
                try
                {
                    if (validarFechaDelGasto() == false)
                    {
                        MessageBox.Show("La fecha del Gasto esta fuera del rango de las fechas del Viaje de OPS.","Erro al ingresar el nuevo gasto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    string[] concepto;
                    string[] cadena = comboTipoGastos.Text.Split('/');
                    int idTipoGasto = int.Parse(cadena.First());
                    gasto nuevoGasto = new gasto();
                    nuevoGasto.IdTipoGasto = idTipoGasto;

                    if (tipoDeGasto == "Combustible")
                    {
                        //concepto = comboGasolinerias.Text.Split('/');
                        nuevoGasto.Concepto = comboGasolinerias.Text;
                    }
                    else
                    {
                        if (tipoDeGasto == "Casetas")
                        {
                            //concepto = comboCasetas.Text.Split('/');
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
                    nuevoGasto.IdViajeOps = entidadAeditar.IdViajeOps;
                    nuevoGasto.NumeroDePoliza = int.Parse(textPoliza.Text);
                    nuevoGasto.FolioFactura = textNumFactura.Text;
                    nuevoGasto.NumTicket = textTicket.Text;
                    nuevoGasto.FormaDePago = comboFormaPago.Text;

                    if (managerGastos.Insertar(nuevoGasto))
                    {
                        cargarTodosLosGastosDelViaje(entidadAeditar.IdViajeOps);
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
            nombreArchivoNuevoPdf = string.Empty;
            nombreArchivoNuevoXml = string.Empty;
        }

        private bool validarFechaDelGasto()
        {
            DateTime fechayHora = DateTime.Parse(textFechaDelGasto.Text);
            if (fechayHora < entidadAeditar.FechaFinSci && fechayHora >= entidadAeditar.FechaInicioSci)
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
                    catch (Exception ex) {
                        MessageBox.Show("XML Ha ocurrido un problema al intentar guardar el archivo. " + ex.Message, "Erro al subir el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: El directorio no existe.");
            }
        }

        private string getNuevoNombreDelGasto(string nombreArchivo)
        {
            string[] cadenas;
            DateTime fechaHora = DateTime.Now;
            Random r = new Random();
            string nombre = "V" + entidadAeditar.IdViajeOps.ToString() + "-" + fechaHora.Year.ToString() + fechaHora.Month.ToString() + fechaHora.Day.ToString();
            nombre += "-" + fechaHora.Hour.ToString() + fechaHora.Minute.ToString() + fechaHora.Second.ToString()+fechaHora.Millisecond.ToString() + "-" + r.Next(100,1000).ToString();

            cadenas = nombreArchivo.Split('.');
            nombre += "."+cadenas.Last();
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
            try
            {
                DateTime fechaInicio = DateTime.Parse(textFechaHoraInicialOperador.Text);
                DateTime fechaFinal = DateTime.Parse(textFechaHoraFinalOperador.Text);
                double resultado = (fechaFinal - fechaInicio).TotalHours;
                textTotalHoras.Text = resultado.ToString("N2");
                textCostoTotal.Text = (resultado * double.Parse(textCostoHoraOperador.Text)).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido calcular el costo por horas Laboradas. Los campos no pueden esta vacios." + ex.Message, "No se pudo calcular el sueldo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            cortesoperador nuevoCorte = new cortesoperador();
            try
            {
                nuevoCorte.FechaInicio = DateTime.Parse(textFechaHoraInicialOperador.Text);
                nuevoCorte.FechaFin = DateTime.Parse(textFechaHoraFinalOperador.Text);
                nuevoCorte.Costo = double.Parse(textCostoTotal.Text);
                nuevoCorte.IdViajeOps = entidadAeditar.IdViajeOps;
                if (managerCortes.Insertar(nuevoCorte))
                {
                    MessageBox.Show("Se ha ingresado un nuevo corte para este viaje operador.", "Dato Ingresado Correctamente.", MessageBoxButtons.OK, MessageBoxIcon.None);
                    cargarTodosLosCortesDelViaje(entidadAeditar.IdViajeOps);
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

        private void limpiarFormularioCortes()
        {
            textFechaHoraInicialOperador.Clear();
            textFechaHoraFinalOperador.Clear();
            textTotalHoras.Clear();
            textCostoTotal.Clear();
        }

        private void textFechaHoraInicialOperador_Leave(object sender, EventArgs e)
        {
            calcularMontoPorHorasOperador();
        }

        private void textFechaHoraFinalOperador_Leave(object sender, EventArgs e)
        {
            calcularMontoPorHorasOperador();
        }

        private void dgvGastos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        if (dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString() != string.Empty)
                        {
                            try { System.Diagnostics.Process.Start(@"\\Srvopssci\ops_sci\SCI\SISTEMA_SCI\COMPROBANTES\" + dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString()); }
                            catch { }
                        }
                        break;
                    case 5:
                        if (dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString() != string.Empty)
                        {
                            try { System.Diagnostics.Process.Start(@"\\Srvopssci\ops_sci\SCI\SISTEMA_SCI\COMPROBANTES\" + dgvGastos[e.ColumnIndex, e.RowIndex].Value.ToString()); }
                            catch { }
                        }
                        break;
                    default: break;
                }
            }
        }

        private void cargarTodasLasUnidades(int tipoDeUnidad)
        {
            IEnumerable<unidades> TodasLasUnidades = managerUnidades.BuscarPorTipoDeUnidad(tipoDeUnidad);
            //comboUnidades.DataSource = TodasLasUnidades.Select(r => (r.IdUnidad + "/" + r.Nombre + "/" + r.NumeroEconomico + "/" +r.Placas + "/" +r.IdTipoDeUnidad)).ToList();
            comboUnidades.DataSource = TodasLasUnidades.Select(r => (r.IdUnidad + "/" + r.Nombre)).ToList();
            //comboUnidades.Text = string.Empty;
        }

        private void cargarComboRutas()
        {
            IEnumerable<ruta> rutas = managerRuta.ObtenerTodos;
            //comboRutas.DataSource = rutas.Select(r => (r.IdRuta + "/" + r.Nombre + "/" + r.Costo + "/" + r.IdTipoDeUnidad)).ToList();
            comboRutas.DataSource = rutas.Select(r => (r.IdRuta + "/" + r.Nombre)).ToList();
        }

        private void comboRutas_TextChanged(object sender, EventArgs e)
        {
            if (comboRutas.Text != string.Empty)
            {
                string[] cadenaRutaSeleccionada = comboRutas.Text.Split('/');
                ruta rutaSeleccionada = managerRuta.BuscarPorId(cadenaRutaSeleccionada.First());
                labelNombreRuta.Text = rutaSeleccionada.Nombre;
                labelCostoRuta.Text = "$" + rutaSeleccionada.Costo.ToString();
                tipounidad tUnidad = managerTipoDeUnidad.BuscarPorId(rutaSeleccionada.IdTipoDeUnidad.ToString());
                labelTipoUnidad.Text = tUnidad.Descripcion;
                cargarTodasLasUnidades(tUnidad.IdTipoDeUnidad);
                comboUnidades.Text = string.Empty;
            }
            else
            {
                labelNombreRuta.Text = "--";
                labelCostoRuta.Text = "--";
                labelTipoUnidad.Text = "--";
            }
        }

        private void comboRutas_Click(object sender, EventArgs e)
        {
            /*cargarComboRutas();
            if (comboRutas.Text != string.Empty)
            {
                string[] cadena = comboRutas.Text.Split('/');
                labelNombreRuta.Text = cadena[1];
                labelCosto.Text = cadena[2];
                tipounidad tUnidad = managerTipoDeUnidad.BuscarPorId(cadena[3]);
                labelTipoUnidad.Text = tUnidad.Descripcion;
            }
            */
        }

        private void comboUnidades_TextChanged(object sender, EventArgs e)
        {
            if (comboUnidades.Text != string.Empty)
            {
                string[] cadenaUnidades = comboUnidades.Text.Split('/');
                unidades unidadSeleccionada = managerUnidades.BuscarPorId(cadenaUnidades.First());
                labelNombreUnidad.Text = unidadSeleccionada.Nombre;
                labelNumEco.Text = unidadSeleccionada.NumeroEconomico.ToString();
                labelPlacas.Text = unidadSeleccionada.Placas;
                labelCombustible.Text = unidadSeleccionada.TipoCombustible;
                //labelTipoUnidad
            }
            else
            {
                labelNombreUnidad.Text = "--";
                labelNumEco.Text = "--";
                labelPlacas.Text = "--";
                labelCombustible.Text = "--";
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
                cliente clienteSeleccionado = managerCliete.BuscarPorId(cadenaCliente.First());
                labelNombreCliente.Text = clienteSeleccionado.RazonSocial;
                labelTelCliente.Text = clienteSeleccionado.Telefono;
                labelRfcCliente.Text = clienteSeleccionado.Rfc;
            }
            else
            {
                labelNombreCliente.Text = "--";
                labelTelCliente.Text = "--";
                labelRfcCliente.Text = "--";
            }

        }

        private void comboOperadores_TextChanged(object sender, EventArgs e)
        {
            if (comboOperadores.Text != string.Empty)
            {
                string[] cadenaOperador = comboOperadores.Text.Split('/');
                operador opSeleccionado = managerOperador.BuscarPorId(cadenaOperador.First());
                labelNombreOperador.Text = opSeleccionado.Nombre;
                labelTelOperador.Text = opSeleccionado.Celular;
            }
            else
            {
                labelNombreOperador.Text = "--";
                labelTelOperador.Text = "--";
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
            //comboGasolinerias.DataSource = todasGasolinerias.Select(r => (r.IdGasolineria + "/" + r.Nombre)).ToList();
            comboGasolinerias.DataSource = todasGasolinerias.Select(r => (r.Nombre)).ToList();
            comboGasolinerias.Text = string.Empty;
        }

        private void cargarTodasLasCasetas()
        {
            IEnumerable<caseta> todasCasetas = managerCasetas.ObtenerTodos;
            //comboCasetas.DataSource = todasCasetas.Select(r => (r.IdCaseta + "/" + r.Nombre)).ToList();
            comboCasetas.DataSource = todasCasetas.Select(r => (r.Nombre)).ToList();
            comboCasetas.Text = string.Empty;
        }

        private void comboCasetas_TextChanged(object sender, EventArgs e)
        {
            textMontoGasto.Text = string.Empty;
            
            if (comboCasetas.Text != string.Empty)
            {
                //string[] cadenaCasetas = comboCasetas.Text.Split('/');
                caseta casetaN = managerCasetas.BuscarCasetaPorNombre(comboCasetas.Text);
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
                    gasto gastoSelect = managerGastos.BuscarPorId(idGastoSeleccionado.ToString());
                    if (managerGastos.Eliminar(idGastoSeleccionado))
                    {
                        MessageBox.Show("El gasto ha sido eliminado correctamente.", "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTodosLosGastosDelViaje(entidadAeditar.IdViajeOps);
                    }
                    else
                        MessageBox.Show("El gasto no se ha podido eliminar.", "Eliminar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void dgvGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaGastoSeleccionado = e.RowIndex;
                cargarDatosGastoAeditar();
            }
        }

        private void cargarDatosGastoAeditar()
        {
            string idGasto = dgvGastos["idGasto", filaGastoSeleccionado].Value.ToString();
            gasto gastoSeleccionado = managerGastos.BuscarPorId(idGasto);
            //cargarComboTipoDeGastos();
            tipogasto tipoGastoSeleccionado = managerTiposDeGastos.BuscarPorId(gastoSeleccionado.IdTipoGasto.ToString());
            comboTipoGastos.Text = tipoGastoSeleccionado.IdTipoGasto.ToString() + "/" + tipoGastoSeleccionado.Concepto;
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
            //textFechaDelGasto.Text = gastoSeleccionado.Fecha.ToString();
            textRutaPdf.Text = gastoSeleccionado.RutaPdf;
            textRutaXml.Text = gastoSeleccionado.RutaXml;
            textMontoGasto.Text = gastoSeleccionado.Costo.ToString();
            textPoliza.Text = gastoSeleccionado.NumeroDePoliza.ToString();
            textNumFactura.Text = gastoSeleccionado.FolioFactura;
            textTicket.Text = gastoSeleccionado.NumTicket;
            comboFormaPago.Text = gastoSeleccionado.FormaDePago;

            
        }

        private void listTotalOperadores_DoubleClick(object sender, EventArgs e)
        {
            string[] cadena = listTotalOperadores.SelectedItem.ToString().Split('/');
            DialogResult result = MessageBox.Show("¿Esta Seguro que de sea agregar este operador al Viaje?", "Agregar Operador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                operadoresenviaje opEnViaje = new operadoresenviaje { IdOperador= int.Parse(cadena.First()), idViajeOps=entidadAeditar.IdViajeOps};
                
                //Validamos si ya esta el Operadore asgnado al viaje
                operadoresenviaje opYaAgregado = managerOperadoresEnViaje.BuscarPorIdViajeOpsyOperador(entidadAeditar.IdViajeOps, opEnViaje.IdOperador);
                if (opYaAgregado == null)
                {
                    if (managerOperadoresEnViaje.Insertar(opEnViaje))
                    {
                        listOperadoresAsignados.Items.Clear();
                        cargarListaOperadoresAsignadosAlViaje();
                    }
                }
                else
                    MessageBox.Show("Lo sentimos el operador ya esta agregado.","Agregar Operador",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
        }
    }
}
