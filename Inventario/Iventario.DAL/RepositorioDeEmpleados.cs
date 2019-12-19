using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        List<Empleado> IRepositorio<Empleado>.Read => throw new NotImplementedException();

        bool IRepositorio<Empleado>.Create(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        bool IRepositorio<Empleado>.Delete(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        bool IRepositorio<Empleado>.Update(Empleado entidad)
        {
            throw new NotImplementedException();
        }
    }
}
