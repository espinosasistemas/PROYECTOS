﻿using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventario.BIZ
{
    public class ManejadorMateriales:IManejadorMateriales 
    {
        IRepositorio<Material> repositorio;
        public ManejadorMateriales(IRepositorio<Material> repo)
        {
            repositorio = repo;
        }

        public List<Material> Listar => repositorio.Read;

        public bool Agregar(Material entidad)
        {
            return repositorio.Create(entidad);
        }

        public Material BuscarPorID(string id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public List<Material> MaterialesDeCategoria(string categoria)
        {
            return Listar.Where(e => e.Categoria == categoria).ToList();
        }

        public bool Modificar(Material entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
