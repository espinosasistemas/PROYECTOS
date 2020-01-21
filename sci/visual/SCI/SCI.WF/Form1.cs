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

namespace SCI.WF
{
    public partial class Form1 : Form
    {
        IUsuarioManager managerUser;
        public Form1()
        {
            InitializeComponent();
            managerUser = Tools.FabricManager.UsuarioManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*usuario nuevoUsuario = new usuario { NombreCompleto = "Juan Espinosa", NombreUsuario = "espinosa.sistemas", Password="123456"};
            if (managerUser.Insertar(nuevoUsuario)) MessageBox.Show("Se ha insertado el nuevo usuario");
            else MessageBox.Show("El usuario no se puedo insertar. Erro:" + managerUser.Error);*/
            usuario user=managerUser.Login("espinosa.sistemas", "123456");
            if (user != null) MessageBox.Show("Login Exitoso");
            else MessageBox.Show("No se pudo iniciar sesión. Error:" + managerUser.Error);
        }
    }
}
