﻿using SCI.COMMON.Entidades;
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
    public partial class FormAgregarCliente : Form
    {
        IClienteManager managerCliente;
        ILogManager managerLog;
        string resultado = string.Empty;
        string accion = string.Empty;
        int idAEditar = -1;
        cliente entidadAeditar;
        usuario user;

        public string Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormAgregarCliente(usuario u,string evento, int id)
        {
            InitializeComponent();
            managerCliente = Tools.FabricManager.ClienteManager();
            managerLog = Tools.FabricManager.LogManager();
            accion = evento;
            idAEditar = id;
            user = u;
        }

        private cliente CrearCliente()
        {
            return new cliente
            {
                RazonSocial = textRazonSocial.Text,
                Rfc = textRfc.Text,
                Giro = textGiro.Text,
                Telefono = textTelefono.Text,
                Correo = textCorreo.Text,
                NombreContacto = textContacto.Text,
                Direccion = textDireccion.Text
            };
        }

        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {
            if (accion == "editar")
            {
                entidadAeditar = managerCliente.BuscarPorId(idAEditar);
                textRazonSocial.Text = entidadAeditar.RazonSocial;
                textRfc.Text = entidadAeditar.Rfc;
                textGiro.Text = entidadAeditar.Giro;
                textTelefono.Text = entidadAeditar.Telefono;
                textCorreo.Text = entidadAeditar.Correo;
                textContacto.Text = entidadAeditar.NombreContacto;
                textDireccion.Text = entidadAeditar.Direccion;
                this.Text = "Actualizar los datos del Cliente.";
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (accion == "agregar")
            {
                try
                {
                    cliente clienteNuevo = CrearCliente();
                    if (managerCliente.Insertar(clienteNuevo))
                    {
                        cliente lastCliente = managerCliente.BuscarUltimoIngresado();
                        log registro = new log
                        {
                            Accion = "agregar",
                            NombreUsuario = user.NombreUsuario,
                            Fecha = DateTime.Now,
                            ModuloAfectado = "cliente-id:" + lastCliente.IdCliente
                        };
                        managerLog.Insertar(registro);
                        resultado = "Se ha agregado correctamente el nuevo Cliente.";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(managerCliente.Error, "Error al ingresar la nueva Unidad.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar al nuevo cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (accion == "editar")
                {
                    try
                    {
                        entidadAeditar.RazonSocial = textRazonSocial.Text;
                        entidadAeditar.Rfc = textRfc.Text;
                        entidadAeditar.Giro = textGiro.Text;
                        entidadAeditar.Telefono = textTelefono.Text;
                        entidadAeditar.Correo = textCorreo.Text;
                        entidadAeditar.NombreContacto = textContacto.Text;
                        entidadAeditar.Direccion = textDireccion.Text;

                        if (managerCliente.Actualizar(entidadAeditar))
                        {
                            resultado = "Se ha actualizado correctamente los datos del Cliente.";
                            log registro = new log
                            {
                                Accion = "editar",
                                NombreUsuario = user.NombreUsuario,
                                Fecha = DateTime.Now,
                                ModuloAfectado = "cliente-id:" + entidadAeditar.IdCliente
                            };
                            managerLog.Insertar(registro);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(managerCliente.Error, "Error al actualizar los datos del Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Revisa por favor que los campos tengan el tipo de dato correcto.", "Error al ingresar el nuevo Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textRfc_Leave(object sender, EventArgs e)
        {
            textRfc.Text = textRfc.Text.Trim();
            textRfc.Text = textRfc.Text.ToUpper();
        }
    }
}
