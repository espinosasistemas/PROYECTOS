using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeVales : IRepositorio<Vale>
    {
        public List<Vale> Read => throw new NotImplementedException();

        public bool Create(Vale entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Vale entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Vale entidad)
        {
            throw new NotImplementedException();
        }
    }
}
