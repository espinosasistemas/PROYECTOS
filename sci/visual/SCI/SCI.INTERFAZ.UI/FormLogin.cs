﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;

namespace SCI.INTERFAZ.UI
{
    public partial class FormLogin : Form
    {
        IUsuarioManager managerUsuario;
        public FormLogin()
        {
            InitializeComponent();
            managerUsuario = Tools.FabricManager.UsuarioManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            usuario user = managerUsuario.Login(textUsuario.Text, textPassword.Text);
            if (user != null)
            {
                FormPrincipal fp = new FormPrincipal(user);
                //FormPrincipal fp = new FormPrincipal();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o password son incorrectos.","Inicio de sesión.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
                btnLogin_Click(sender, e);
        }
    }
}
