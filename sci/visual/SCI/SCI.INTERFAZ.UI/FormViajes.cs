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
        IOperadoresEnViajeManager managerOperadorEnViaje;
        IOperadorManager managerOperador;
        ICobroAdicionalManager managerCobrosAdicionales;

        bool primeraCarga = true;
        int filaSeleccionada = -1;
        usuario user;
        private Form activeForm = null;

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
            managerOperadorEnViaje = Tools.FabricManager.OperadoresEnViajeManager();
            managerOperador = Tools.FabricManager.OperadorManager();
            managerCobrosAdicionales = Tools.FabricManager.CobrosAdicionalManager();

            user = u;
        }

        private void openDashBoardForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(childForm);
            groupBox1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //MessageBox.Show(childForm.DialogResult.ToString());
        }

        public void CargarTodosLosViajes(string status)
        {
            IEnumerable<viaje> TodosViajes;
            int idViajeSci = 0;
            dgvViajes.Columns.Clear();

            if (status == string.Empty)
            {
                TodosViajes = managerViajes.ObtenerTodos.Where(v=>v.IdStatus!=5);
            }
            else
            {
                string[] cadenaStatus = status.Split('/');
                TodosViajes = managerViajes.BuscarViajesPorStatus(int.Parse(cadenaStatus.First())).ToList();
            }

            dgvViajes.DataSource = TodosViajes.OrderByDescending(s=>s.IdViajeSci).ToArray();

            dgvViajes.Columns["idStatus"].Visible = false;
            dgvViajes.Columns["idRuta"].Visible = false;
            dgvViajes.Columns["idViajeCliente"].Visible = false;
            dgvViajes.Columns["idUnidad"].Visible = false;
            dgvViajes.Columns["FechaFin"].Visible = false;

            dgvViajes.Columns.Add("Cobros", "Cobros");
            dgvViajes.Columns.Add("Gastos", "Gastos");
            dgvViajes.Columns.Add("Cortes", "Cortes");
            dgvViajes.Columns.Add("Economico", "Economico");
            dgvViajes.Columns.Add("Status", "Status");
            dgvViajes.Columns.Add("Ruta", "Ruta");
            dgvViajes.Columns.Add("Cliente", "Cliente");
            dgvViajes.Columns.Add("Operador", "Operador");

            if (dgvViajes.Rows.Count > 0)
            {
                IEnumerable<cobrosadicionales> todosLosCobrosAdicionales; 
                IEnumerable<gasto> todoLosGastos;
                IEnumerable<cortesoperador> todosLosCortes;
                IEnumerable<cliente> todosLosClientes  = managerCliente.ObtenerTodos;
                IEnumerable<operadoresenviaje> operadoresEnViaje = managerOperadorEnViaje.ObtenerTodos;
                IEnumerable<operador> todosLosOperadores = managerOperador.ObtenerTodos;
                

                int idOpMenorEnViaje;
                //operador opSeleccionado;
                int posicion = -1;
                string nombreOP = string.Empty;
                string apellidosOP = string.Empty;

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
                    idViajeSci = int.Parse(dgvViajes["idViajeSci", i].Value.ToString());

                    idStatusViajeSci = int.Parse(dgvViajes["idStatus", i].Value.ToString());
                    dgvViajes["Status", i].Value = (from s in todosLosStatus where s.IdStatus == idStatusViajeSci select s.Nombre).SingleOrDefault();

                    idRutaViaje = int.Parse(dgvViajes["idRuta", i].Value.ToString());
                    dgvViajes["Ruta", i].Value = (from r in todasLasRutas where r.IdRuta == idRutaViaje select r.Nombre).SingleOrDefault();

                    idClienteViaje = int.Parse((from r in todasLasRutas where r.IdRuta == idRutaViaje select r.IdCliente).SingleOrDefault().ToString());
                    clienteSeleccionado = managerCliente.BuscarPorId(idClienteViaje.ToString());
                    dgvViajes["Cliente", i].Value = clienteSeleccionado.RazonSocial;

                    idUnidadViaje = int.Parse(dgvViajes["idUnidad", i].Value.ToString());
                    dgvViajes["Economico", i].Value = (from u in todasLasUnidades where u.IdUnidad == idUnidadViaje select u.NumeroEconomico).SingleOrDefault();

                    todoLosGastos = managerGasto.BuscarPorIdViajeOps(idViajeSci);
                    dgvViajes["Gastos", i].Value = string.Format("{0:C2}", todoLosGastos.Sum(g => g.Costo));

                    todosLosCortes = managerCortes.BuscarCortesPorIdViaje(idViajeSci);
                    dgvViajes["Cortes", i].Value = string.Format("{0:C2}", todosLosCortes.Sum(g => g.Costo));

                    todosLosCobrosAdicionales = managerCobrosAdicionales.BuscarCobrosPorViaje(idViajeSci);
                    dgvViajes["Cobros", i].Value = string.Format("{0:C2}", todosLosCobrosAdicionales.Sum(g => g.Monto));

                    try
                    {
                        posicion = (from s in operadoresEnViaje where s.IdViajeSci == idViajeSci select s.Posicion).Min();
                        idOpMenorEnViaje = (from s in operadoresEnViaje where s.IdViajeSci == idViajeSci && s.Posicion == posicion select s.IdOperador).SingleOrDefault();
                        nombreOP = (from s in todosLosOperadores where s.IdOperador == idOpMenorEnViaje select s.Nombre + " " + s.Apellidos).SingleOrDefault();
                        dgvViajes["Operador", i].Value = nombreOP;//opSeleccionado.Nombre + " " + opSeleccionado.Apellidos;

                    }
                    catch { dgvViajes["Operador", i].Value = "Sin Operador Asignado"; }
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
            dgvViajes.Columns["idViajeSci"].DisplayIndex = 0;
            dgvViajes.Columns["fechaInicio"].DisplayIndex = 1;
            dgvViajes.Columns["Cliente"].DisplayIndex = 2;
            dgvViajes.Columns["Status"].DisplayIndex = 3;
            dgvViajes.Columns["Ruta"].DisplayIndex = 4;
            dgvViajes.Columns["Economico"].DisplayIndex = 5;
            dgvViajes.Columns["Operador"].DisplayIndex = 6;
            dgvViajes.Columns["Gastos"].DisplayIndex = 7;
            dgvViajes.Columns["Cortes"].DisplayIndex = 8;
            dgvViajes.Columns["Cobros"].DisplayIndex = 9;

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
            /*listBoxStatus.Visible = false;
            FormAgregarViaje fm = new FormAgregarViaje(user,"agregar", -1);
            DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                //CargarTodosLosViajes(comboStatus.Text);
                CargarTodosLosViajes(btnStatus.Text);
                mostrarLabelStatus(fm.Valor, true);
            }*/
            listBoxStatus.Visible = false;
            openDashBoardForm(new FormAgregarViaje(user, "agregar", -1));
            /*DialogResult DialogForm = fm.ShowDialog();
            if (fm.Valor != string.Empty)
            {
                //CargarTodosLosViajes(comboStatus.Text);
                CargarTodosLosViajes(btnStatus.Text);
                mostrarLabelStatus(fm.Valor, true);
            }*/
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
            if (StatusViaje != null)
            {
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
        }

        private void btnEditarViaje_Click(object sender, EventArgs e)
        {
            /*listBoxStatus.Visible = false;
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
                        fm.Close();
                    
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
                

            }*/
            
            listBoxStatus.Visible = false;
            if (filaSeleccionada != -1)
            {
                if (dgvViajes["idStatus", filaSeleccionada].Value.ToString() != "5")
                {
                    openDashBoardForm(new FormAgregarViaje(user, "editar", int.Parse(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString())));
                   
                }
                else
                {
                    FormPermiso fp = new FormPermiso();
                    DialogResult DialogForm2 = fp.ShowDialog();

                    if (fp.Valor == true)
                    {
                        openDashBoardForm(new FormAgregarViaje(user, "editar", int.Parse(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString())));
                        
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
                string idViaje = dgvViajes["idViajeSci", filaSeleccionada].Value.ToString();
                dialogEliminar = MessageBox.Show($"¿Esta seguro de eliminar el viaje: {idViaje}?", "Eliminar Viaje.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                            CargarTodosLosViajes("");
                            mostrarLabelStatus("Se ha eliminado Correctamente el Viaje: . " + idViaje, true);
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
            CargarTodosLosViajes("");
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

        private void dgvViajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;
                listBoxStatus.Visible = false;
                if (filaSeleccionada != -1)
                {
                    if (dgvViajes["idStatus", filaSeleccionada].Value.ToString() != "5")
                    {
                        openDashBoardForm(new FormAgregarViaje(user, "editar", int.Parse(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString())));

                    }
                    else
                    {
                        FormPermiso fp = new FormPermiso();
                        DialogResult DialogForm2 = fp.ShowDialog();

                        if (fp.Valor == true)
                        {
                            openDashBoardForm(new FormAgregarViaje(user, "editar", int.Parse(dgvViajes["idViajeSci", filaSeleccionada].Value.ToString())));

                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña son incorrectos para poder editar el viaje cerrado.", "No se pudo editar viaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
        
    }
}
