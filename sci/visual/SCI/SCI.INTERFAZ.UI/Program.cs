﻿using System;
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
            Application.Run(new FormPrincipal());
            //Application.Run(new FormAgregarGasolineria("editar", 7));
            //Application.Run(new FormAgregarViaje("agregar",-1));
            //Application.Run(new FormAgregarViaje("editar", 13));
            //Application.Run(new FormAgregarCasetas("agregar", 1));
        }
    }
}
