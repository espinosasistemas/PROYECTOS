using SCI.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SCI.COMMON.Interfaces
{/*Nos va a permitir crear las 4 operaciones básicas*/
 /*Al ser genérica va a permitir cualquiera de las entidades (T) heredadas de BaseDTO */
 /*Una interface define QUE VOY A HACER, NO EL COMO*/

    /// <summary>
    /// Propociona los métodos básicos (CRUD), de acceso a una talba de bd.
    /// </summary>
    /// <typeparam name="T">Tipo de Entidad (clase) a la que se refiere una tabla</typeparam>
    public interface IGenericRepository<T> where T : BaseDTO
    {
        /// <summary>
        /// propociona información sobre el Error ocurrido en alguna de las operaciones
        /// </summary>
        string Error { get; }

        /*CRUD=> Create (insert), Read (select), Update (Update), Delete (delete)*/

        /// <summary>
        /// Inserta una Entidad en la Tabla
        /// </summary>
        /// <param name="entidad">Entidad a insertar</param>
        /// <returns>Confirmación de la inserción</returns>
        bool Create(T entidad);

        /// <summary>
        /// Obtiene todos los registros de la tabla
        /// </summary>
        IEnumerable<T> Read { get; }

        /// <summary>
        /// Actualiza un registro en la tabla en Base a la propiedad Id
        /// </summary>
        /// <param name="entidad">Entidad ya modificada, el Id debe de existir en la tabla para modificarse</param>
        /// <returns>Confirmación de la actualización</returns>
        bool Update(T entidad);

        /// <summary>
        /// Elimina una entidad en la base de datos de acuerdo al id relacionado
        /// </summary>
        /// <param name="id">Id de la Entidad a Eliminar</param>
        /// <returns>Confirmación de Eliminación</returns>
        bool Delete(string id);

        //Query -> Realizar consultas de acuerdo a la tabla, mediante expresiones lambda
        //Consulta entorno a objetos no a sql

        /// <summary>
        /// Realiza una consulta de acuerdo a la tabla
        /// </summary>
        /// <param name="predicado">Expresión Lambda que define la consulta</param>
        /// <returns>Conjunto de Entidades que cumplen con la consulta</returns>
        IEnumerable<T> Query(Expression<Func<T, bool>> predicado);

        /// <summary>
        /// Obtener una Entidad en base a su Id
        /// </summary>
        /// <param name="id">Id de la Entidad a obtener</param>
        /// <returns>La entidad completa que le corresponde el Id propocionado</returns>
        T SearchById(string id);

        
        //producto ObtenUltimo();
    }
}
