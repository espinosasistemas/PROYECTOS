using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    public interface IUsuarioManager : IGenericManager<usuario>
    {
        /// <summary>
        /// Verifica si las credenciales son válidas para el usuario.
        /// </summary>
        /// <param name="nombreUsuario">Nombre de usuario </param>
        /// <param name="password">Contraseña del usuario</param>
        /// <returns>Si las credenciales son correctas, regresa el usuario completo, de otro modo regreas null</returns>
        usuario Login(string nombreUsuario, string password);
    }
}
