using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeMateriales : IRepositorio<Material>
    {
        public List<Material> Read => throw new NotImplementedException();

        public bool Create(Material entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Material entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Material entidad)
        {
            throw new NotImplementedException();
        }
    }
}
