using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using SCI.COMMON.Validadores;
using SCI.DAL;

namespace SCI.Tests
{
    [TestClass]
    public class UnitTestDAL
    {
        IGenericRepository<usuario> usuarioRepository;
        Random r;
        public UnitTestDAL()
        {
            r = new Random();
            usuarioRepository = new GenericRepository<usuario>(new UsuarioValidator(), false);
        }

        [TestMethod]
        public void TestUsuario()
        {
            usuario u = CrearUsuario();
            int cantidadUsuarios = usuarioRepository.Read.Count();
            Assert.IsTrue(usuarioRepository.Create(u), usuarioRepository.Error);
            Assert.AreEqual(cantidadUsuarios + 1, usuarioRepository.Read.Count(), "No se inserto el registro.");
            usuario aModificar = usuarioRepository.Query(p => p.NombreUsuario == "juanespinosa360@gmail.com").SingleOrDefault();
            aModificar.NombreCompleto = "Nombre Modificado";

            Assert.IsTrue(usuarioRepository.Update(aModificar), usuarioRepository.Error);

            usuario modificado = usuarioRepository.Query(p => p.NombreUsuario == "juanespinosa360@gmail.com").SingleOrDefault();
            Assert.AreEqual("Nombre Modificado", modificado.NombreCompleto, "El nombre no se modifico.");
            Assert.IsTrue(usuarioRepository.Delete("juanespinosa360@gmail.com"), usuarioRepository.Error);
            //Assert.AreEqual(cantidadUsuarios, usuarioRepository.Read.Count(), "No se pudo eliminar el registro.");
            
        }

        private usuario CrearUsuario()
        {
            
            return new usuario
            {
                NombreUsuario = "juanespinosa" + r.Next(DateTime.Now.Second) + "@gmail.com",
                Password = "12345",
                NombreCompleto = "JUAN ESPINOSA"
            };
        }
    }
}
