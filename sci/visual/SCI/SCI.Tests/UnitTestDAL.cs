using System;
using System.Collections.Generic;
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
        IGenericRepository<cliente> clienteRepository;

        Random r;
        public UnitTestDAL()
        {
            r = new Random();
            usuarioRepository = new GenericRepository<usuario>(new UsuarioValidator(), false);
            clienteRepository = new GenericRepository<cliente>(new ClienteValidator(), false);
        }


        [TestMethod]
        public void TestUsuario()
        {
            /*usuario u = CrearUsuario();
            int cantidadUsuarios = usuarioRepository.Read.Count();
            Assert.IsTrue(usuarioRepository.Create(u), usuarioRepository.Error);
            Assert.AreEqual(cantidadUsuarios + 1, usuarioRepository.Read.Count(), "No se inserto el registro.");
            usuario aModificar = usuarioRepository.Query(p => p.NombreUsuario == "juanespinosa360@gmail.com").SingleOrDefault();
            aModificar.NombreCompleto = "Nombre Modificado";

            Assert.IsTrue(usuarioRepository.Update(aModificar), usuarioRepository.Error);
            
            //usuario modificado = usuarioRepository.Query(p => p.NombreUsuario == "juanespinosa11@gmail.com").SingleOrDefault();
            //Assert.AreEqual("Nombre Modificado", modificado.NombreCompleto, "El nombre no se modifico.");
            //Assert.IsTrue(usuarioRepository.Delete("juanespinosa360@gmail.com"), usuarioRepository.Error);
            //Assert.AreEqual(cantidadUsuarios, usuarioRepository.Read.Count(), "No se pudo eliminar el registro.");
            //usuario aModificar = usuarioRepository.SearchById("juanespinosa11@gmail.com");
            //aModificar.Password = "54321";
            //Assert.IsTrue(usuarioRepository.Update(aModificar), usuarioRepository.Error);
            List<usuario> usuarios = usuarioRepository.Read.ToList();
            foreach (var item in usuarios)
            {
                Assert.IsTrue(usuarioRepository.Delete(item.NombreUsuario), usuarioRepository.Error);
            }
            */

        }

        [TestMethod]
        public void TestClient()
        {
            
            cliente c = CrearCliente();
            int cantidadClientes = clienteRepository.Read.Count();
            Assert.IsTrue(clienteRepository.Create(c), clienteRepository.Error);
            Assert.AreEqual(cantidadClientes + 1, clienteRepository.Read.Count(), "No coinciden el total de los clientes.");
            int idClienteInsertado = clienteRepository.Read.Max(c1 => c1.IdCliente);
            cliente aModificar = clienteRepository.SearchById(idClienteInsertado.ToString());
            aModificar.RazonSocial = "Nueva razón social.";
            Assert.IsTrue(clienteRepository.Update(aModificar),clienteRepository.Error);            
            Assert.IsTrue(clienteRepository.Delete("1"), clienteRepository.Error);
            List<cliente> clientesTotales = clienteRepository.Read.ToList();
            foreach (var item in clientesTotales)
            {
                Assert.IsTrue(clienteRepository.Delete(item.IdCliente.ToString()),clienteRepository.Error);

            }
           
        }
        
        private cliente CrearCliente()
        {
            return new cliente
            {
                RazonSocial = "JUAN ESPINOSA",
                Rfc = "EISJ841218",
                Giro = "Transportes",
                Telefono = "2221846700",
                Correo = "juan@gmail.com",
                NombreContacto = "Juan Espinosa",
                Observaciones ="Ninguna observación"
            };
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
