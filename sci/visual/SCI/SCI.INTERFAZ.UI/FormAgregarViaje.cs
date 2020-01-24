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
        ruta entidadAeditar;

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
            /*if (accion == "editar")
            {
                entidadAeditar = managerRutas.BuscarPorId(idAEditar.ToString());
                unidades unidad = managerUnidades.BuscarPorId(entidadAeditar.IdUnidad.ToString());
                textNombre.Text = entidadAeditar.Nombre;
                textCosto.Text = entidadAeditar.Costo.ToString();
                comboUnidades.Text = unidad.IdUnidad + "/" + unidad.Nombre + "/" + unidad.NumeroEconomico;
                this.Text = "Actualizar los datos de la Ruta.";
            }*/
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
    }
}
