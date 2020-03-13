using FluentValidation;
using FluentValidation.Results;
using MySql.Data.MySqlClient;
using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace SCI.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDTO
    {
        private DBMySQL db;
        private bool idEsAutonumerico;
        private AbstractValidator<T> validator;

        public GenericRepository(AbstractValidator<T> validator, bool idEsAutonumerico = true)
        {
            this.validator = validator;
            this.idEsAutonumerico = idEsAutonumerico;
            //db = new DBMySQL(); //la conecta automaticamente por el constructor
            
        }


        public string Error { get; private set; }

        public IEnumerable<T> Read
        {
            get
            {
                try
                {
                    db = new DBMySQL();
                    
                    string sql = string.Format("SELECT * FROM {0};", typeof(T).Name);
                    MySqlDataReader r = (MySqlDataReader)db.Consulta(sql);
                    List<T> datos = new List<T>();
                    var campos = typeof(T).GetProperties();
                    T dato;
                    Type Ttypo = typeof(T);
                    while (r.Read())
                    {
                        dato = (T)Activator.CreateInstance(typeof(T));
                        for (int i = 0; i < campos.Length; i++)
                        {
                            PropertyInfo prop = Ttypo.GetProperty(campos[i].Name);
                            prop.SetValue(dato, r[i]);
                        }
                        datos.Add(dato);
                    }
                    r.Close();                    
                    Error = "";
                    db.CerrarConexion();
                    return datos;

                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
        }

        public bool Create(T entidad)
        {
            ValidationResult resultadoDeValidacion = validator.Validate(entidad);
            if (resultadoDeValidacion.IsValid)
            {
                string sql1 = "INSERT INTO " + typeof(T).Name + " (";
                string sql2 = ") VALUES (";
                var campos = typeof(T).GetProperties();
                T dato = (T)Activator.CreateInstance(typeof(T));
                Type Ttypo = typeof(T);
                for (int i = 0; i < campos.Length; i++)
                {
                    if (idEsAutonumerico && i == 0)
                    {
                        continue;
                    }
                    sql1 += " " + campos[i].Name;
                    var propiedad = Ttypo.GetProperty(campos[i].Name);
                    var valor = propiedad.GetValue(entidad);
                    switch (propiedad.PropertyType.Name)
                    {
                        case "String":
                            sql2 += "'" + valor + "'";
                            break;
                        case "DateTime":
                            DateTime v = (DateTime)valor;
                            sql2 += string.Format($"'{v.Year}-{v.Month}-{v.Day} {v.Hour}:{v.Minute}:00'");
                            break;
                        
                        default:
                            sql2 += " " + valor;
                            break;
                    }
                    if (i != campos.Length - 1)
                    {
                        sql1 += " ,";
                        sql2 += " ,";
                    }
                }
                return EjecutarComando(sql1 + sql2 + ");");
            }
            else
            {
                Error = "Error de validación: ";
                foreach (var item in resultadoDeValidacion.Errors)
                {
                    Error += item.ErrorMessage + ". ";
                }
                return false;
            }
        }

        private bool EjecutarComando(string sql)
        {
            db = new DBMySQL();
            if (db.Comando(sql))
            {
                Error = "";
                db.CerrarConexion();
                return true;
            }
            else
            {
                Error = db.Error;
                db.CerrarConexion();
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var campos = typeof(T).GetProperties();
                Type Ttypo = typeof(T);
                string sql = "DELETE FROM " + typeof(T).Name + " WHERE " + campos[0].Name + "=";
                switch (Ttypo.GetProperty(campos[0].Name).PropertyType.Name)
                {
                    case "String":
                        sql += "'" + id + "'";
                        break;
                    default:
                        sql += " " + id;
                        break;
                }
                if (db.Comando(sql + ";"))
                {
                    Error = "";
                    return true;
                }
                else
                {
                    Error = db.Error;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            return Read.Where(predicado.Compile());
        }

        public T SearchById(int id)
        {
            try
            {
                db = new DBMySQL();
                var campos = typeof(T).GetProperties();
                Type Ttypo = typeof(T);
                string sql = "SELECT * FROM " + typeof(T).Name + " WHERE " + campos[0].Name + "=";
                switch (Ttypo.GetProperty(campos[0].Name).PropertyType.Name)
                {
                    case "String":
                        sql += "'" + id + "'";
                        break;
                    default:
                        sql += " " + id;
                        break;
                }
                MySqlDataReader r = (MySqlDataReader)db.Consulta(sql);
                T dato = (T)Activator.CreateInstance(typeof(T));
                int j = 0;
                while (r.Read())
                {
                    dato = (T)Activator.CreateInstance(typeof(T));
                    for (int i = 0; i < campos.Length; i++)
                    {
                        PropertyInfo prop = Ttypo.GetProperty(campos[i].Name);
                        prop.SetValue(dato, r[i]);
                    }
                    j++;
                }
                r.Close();
                db.CerrarConexion();
                if (j > 0)
                {
                    Error = "";
                    return dato;
                }
                else
                {
                    Error = "Id no existente...";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public bool Update(T entidad)
        {
            ValidationResult resultadoDeValidacion = validator.Validate(entidad);
            if (resultadoDeValidacion.IsValid)
            {
                try
                {
                    //db = new DBMySQL();
                    string sql1 = "UPDATE " + typeof(T).Name + " SET ";
                    string sql2 = " WHERE ";
                    string sql = "";
                    var campos = typeof(T).GetProperties();
                    T dato = (T)Activator.CreateInstance(typeof(T));
                    Type Ttypo = typeof(T);
                    for (int i = 0; i < campos.Length; i++)
                    {
                        var propiedad = Ttypo.GetProperty(campos[i].Name);
                        var valor = propiedad.GetValue(entidad);
                        sql += propiedad.Name + "=";
                        switch (propiedad.PropertyType.Name)
                        {
                            case "String":
                                sql += "'" + valor + "'";
                                break;
                            case "DateTime":
                                DateTime v = (DateTime)valor;
                                sql += string.Format($"'{v.Year}-{v.Month}-{v.Day} {v.Hour}:{v.Minute}:00'");
                                break;
                            default:
                                sql += " " + valor;
                                break;
                        }
                        if (i == 0)
                        {
                            sql2 += sql;
                        }
                        if (i != campos.Length - 1)
                        {
                            sql += " ,";
                        }
                        sql1 += sql;
                        sql = "";
                    }

                    if (db.Comando(sql1 + sql2))
                    {
                        Error = "";
                        return true;
                    }
                    else
                    {
                        Error = db.Error;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return false;
                }
            }
            else
            {
                Error = "Error de validación: ";
                foreach (var item in resultadoDeValidacion.Errors)
                {
                    Error += item.ErrorMessage + ". ";
                }
                return false;
            }
            
        }

    }
}
