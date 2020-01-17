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
        IGenericRepository<log> logRepository;
        IGenericRepository<operador> operadorRepository;
        IGenericRepository<statusviaje> statusRepository;
        IGenericRepository<tipogasto> tipoGastoRepository;
        IGenericRepository<unidades> unidadesRepository;

        Random r;
        public UnitTestDAL()
        {
            r = new Random();
            usuarioRepository = new GenericRepository<usuario>(new UsuarioValidator(), false);
            clienteRepository = new GenericRepository<cliente>(new ClienteValidator());
            logRepository = new GenericRepository<log>(new LogValidator());
            operadorRepository = new GenericRepository<operador>(new OperadorValidator());
            statusRepository = new GenericRepository<statusviaje>(new StatusViajeValidator());
            tipoGastoRepository = new GenericRepository<tipogasto>(new TipoDeGastoValidator());
            unidadesRepository = new GenericRepository<unidades>(new UnidadesValidator());
        }

        [TestMethod]
        public void TestUsuario()
        {
            usuario u = CrearUsuario();
            int cantidadUsuarios = usuarioRepository.Read.Count();
            Assert.IsTrue(usuarioRepository.Create(u), usuarioRepository.Error);
            Assert.AreEqual(cantidadUsuarios + 1, usuarioRepository.Read.Count(), "No se inserto el registro.");
            usuario aModificar = usuarioRepository.Query(p => p.NombreUsuario == "juan@gmail.com").SingleOrDefault();
            aModificar.NombreCompleto = "Nombre Modificado";
            Assert.IsTrue(usuarioRepository.Update(aModificar), usuarioRepository.Error);
            usuario modificado = usuarioRepository.Query(p => p.NombreUsuario == "juan@gmail.com").SingleOrDefault();
            Assert.AreEqual("Nombre Modificado", modificado.NombreCompleto, "El nombre no se modifico.");
            //Assert.IsTrue(usuarioRepository.Delete("juan@gmail.com"), usuarioRepository.Error);
            //Assert.AreEqual(cantidadUsuarios, usuarioRepository.Read.Count(), "No se pudo eliminar el registro.");
            usuario aModificar2 = usuarioRepository.SearchById("juan@gmail.com");
            aModificar2.Password = "54321";
            //Assert.IsTrue(usuarioRepository.Update(aModificar), usuarioRepository.Error);
            List<usuario> usuarios = usuarioRepository.Read.ToList();
            foreach (var item in usuarios)
            {
                Assert.IsTrue(usuarioRepository.Delete(item.NombreUsuario), usuarioRepository.Error);
            }
        }

        [TestMethod]
        public void TestLog()
        {
            usuario usuarioNuevo = CrearUsuario();
            Assert.IsTrue(usuarioRepository.Create(usuarioNuevo), usuarioRepository.Error);
            log logNuevo = CrearLog(usuarioNuevo.NombreUsuario);
            int cantidadRegistros = logRepository.Read.Count();
            Assert.IsTrue(logRepository.Create(logNuevo), logRepository.Error);
            int idLogNuevo = logRepository.Read.Max(l => l.IdMovimiento);
            Assert.AreEqual(cantidadRegistros + 1, logRepository.Read.Count(), "No se inserto el log ya que las cantidades son diferentes.");
            log aModificar = logRepository.SearchById(idLogNuevo.ToString());
            aModificar.ModuloAfectado = "xxxx";
            Assert.IsTrue(logRepository.Update(aModificar), logRepository.Error);
            List<log> registros = logRepository.Read.ToList();
            foreach (var item in registros)
            {
                Assert.IsTrue(logRepository.Delete(item.IdMovimiento.ToString()), logRepository.Error);
            }
            Assert.AreEqual(0, logRepository.Read.Count());

            List<usuario> usuarios = usuarioRepository.Read.ToList();
            foreach (var item in usuarios)
            {
                Assert.IsTrue(usuarioRepository.Delete(item.NombreUsuario),usuarioRepository.Error);
            }

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

        [TestMethod]
        public void TestOperador()
        {
            operador op = CrearOperador();
            int CantidadOperadores = operadorRepository.Read.Count();
            Assert.IsTrue(operadorRepository.Create(op), operadorRepository.Error);
            int idOperador = operadorRepository.Read.Max(o => o.IdOperador);
            Assert.AreEqual(CantidadOperadores + 1, operadorRepository.Read.Count(), "No se pudo insertar el operador.");
            operador aModificar = operadorRepository.SearchById(idOperador.ToString());
            aModificar.Nombre = "Nombre Operador Modificado.";
            Assert.IsTrue(operadorRepository.Update(aModificar), operadorRepository.Error);
            List<operador> operadores = operadorRepository.Read.ToList();
            foreach (var item in operadores)
            {
                Assert.IsTrue(operadorRepository.Delete(item.IdOperador.ToString()), operadorRepository.Error);
            }
        }

        [TestMethod]
        public void TestStatusViaje()
        {
            statusviaje status = CrearStatus();
            int CantidadStatus = statusRepository.Read.Count();
            Assert.IsTrue(statusRepository.Create(status), statusRepository.Error);
            int idStatusInsertado = statusRepository.Read.Max(s=>s.IdStatus);
            Assert.AreEqual(CantidadStatus + 1, statusRepository.Read.Count(), "No se pudo insertar, las cantidades no son iguales.");
            statusviaje aModificar = statusRepository.SearchById(idStatusInsertado.ToString());
            aModificar.Nombre = "Entregado";
            Assert.IsTrue(statusRepository.Update(aModificar), statusRepository.Error);
            List<statusviaje> todosStatus = statusRepository.Read.ToList();
            foreach (var item in todosStatus)
            {
                Assert.IsTrue(statusRepository.Delete(item.IdStatus.ToString()), statusRepository.Error);
            }
        }

        [TestMethod]
        public void TestTipoGasto()
        {
            tipogasto gasto = CrearTipoGasto();
            int cantidadGastos = tipoGastoRepository.Read.Count();
            Assert.IsTrue(tipoGastoRepository.Create(gasto), tipoGastoRepository.Error);
            int idGasto = tipoGastoRepository.Read.Max(g => g.IdTipoGasto);
            Assert.AreEqual(cantidadGastos + 1, tipoGastoRepository.Read.Count(), "No se pudo insertar, las cantidades son diferentes");
            tipogasto aModificar = tipoGastoRepository.SearchById(idGasto.ToString());
            aModificar.Concepto = "GASOLINA";
            Assert.IsTrue(tipoGastoRepository.Update(aModificar), tipoGastoRepository.Error);
            List<tipogasto> gastos = tipoGastoRepository.Read.ToList();
            foreach (var item in gastos)
            {
                Assert.IsTrue(tipoGastoRepository.Delete(item.IdTipoGasto.ToString()), tipoGastoRepository.Error);
            }
            Assert.AreEqual(0, tipoGastoRepository.Read.Count(), "Toda´vía hay elementos");

        }

        [TestMethod]
        public void TestUnidades()
        {
            unidades u = CrearUnidades();
            int cantidadUnidades = unidadesRepository.Read.Count();
            Assert.IsTrue(unidadesRepository.Create(u), unidadesRepository.Error);
            Assert.AreEqual(cantidadUnidades + 1, unidadesRepository.Read.Count(),"No se pudo insertar, las cantidades no son las mismas.");
            int idUnidad = unidadesRepository.Read.Max(u1 => u1.IdUnidad);
            unidades aModificar = unidadesRepository.SearchById(idUnidad.ToString());
            aModificar.NumeroEconomico = 14;
            Assert.IsTrue(unidadesRepository.Update(aModificar), unidadesRepository.Error);
            List<unidades> totalUnidades = unidadesRepository.Read.ToList();
            foreach (var item in totalUnidades)
            {
                Assert.IsTrue(unidadesRepository.Delete(item.IdUnidad.ToString()), unidadesRepository.Error);
            }
            Assert.AreEqual(0, unidadesRepository.Read.Count(), "Sigue existiendo unidades");
        }

        private unidades CrearUnidades()
        {
            return new unidades
            {
                Nombre = "Tracto",
                NumeroEconomico = 30,
                Placas = "XYZ-24-65",
                NumeroSerie = "00025476E4AD45",
                TipoCombustible = "Gasolina"
            };
        }

        private tipogasto CrearTipoGasto()
        {
            return new tipogasto
            {
                Concepto = "Viáticos"
            };
        }

        private statusviaje CrearStatus()
        {
            return new statusviaje
            {
                Nombre = "En tránsito"
            };
        }

        private operador CrearOperador()
        {
            return new operador {
                Nombre = "Operador Juan",
                Apellidos = "Operador Apellido",
                FechaIngreso = DateTime.Now.AddDays(-10),
                Salarioporhora = 60.50,
                Direccion = "San Bernardo #20, Puebla Puebla."
            };
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
                NombreUsuario = "juan@gmail.com",
                Password = "12345",
                NombreCompleto = "JUAN ESPINOSA"
            };
        }

        private log CrearLog(string nombreUser)
        {
            return new log()
            {
                Accion = "Crear",
                NombreUsuario = nombreUser,
                Fecha = DateTime.Now,
                ModuloAfectado = "tabla de usuarios."
            };
        }
    }
}
