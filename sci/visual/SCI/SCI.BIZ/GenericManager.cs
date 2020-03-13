using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public abstract class GenericManager<T> : IGenericManager<T> where T : BaseDTO
    {
        internal IGenericRepository<T> repository;
        public GenericManager(IGenericRepository<T> repositorio)
        {
            repository = repositorio;
        }

        

        public string Error {
            get
            {
                return repository.Error;
            }
        }

        public IEnumerable<T> ObtenerTodos
        {
            get
            {
                return repository.Read;
            }
        }

        public bool Actualizar(T entidad)
        {
            return repository.Update(entidad);
        }

        public T BuscarPorId(int id)
        {
            return repository.SearchById(id);
        }

        public T BuscarUltimoIngresado()
        {
            return repository.Read.Last();
        }

        public bool Eliminar(int id)
        {
            return repository.Delete(id);
        }

        public bool Insertar(T entidad)
        {
            return repository.Create(entidad);
        }
    }
}
