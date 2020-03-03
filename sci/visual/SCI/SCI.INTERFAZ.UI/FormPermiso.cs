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
    public partial class FormPermiso : Form
    {
        bool resultado = false;
        IUsuarioManager managerUsuario;

        public bool Valor
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public FormPermiso()
        {
            InitializeComponent();
            managerUsuario = Tools.FabricManager.UsuarioManager();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            usuario nuevoUsuario = managerUsuario.Login(textUsuario.Text, textPassword.Text);
            if (nuevoUsuario != null && nuevoUsuario.NombreUsuario=="root")
                resultado = true;
            else
                resultado = false;

            this.Close();
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
                btnAutorizar_Click(sender, e);
        }
    }
}
