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
        IGastoManager managerGastos;

        operador opSeleccionado;
        usuario user;
        string nombreOperador = string.Empty;
        int idViaje = 0;
        string resultado = string.Empty;
        int filaSeleccionada = -1;

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
            managerGastos = Tools.FabricManager.GastoManager();

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
                IEnumerable<deposito> depositosPorOperador = managerDeposito.BuscarPorIdViajeyOperador(idViaje, opSeleccionado.IdOperador);
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
                    Fecha = DateTime.Now,
                    Nota = textNota.Text
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
                            textReferencia.Text = string.Empty;
                            textNota.Text = string.Empty;
                        }
                    }
                }
                else
                    MessageBox.Show(managerDeposito.Error, "Error al ingresar el nuevo Deposito.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el nuevo Deposito.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvDepositos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        private void btnEliminarDeposito_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DialogResult Resultado = MessageBox.Show("¿Esta seguro de eliminar el deposito Seleccionado?", "Eliminar Deposito.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == DialogResult.Yes)
                {
                    if (existenGastosAsociados())
                    {
                        MessageBox.Show("No se puede eliminar el deposito porque tiene gastos asociados, es necesario primero eliminar los gastos.", "Eliminar Deposito.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //Como no existen gastos asociados al operador en el viaje entonces podemos eliminar el Deposito y decrementar el saldo actual.
                        int idDepositoAEliminar = int.Parse(dgvDepositos["idDeposito", filaSeleccionada].Value.ToString());
                        double montoDelDeposito = double.Parse(dgvDepositos["monto", filaSeleccionada].Value.ToString());
                        if (managerDeposito.Eliminar(idDepositoAEliminar))
                        {
                            operadoresenviaje opEnViaje = managerOperadorEnViaje.BuscarPorIdViajeOpsyOperador(idViaje, opSeleccionado.IdOperador);

                            log registro = new log
                            {
                                Accion = "eliminar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "deposito-id:" + idDepositoAEliminar
                            };
                            managerLog.Insertar(registro);

                            opEnViaje.SaldoActual = opEnViaje.SaldoActual - montoDelDeposito;
                            managerOperadorEnViaje.Actualizar(opEnViaje);
                            cargarTodosLosDepositos();
                        }
                    }
                }
            }
        }

        private bool existenGastosAsociados()
        {
            IEnumerable<gasto> todosLosGastos = managerGastos.BuscarPorIdViajeyOperador(idViaje, opSeleccionado.IdOperador);
            if (todosLosGastos.Count(g=>g.IdOperador==opSeleccionado.IdOperador && g.IdViajeSci==idViaje) == 0)
                return false;
            return true;
        }
    }
}
