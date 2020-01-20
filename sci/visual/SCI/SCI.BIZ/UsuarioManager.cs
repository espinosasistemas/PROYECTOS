using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class UsuarioManager : GenericManager<usuario>, IUsuarioManager
    {
        public UsuarioManager(IGenericRepository<usuario> repositorio) : base(repositorio)
        {
        }

        public usuario Login(string nombreUsuario, string password)
        {
            return repository.Query(u => u.NombreUsuario == nombreUsuario && u.Password == password).SingleOrDefault();
        }
    }
}
