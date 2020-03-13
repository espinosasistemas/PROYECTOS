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
    public partial class FormAgregarUnidad : Form
    {
        IUnidadesManager managerUnidades;
        ITipoDeUnidadManager managerTipoDeUnidades;
        ILogManager managerLog;

        string resultado = string.Empty;
        string accion = string.Empty;
        int idUnidadAEditar = 0;
        int idTipoDeUnidad = 0;
        unidades unidadAeditar;
        usuario user;
        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarUnidad(usuario u,string evento, int id)
        {
            InitializeComponent();
            managerUnidades = Tools.FabricManager.UnidadManager();
            managerTipoDeUnidades = Tools.FabricManager.TipoDeUnidadesManager();
            managerLog = Tools.FabricManager.LogManager();
            accion = evento;
            idUnidadAEditar = id;
            user = u;
        }

        private void FormAgregarUnidad_Load(object sender, EventArgs e)
        {
            cargarTiposDeUnidades();
            if (accion == "editar")
            {
                unidadAeditar = managerUnidades.BuscarPorId(idUnidadAEditar);
                textNombreUnidad.Text = unidadAeditar.Nombre;
                textNumEco.Text = unidadAeditar.NumeroEconomico.ToString();
                textPlacas.Text = unidadAeditar.Placas;
                textNumSerie.Text = unidadAeditar.NumeroSerie;
                textPolizaSeguro.Text = unidadAeditar.PolizaSeguro;
                dateVencimientoSeguro.Value = unidadAeditar.FechaVencimientoSeguro;
                comboTipoCombustible.Text = unidadAeditar.TipoCombustible;

                tipounidad tUnidad = managerTipoDeUnidades.BuscarPorId(unidadAeditar.IdTipoDeUnidad);
                idTipoDeUnidad = tUnidad.IdTipoDeUnidad;
                comboTipoDeUnidad.Text = tUnidad.IdTipoDeUnidad.ToString() + "/" + tUnidad.Descripcion;
                this.Text = "Actualizar los datos de la Unidad.";
            }
        }

        private void cargarTiposDeUnidades()
        {
            IEnumerable<tipounidad> tiposDeUnidades = managerTipoDeUnidades.ObtenerTodos;
            comboTipoDeUnidad.DataSource = tiposDeUnidades.Select(u => (u.IdTipoDeUnidad + "/ " + u.Descripcion)).ToList();
        }

        private unidades CrearUnidad()
        {
            return new unidades
            {
                Nombre = textNombreUnidad.Text,
                NumeroEconomico = int.Parse(textNumEco.Text),
                Placas = textPlacas.Text,
                NumeroSerie = textNumSerie.Text,
                PolizaSeguro = textPolizaSeguro.Text,
                FechaVencimientoSeguro = dateVencimientoSeguro.Value,
                TipoCombustible = comboTipoCombustible.Text,
                IdTipoDeUnidad = idTipoDeUnidad
            };
        }

        private bool validarNumeroEconomico(int num_econ)
        {
            unidades UnidadAValidar = managerUnidades.BuscarPorNumEco(num_econ);
            if (UnidadAValidar != null)
            {
                
                //textNumEco.Focus();
                return false;
            }
            return true;
        }

        private void btnCrearUnidad_Click(object sender, EventArgs e)
        {
            string[] cadena = comboTipoDeUnidad.Text.Split('/');
            idTipoDeUnidad = int.Parse(cadena.First());

            int num_econ = 0;
            try { num_econ = int.Parse(textNumEco.Text.Trim()); }
            catch { num_econ = -1; }

            if (accion == "agregar")
            {
                try
                {

                    if (validarNumeroEconomico(num_econ))
                    {
                        unidades nuevaUnidad = CrearUnidad();
                        if (managerUnidades.Insertar(nuevaUnidad))
                        {
                            resultado = "Se ha agregado correctamente la nueva unidad.";
                            unidades lastUnidad = managerUnidades.BuscarUltimoIngresado();
                            log registro = new log
                            {
                                Accion = "agregar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "unidades-id:" + lastUnidad.IdUnidad
                            };
                            managerLog.Insertar(registro);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerUnidades.Error, "Error al ingresar la nueva Unidad.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una unidad con ese mismo número económico.", "Error al ingresar la unidad.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        

                        if (unidadAeditar.NumeroEconomico != num_econ)
                        {
                            if (validarNumeroEconomico(num_econ))
                            {
                                unidadAeditar.NumeroEconomico = num_econ;
                            }
                            else
                            {
                                MessageBox.Show("Ya existe una unidad con ese mismo número económico.", "Error al ingresar la unidad.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            
                        }
                        unidadAeditar.Nombre = textNombreUnidad.Text;
                        unidadAeditar.Placas = textPlacas.Text;
                        unidadAeditar.NumeroSerie = textNumSerie.Text;
                        unidadAeditar.PolizaSeguro = textPolizaSeguro.Text;
                        unidadAeditar.FechaVencimientoSeguro = dateVencimientoSeguro.Value;
                        unidadAeditar.TipoCombustible = comboTipoCombustible.Text;
                        unidadAeditar.IdTipoDeUnidad = idTipoDeUnidad;


                        if (managerUnidades.Actualizar(unidadAeditar))
                                {
                                    resultado = "Se han actualizado correctamente los datos de la unidad.";
                                    log registro = new log
                                    {
                                        Accion = "editar",
                                        NombreUsuario = user.NombreUsuario,
                                        Fecha = DateTime.Now,
                                        ModuloAfectado = "unidades-id:" + unidadAeditar.IdUnidad
                                    };
                                    managerLog.Insertar(registro);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(managerUnidades.Error, "Error al actualizar los datos de la unidad.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar la nueva Unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
    }
}
