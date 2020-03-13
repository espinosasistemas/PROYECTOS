using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.COMMON.Interfaces
{
    /// <summary>
    /// Proporciona el método estandarizado para el acceso a tablas. Todos los métodos que vamos a usar de acuerdo al negocio, quiero traer todas las facturas de més de noviembre.
    /// </summary>
    /// <typeparam name="T">Tipo de Entidad de la cual se implementa el Manager</typeparam>
    public interface IGenericManager<T> where T : BaseDTO
    {

        /// <summary>
        /// Propociona el error proporcionado después de una operación
        /// </summary>
        string Error { get; }

        /// <summary>
        /// Inserta una entidad en la Tabla
        /// </summary>
        /// <param name="entidad">Entidad a insertar</param>
        /// <returns>La confirmación de la inserción</returns>
        bool Insertar(T entidad);

        /// <summary>
        /// Obtiene todos los registros de la tabla.
        /// </summary>
        IEnumerable<T> ObtenerTodos { get; }

        /// <summary>
        /// Actualiza un registro en la tabla en base a su propiedad ID
        /// </summary>
        /// <param name="entidad">Entidad ya modificada, el id debe de existir en la tabla</param>
        /// <returns></returns>
        bool Actualizar(T entidad);

        /// <summary>
        /// Eliminar una entidad en base al id Propocionado
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar</param>
        /// <returns>Confirmación de la eliminación</returns>
        bool Eliminar(int id);

        /// <summary>
        /// Obtiene un elemento de acuerdo a su id.
        /// </summary>
        /// <param name="id">Id del elemento a obtener</param>
        /// <returns>La entidad completa correspodiente al id proporcionado</returns>
        T BuscarPorId(int id);

        T BuscarUltimoIngresado();

    }
}
