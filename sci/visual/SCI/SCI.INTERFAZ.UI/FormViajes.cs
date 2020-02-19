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
    public partial class FormViajes : Form
    {
        IViajeManager managerViajes;
        IStatusViajeManager managerStatus;
        IRutaManager managerRuta;
        IClienteManager managerCliente;
        IUnidadesManager managerUnidades;
        IGastoManager managerGasto;
        ICortesOperadorManager managerCortes;
        ILogManager managerLog;

        bool primeraCarga = true;
        int filaSeleccionada = -1;
        usuario user;

        public FormViajes(usuario u)
        {
            InitializeComponent();
            managerViajes = Tools.FabricManager.ViajeManager();
            managerStatus = Tools.FabricManager.StatusViajeManager();
            managerRuta = Tools.FabricManager.RutaManager();
            managerCliente = Tools.FabricManager.ClienteManager();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerGasto = Tools.FabricManager.GastoManager();
            managerCortes = Tools.FabricManager.CortesOperadorManager();
            managerLog = Tools.FabricManager.LogManager();
            user = u;
        }

        

        public void CargarTodosLosViajes(string status)
        {
            IEnumerable<viaje> TodosViajes;
            dgvViajes.Columns.Clear();

            if (status == string.Empty)
                TodosViajes = managerViajes.ObtenerTodos;
            else
            {
                string[] cadenaStatus = status.Split('/');
                TodosViajes = managerViajes.BuscarViajesPorStatus(int.Parse(cadenaStatus.First())).ToList();
            }

            dgvViajes.DataSource = TodosViajes.OrderByDescending(s=>s.IdViajeSci).ToArray();

            if (dgvViajes.Rows.Count > 0)
            {
                

                dgvViajes.Columns["idStatus"].Visible = false;
                dgvViajes.Columns["idRuta"].Visible = false;
                //dgvViajes.Columns["idCliente"].Visible = false;
                dgvViajes.Columns["idUnidad"].Visible = false;

                
                dgvViajes.Columns.Add("Gastos", "Gastos");
                dgvViajes.Columns.Add("Cortes", "Cortes");

                dgvViajes.Columns.Add("Economico", "Economico");
                dgvViajes.Columns.Add("Status", "Status");
                dgvViajes.Columns.Add("Ruta", "Ruta");
                dgvViajes.Columns.Add("Cliente", "Cliente");
                
                IEnumerable<gasto> todoLosGastos;
                IEnumerable<cortesoperador> todosLosCortes;
                IEnumerable<cliente> todosLosClientes  = managerCliente.ObtenerTodos; ;

                IEnumerable<statusviaje> todosLosStatus = managerStatus.ObtenerTodos;
                IEnumerable<ruta> todasLasRutas = managerRuta.ObtenerTodos;
                
                IEnumerable<unidades> todasLasUnidades = managerUnidades.ObtenerTodos;
                cliente clienteSeleccionado;

                int idStatusViajeSci = 0;
                int idRutaViaje = 0;
                int idClienteViaje = 0;
                int idUnidadViaje = 0;

                for (int i=0;i<dgvViajes.Rows.Count;i++)
                {
                    idStatusViajeSci = int.Parse(dgvViajes["idStatus", i].Value.ToString());
                    dgvViajes["Status", i].Value = (from s in todosLosStatus where s.IdStatus == idStatusViajeSci select s.Nombre).SingleOrDefault();

                    idRutaViaje = int.Parse(dgvViajes["idRuta", i].Value.ToString());
                    dgvViajes["Ruta", i].Value = (from r in todasLasRutas where r.IdRuta == idRutaViaje select r.Nombre).SingleOrDefault();

                    idClienteViaje = int.Parse((from r in todasLasRutas where r.IdRuta == idRutaViaje select r.IdCliente).SingleOrDefault().ToString());
                    clienteSeleccionado = managerCliente.BuscarPorId(idClienteViaje.ToString());
                    dgvViajes["Cliente", i].Value = clienteSeleccionado.RazonSocial;

                    idUnidadViaje = int.Parse(dgvViajes["idUnidad", i].Value.ToString());
                    dgvViajes["Economico", i].Value = (from u in todasLasUnidades where u.IdUnidad == idUnidadViaje select u.NumeroEconomico).SingleOrDefault();

                    todoLosGastos = managerGasto.BuscarPorIdViajeOps(int.Parse(dgvViajes["idViajeSci", i].Value.ToString()));
                    dgvViajes["Gastos", i].Value = "$" + todoLosGastos.Sum(g => g.Costo).ToString();

                    todosLosCortes = managerCortes.BuscarCortesPorIdViaje(int.Parse(dgvViajes["idViajeSci", i].Value.ToString()));
                    dgvViajes["Cortes", i].Value = "$" + todosLosCortes.Sum(g => g.Costo).ToString();

                    
                }
                
                mostrarLabelStatus("Se han cargado todos los viajes dados de alta.", true);
                filaSeleccionada = 0;

                dgvViajes.AllowUserToOrderColumns = true;
            }
            else
            {
                mostrarLabelStatus("Por el momento no se tienen viajes registradas.", false);
                filaSeleccionada = -1;
            }
        }

        private void mostrarLabelStatus(string mensaje, bool color)
        {
            panelResultado.Visible = true;
            if (mensaje == string.Empty)
                mensaje = "Sin Resultado.";
            labelResultado.Text = mensaje;
            if (color == true) panelResultado.BackColor = Color.FromArgb(76, 175, 80);
            else panelResultado.BackColor = Color.FromArgb(255, 87, 34);
        }

        private void btnBuscarTodosViajes_Click(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
            CargarTodosLosViajes(string.Empty);
            
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
            FormAgregarViaje fm = new FormAgregarViaje(user,"agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                //CargarTodosLosViajes(comboStatus.Text);
                CargarTodosLosViajes(btnStatus.Text);
                mostrarLabelStatus(fm.Valor, true);
            }
        }

        private void FormViajes_Load(object sender, EventArgs e)
        {
            CargarCamboStatus();
            primeraCarga = false;
        }

        private void CargarCamboStatus()
        {
            string statuInicial = string.Empty;
            IEnumerable <statusviaje> StatusViaje = managerStatus.ObtenerTodos;
            listBoxStatus.DataSource = StatusViaje.Select(r => (r.IdStatus + "/" + r.Nombre)).ToList();
            for (int i = 0; i < listBoxStatus.Items.Count; i++)
            {
                if (listBoxStatus.Items[i].ToString().Contains("nsito"))
                {
                    statuInicial = listBoxStatus.Items[i].ToString();
                    break;
                }
            }
            btnStatus.Text = statuInicial;
        }

        private void btnEditarViaje_Click(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
            if (filaSeleccionada != -1)
            {
                if (dgvViajes["idStatus", filaSeleccionada].Value.ToString() != "5")
                {
                    FormAgregarViaje fm = new FormAgregarViaje(user, "editar", int.Parse(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString()));
                    DialogResult DialogForm = fm.ShowDialog();
                    if (fm.Valor != string.Empty)
                    {
                        CargarTodosLosViajes(btnStatus.Text);
                        mostrarLabelStatus(fm.Valor, true);
                    }
                }
                else
                {
                    FormPermiso fp = new FormPermiso();
                    DialogResult DialogForm2 = fp.ShowDialog();

                    if (fp.Valor == true)
                    {
                        FormAgregarViaje fm = new FormAgregarViaje(user, "editar", int.Parse(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString()));
                        DialogResult DialogForm = fm.ShowDialog();
                        if (fm.Valor != string.Empty)
                        {
                            CargarTodosLosViajes(btnStatus.Text);
                            mostrarLabelStatus(fm.Valor, true);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            listBoxStatus.Visible = false;
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
            DialogResult dialogEliminar = new DialogResult();
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvViajes["idViajeCliente", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar el viaje del Cliente: {nombre}?", "Eliminar Viaje.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogEliminar == DialogResult.Yes)
                {
                    try
                    {
                        if (managerViajes.Eliminar(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString()))
                        {
                            log registro = new log
                            {
                                Accion = "eliminar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "viaje-id:" + dgvViajes["idViajeSci", filaSeleccionada].Value.ToString()
                            };
                            managerLog.Insertar(registro);

                            // CargarTodosLosViajes(comboStatus.Text);
                            CargarTodosLosViajes(btnStatus.Text);
                            mostrarLabelStatus("Se ha eliminado Correctamente el Viaje del cliente. " + nombre, true);
                        }
                        else
                            mostrarLabelStatus("No se ha podido Eliminar el viaje. " + managerViajes.Error, false);

                    }
                    catch (Exception ex)
                    {
                        mostrarLabelStatus("No se ha podido Eliminar el Viaje. " + ex.Message, false);
                    }
                }

            }
        }

        private void FormViajes_Shown(object sender, EventArgs e)
        {
            CargarTodosLosViajes(btnStatus.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
            btnStatus.Text = listBoxStatus.Text;
            if (primeraCarga == false)
                CargarTodosLosViajes(btnStatus.Text);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (listBoxStatus.Visible == true)
                listBoxStatus.Visible = false;
            else
                listBoxStatus.Visible = true;
        }

        private void dgvViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listBoxStatus.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
        }

        private void dgvViajes_Click(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBoxStatus.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            listBoxStatus.Visible = false;
        }
    }
}
