﻿using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventario.BIZ
{
    public class ManejadorVales : IManejadorVales
    {
        IRepositorio<Vale> repositorio;

        public ManejadorVales(IRepositorio<Vale> repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<Vale> Listar => repositorio.Read;

        public bool Agregar(Vale entidad)
        {
            return repositorio.Create(entidad);
        }

        public Vale BuscarPorID(string id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Vale entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
