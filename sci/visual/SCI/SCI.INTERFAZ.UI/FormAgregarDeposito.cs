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
    public partial class FormAgregarDeposito : Form
    {
        IUsuarioManager managerUsuario;
        IOperadorManager managerOperador;
        IDepositoManager managerDeposito;
        ILogManager managerLog;
        IOperadoresEnViajeManager managerOperadorEnViaje;

        operador opSeleccionado;
        usuario user;
        string nombreOperador = string.Empty;
        int idViaje = 0;
        string resultado = string.Empty;
        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }
        public FormAgregarDeposito(usuario u, string op, int idV)
        {
            InitializeComponent();
            managerUsuario = Tools.FabricManager.UsuarioManager();
            managerOperador = Tools.FabricManager.OperadorManager();
            managerDeposito = Tools.FabricManager.DepositoManager();
            managerLog = Tools.FabricManager.LogManager();
            managerOperadorEnViaje = Tools.FabricManager.OperadoresEnViajeManager();
            user = u;
            nombreOperador = op;
            idViaje = idV;
        }

        private void FormAgregarDeposito_Load(object sender, EventArgs e)
        {
            labelNombreOperador.Text = nombreOperador;
            opSeleccionado = managerOperador.BuscarPorNombreExacto(nombreOperador);
            cargarTodosLosDepositos();
        }

        private void cargarTodosLosDepositos()
        {
            //dgvDepositos.Rows.Clear();
            if (opSeleccionado != null)
            {
                IEnumerable<deposito> depositosPorOperador = managerDeposito.BuscarDepositosPorVIaje(idViaje, opSeleccionado.IdOperador);
                if (depositosPorOperador != null)
                {
                    dgvDepositos.DataSource = depositosPorOperador.ToArray();
                    dgvDepositos.Columns["idDeposito"].Visible = false;
                    dgvDepositos.Columns["idOperador"].Visible = false;
                }
            }
        }

        private void btnAgregarDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                deposito depositoNuevo = new deposito
                {
                    IdOperador = opSeleccionado.IdOperador,
                    IdViajeSci = idViaje,
                    Monto = double.Parse(textMonto.Text),
                    Tipo = comboTipoDeposito.Text,
                    Referencia = textReferencia.Text,
                    Fecha = DateTime.Now
                };

                if (managerDeposito.Insertar(depositoNuevo))
                {
                    deposito lastDeposito = managerDeposito.BuscarUltimoIngresado();
                    log registro = new log
                    {
                        Accion = "agregar",
                        NombreUsuario = user.NombreUsuario,
                        Fecha = DateTime.Now,
                        ModuloAfectado = "deposito-id:" + lastDeposito.IdDeposito
                    };
                    managerLog.Insertar(registro);

                    //Se tiene que actualizar el monto total de saldo del operador en el viaje
                    operadoresenviaje opEnElViaje = managerOperadorEnViaje.BuscarPorIdViajeOpsyOperador(idViaje, opSeleccionado.IdOperador);
                    if (opEnElViaje != null)
                    {
                        opEnElViaje.SaldoActual += depositoNuevo.Monto;
                        if (managerOperadorEnViaje.Actualizar(opEnElViaje))
                        {
                            resultado = "Se ha registrado correctamente el nuevo abono.";
                            //MessageBox.Show("Se han ingresado correctamente el nuevo Deposito.", "Actualización de Depósitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarTodosLosDepositos();
                            textMonto.Clear();
                            comboTipoDeposito.Text = string.Empty;
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el nuevo Deposito.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
