﻿using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventario.DAL
{
    class RepositorioDeVales : IRepositorio<Vale>
    {
        private string DBName = "Inventario.db";
        private string TableName = "Vales";

        public List<Vale> Read
        {
            get
            {
                List<Vale> datos = new List<Vale>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Vale>(TableName).FindAll().ToList();
                }
                return datos;
            }
        }

        public bool Create(Vale entidad)
        {
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Vale>(TableName);
                    colection.Insert(entidad);
                }
                return true;

            }
            catch (Exception) { return false; }
        }

        public bool Delete(string id)
        {
            try
            {
                int r;
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Vale>(TableName);
                    r = colection.Delete(e => e.Id == id);
                }
                return r > 0;
            }

            catch (Exception) { return false; }
        }

        public bool Update(Vale entidadModificada)
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var colection = db.GetCollection<Vale>(TableName);
                    colection.Update(entidadModificada);
                }
                return true;
            }

            catch (Exception) { return false; }
        }
    }
}
