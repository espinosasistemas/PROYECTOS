using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class OperadorManager : GenericManager<operador>, IOperadorManager
    {
        public OperadorManager(IGenericRepository<operador> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<operador> BuscarPorNombre(string nombre)
        {
            return repository.Query(op => op.Nombre.ToLower().Contains(nombre.ToLower()));
        }

        public operador BuscarPorNombreExacto(string nombreCompleto)
        {
            return repository.Query(op => (op.Nombre + " " + op.Apellidos) == nombreCompleto).SingleOrDefault();
        }
    }
}
