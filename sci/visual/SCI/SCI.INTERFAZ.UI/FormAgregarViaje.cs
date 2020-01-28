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

        statusviaje entidadStatus;
        ruta entidadRuta;
        cliente entidadCliente;
        operador entidadOperador;
        cortesoperador entidadCortes;

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
            
            if (accion == "editar")
            {
                textFechaGasto.Text = dateTimeFechaGasto.Value.ToString(); //Se inicializa la fecha del gasto
                entidadAeditar = managerViajes.BuscarPorId(idAEditar.ToString()); //Se carga los datos del Viaje a editar

                //Se cargan las entidades ligadas con el viaje SCi
                entidadStatus = managerStatus.BuscarPorId(entidadAeditar.IdStatus.ToString());
                entidadRuta = managerRuta.BuscarPorId(entidadAeditar.IdRuta.ToString());
                entidadCliente = managerCliete.BuscarPorId(entidadAeditar.IdCliente.ToString());
                entidadOperador = managerOperador.BuscarPorId(entidadAeditar.IdOperador.ToString());

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
                comboRutas.Text = entidadRuta.IdRuta.ToString() + "/" + entidadRuta.Nombre + "/" + entidadRuta.Costo.ToString();
                comboClientes.Text = entidadCliente.IdCliente.ToString() + "/" + entidadCliente.RazonSocial + "/" + entidadCliente.Telefono;
                comboOperadores.Text = entidadOperador.IdOperador.ToString() + "/" + entidadOperador.Nombre + "/" + entidadOperador.Salarioporhora.ToString();
                comboStatus.Text = entidadStatus.IdStatus.ToString() + "/" + entidadStatus.Nombre;
                comboStatus.Enabled = true;

                //Carga todos los gastos relacionados con el Viaje en el dgv Del TabControl = Gastos
                cargarTodosLosGastosDelViaje(entidadAeditar.IdViajeOps);

                //Datos del operador y cortes que se han hecho, tabControl = Cortes
                textCostoHoraOperador.Text = entidadOperador.Salarioporhora.ToString();
                cargarTodosLosCortesDelViaje(entidadAeditar.IdViajeOps);

                this.Text = "Actualizar los datos del Viaje.";
            }
            else
            {
                //datos iniciales la orden es Agregar nuevo Viaje
                statusviaje estado = managerStatus.BuscaPorStatus("En Planeación");
                comboStatus.Text = estado.IdStatus + "/" + estado.Nombre;
                groupGastos.Enabled = false;
                groupCortesOPerador.Enabled = false;
                labelTotalDeGastos.Visible = false;
                labelTotalGastos.Visible = false;
                labelSaldoTotalCortes.Visible = false;
                labelSueldoCortes.Visible = false;

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
            comboOperadores.DataSource = operadores.Select(r => (r.IdOperador + "/" + r.Nombre + "/" + r.Salarioporhora)).ToList();
            comboOperadores.Text = string.Empty;
        }

        private void cargarComboTipoDeGastos()
        {
            IEnumerable<tipogasto> tiposDeGastos = managerTiposDeGastos.ObtenerTodos;
            comboTipoGastos.DataSource = tiposDeGastos.Select(r => (r.IdTipoGasto + "/" + r.Concepto)).ToList();
            comboTipoGastos.Text = string.Empty;
        }

        private void cargarComboClientes()
        {
            IEnumerable<cliente> cliente = managerCliete.ObtenerTodos;
            comboClientes.DataSource = cliente.Select(r => (r.IdCliente + "/" + r.RazonSocial + "/" + r.Telefono)).ToList();
            comboClientes.Text = string.Empty;
        }

        private void cargarComboRutas()
        {
            IEnumerable<ruta> rutas = managerRuta.ObtenerTodos;
            comboRutas.DataSource = rutas.Select(r => (r.IdRuta + "/" + r.Nombre + "/" + r.Costo)).ToList();
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
                            entidadAeditar.FechaInicioSci = DateTime.Parse(textDateInicioSci.Text); //dateTimeInicioSci.Value;
                            entidadAeditar.FechaInicioCliente = DateTime.Parse(textDateInicioCliente.Text); //dateTimeInicioCliente.Value;
                            entidadAeditar.FechaFinSci = DateTime.Parse(textDateFinSci.Text); //dateTimeFinSci.Value;
                            entidadAeditar.FechaFinCliente = DateTime.Parse(textDateFinCliente.Text); //dateTimeFinCliente.Value;
                            entidadAeditar.IdRuta = idRuta;
                            entidadAeditar.IdCliente = idCliente;
                            entidadAeditar.IdOperador = idOperador;
                            entidadAeditar.IdStatus = idStatus;

                            if (managerViajes.Actualizar(entidadAeditar))
                            {
                                resultado = "Se ha actualizado correctamente los datos del Viaje.";
                                MessageBox.Show("Se ha actualizado correctamente los datos del viaje.", "Actualización de Viaje", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void comboStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboStatus.Text == "6/En Planeación")
                habilitarComponentes(true);
            else
                habilitarComponentes(false);
        }

        private void habilitarComponentes(bool habilitar)
        {
            if (habilitar == false)
            {
                calendarSci.Enabled = false;
                CalendarCliente.Enabled = false;
                textDateInicioSci.Enabled = false;
                textDateInicioCliente.Enabled = false;
                textDateFinSci.Enabled = false;
                textDateFinCliente.Enabled = false;
                comboClientes.Enabled = false;
                comboOperadores.Enabled = false;
                comboRutas.Enabled = false;
                textClaveViajeCliente.Enabled = false;
            }
            else
            {
                calendarSci.Enabled = true;
                CalendarCliente.Enabled = true;
                textDateInicioSci.Enabled = true;
                textDateInicioCliente.Enabled = true;
                textDateFinSci.Enabled = true;
                textDateFinCliente.Enabled = true;
                comboClientes.Enabled = true;
                comboOperadores.Enabled = true;
                comboRutas.Enabled = true;
                textClaveViajeCliente.Enabled = true;
            }
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
                    
                    string[] cadena = comboTipoGastos.Text.Split('/');
                    int idTipoGasto = int.Parse(cadena.First());
                    gasto nuevoGasto = new gasto();
                    nuevoGasto.IdTipoGasto = idTipoGasto;
                    nuevoGasto.Concepto = textConceptoGasto.Text;
                    nuevoGasto.Costo = double.Parse(textMontoGasto.Text);
                    subirFicherosPdfyXml();

                    nuevoGasto.RutaPdf = nombreArchivoNuevoPdf;
                    nuevoGasto.RutaXml = nombreArchivoNuevoXml;

                    nuevoGasto.Fecha = DateTime.Parse(textFechaGasto.Text);
                    nuevoGasto.IdViajeOps = entidadAeditar.IdViajeOps;

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
            DateTime fechayHora = DateTime.Parse(textFechaGasto.Text);
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
            textFechaGasto.Text = dateTimeFechaGasto.Value.ToString();
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
    }
}
