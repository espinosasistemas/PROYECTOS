using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI.INTERFAZ.UI
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FormOperadoresCombo());

            //Application.Run(new FormLogin());

            //Application.Run(new FormAgregarGasolineria("editar", 7));
            //Application.Run(new FormAgregarViaje(new usuario {NombreCompleto= "Usuario administrador", NombreUsuario = "root", Password = "Falomay@-2" }, "agregar",-1));
            //Application.Run(new FormAgregarViaje(new usuario { NombreCompleto = "Usuario administrador", NombreUsuario = "root", Password = "Falomay@-2" }, "editar", 262));

            Application.Run(new FormAgregarFactura(new usuario { NombreCompleto = "Usuario administrador", NombreUsuario = "root", Password = "Falomay@-2" }, "editar", 262));

            //Application.Run(new FormPrincipal(new usuario { NombreCompleto = "Usuario administrador", NombreUsuario = "root", Password = "Falomay@-2" }));
            //Application.Run(new FormAgregarViaje("editar", 13));
            //Application.Run(new FormAgregarCasetas("agregar", 1));
        }
    }
}
