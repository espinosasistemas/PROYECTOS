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
        IGenericRepository<ruta> rutaRepository;
        IGenericRepository<viaje> viajeRepository;
        IGenericRepository<gasto> gastoRepository;
        IGenericRepository<cortesoperador> cortesRepository;

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
            rutaRepository = new GenericRepository<ruta>(new RutaValidator());
            viajeRepository = new GenericRepository<viaje>(new ViajeValidator());
            gastoRepository = new GenericRepository<gasto>(new GastoValidator());
            cortesRepository = new GenericRepository<cortesoperador>(new CortesOperadorValidator());
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

        [TestMethod]
        public void TestRuta()
        {
            unidades unidad = CrearUnidades();
            Assert.IsTrue(unidadesRepository.Create(unidad), unidadesRepository.Error);
            int idUnidad = unidadesRepository.Read.Max(u=>u.IdUnidad);
            int cantidadRutas = rutaRepository.Read.Count();
            ruta nuevaRuta = CrearRuta(idUnidad);
            Assert.IsTrue(rutaRepository.Create(nuevaRuta), rutaRepository.Error);
            Assert.AreEqual(cantidadRutas + 1, rutaRepository.Read.Count(), "La cantidad de las rutas no son iguales");
            int idRuta = rutaRepository.Read.Max(r => r.IdRuta);
            ruta aModificar = rutaRepository.SearchById(idRuta.ToString());
            aModificar.Nombre = "Nombre de la ruta modificada";
            Assert.IsTrue(rutaRepository.Update(aModificar), rutaRepository.Error);
            List<ruta> rutas = rutaRepository.Read.ToList();
            foreach (var item in rutas)
            {
                Assert.IsTrue(rutaRepository.Delete(item.IdRuta.ToString()), rutaRepository.Error);
            }
            Assert.IsTrue(unidadesRepository.Delete(idUnidad.ToString()), unidadesRepository.Error);
            Assert.AreEqual(0, rutaRepository.Read.Count(), "Todavía existen rutas en la bd.");
            Assert.AreEqual(0, unidadesRepository.Read.Count(), "Todavía existen unidades en la bd.");

        }

        [TestMethod]
        public void TestViaje()
        {
            statusviaje status = CrearStatus();
            Assert.IsTrue(statusRepository.Create(status), statusRepository.Error);
            int idStatus = statusRepository.Read.Max(s => s.IdStatus);

            unidades unidad = CrearUnidades();
            Assert.IsTrue(unidadesRepository.Create(unidad), unidadesRepository.Error);
            int idUnidad = unidadesRepository.Read.Max(u => u.IdUnidad);

            ruta rutaViaje = CrearRuta(idUnidad);
            Assert.IsTrue(rutaRepository.Create(rutaViaje), rutaRepository.Error);
            int idRuta = rutaRepository.Read.Max(r => r.IdRuta);

            cliente clienteViaje = CrearCliente();
            Assert.IsTrue(clienteRepository.Create(clienteViaje), clienteRepository.Error);
            int idCliente = clienteRepository.Read.Max(c => c.IdCliente);

            operador op = CrearOperador();
            Assert.IsTrue(operadorRepository.Create(op), operadorRepository.Error);
            int idOPerador = operadorRepository.Read.Max(o => o.IdOperador);


            viaje nuevoViaje = CrearViaje(idStatus,idRuta,idCliente,idOPerador);
            Assert.IsTrue(viajeRepository.Create(nuevoViaje), viajeRepository.Error);
            int idViajeNuevo = viajeRepository.Read.Max(vj => vj.IdViajeOps);

            viaje aMOdificar = viajeRepository.SearchById(idViajeNuevo.ToString());
            aMOdificar.IdViajeCliente = "VIAJEFAURECIA";
            Assert.IsTrue(viajeRepository.Update(aMOdificar), viajeRepository.Error);

            

            Assert.IsTrue(viajeRepository.Delete(idViajeNuevo.ToString()), viajeRepository.Error);
            Assert.IsTrue(operadorRepository.Delete(idOPerador.ToString()), operadorRepository.Error);
            Assert.IsTrue(clienteRepository.Delete(idCliente.ToString()), clienteRepository.Error);
            Assert.IsTrue(rutaRepository.Delete(idRuta.ToString()), rutaRepository.Error);
            Assert.IsTrue(unidadesRepository.Delete(idUnidad.ToString()), unidadesRepository.Error);
            Assert.IsTrue(statusRepository.Delete(idStatus.ToString()), statusRepository.Error);

        }

        [TestMethod]
        public void TestGasto()
        {
            statusviaje status = CrearStatus();
            Assert.IsTrue(statusRepository.Create(status), statusRepository.Error);
            int idStatus = statusRepository.Read.Max(s => s.IdStatus);

            unidades unidad = CrearUnidades();
            Assert.IsTrue(unidadesRepository.Create(unidad), unidadesRepository.Error);
            int idUnidad = unidadesRepository.Read.Max(u => u.IdUnidad);

            ruta rutaViaje = CrearRuta(idUnidad);
            Assert.IsTrue(rutaRepository.Create(rutaViaje), rutaRepository.Error);
            int idRuta = rutaRepository.Read.Max(r => r.IdRuta);

            cliente clienteViaje = CrearCliente();
            Assert.IsTrue(clienteRepository.Create(clienteViaje), clienteRepository.Error);
            int idCliente = clienteRepository.Read.Max(c => c.IdCliente);

            operador op = CrearOperador();
            Assert.IsTrue(operadorRepository.Create(op), operadorRepository.Error);
            int idOPerador = operadorRepository.Read.Max(o => o.IdOperador);


            viaje nuevoViaje = CrearViaje(idStatus, idRuta, idCliente, idOPerador);
            Assert.IsTrue(viajeRepository.Create(nuevoViaje), viajeRepository.Error);
            int idViajeNuevo = viajeRepository.Read.Max(vj => vj.IdViajeOps);

            tipogasto tipoGastoNuevo = CrearTipoGasto();
            Assert.IsTrue(tipoGastoRepository.Create(tipoGastoNuevo), tipoGastoRepository.Error);
            int idTipoGastoNuevo = tipoGastoRepository.Read.Max(tg => tg.IdTipoGasto);

            gasto nuevoGasto = CrearGasto(idTipoGastoNuevo,idViajeNuevo);
            Assert.IsTrue(gastoRepository.Create(nuevoGasto), gastoRepository.Error);
            int idGastoNuevo = gastoRepository.Read.Max(id => id.IdGasto);

            /*
            gasto aModificar = gastoRepository.SearchById(idGastoNuevo.ToString());
            aModificar.RutaPdf = @"C:\comprobante\gasto.xml";
            Assert.IsTrue(gastoRepository.Update(aModificar), gastoRepository.Error);

            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(gastoRepository.Create(CrearGasto(idTipoGastoNuevo, idViajeNuevo)), gastoRepository.Error);
            }


            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(cortesRepository.Create(CrearCorteOperador(idViajeNuevo)), cortesRepository.Error);
            }


            List<gasto> Gastos = gastoRepository.Read.ToList();

            foreach (var item in Gastos)
            {
                Assert.IsTrue(gastoRepository.Delete(item.IdGasto.ToString()), gastoRepository.Error);
            }

            List<cortesoperador> cortes = cortesRepository.Read.ToList();

            foreach (var item in cortes)
            {
                Assert.IsTrue(cortesRepository.Delete(item.IdCorte.ToString()), cortesRepository.Error);
            }



            Assert.IsTrue(tipoGastoRepository.Delete(idTipoGastoNuevo.ToString()), tipoGastoRepository.Error);
            Assert.IsTrue(viajeRepository.Delete(idViajeNuevo.ToString()), viajeRepository.Error);
            Assert.IsTrue(operadorRepository.Delete(idOPerador.ToString()), operadorRepository.Error);
            Assert.IsTrue(clienteRepository.Delete(idCliente.ToString()), clienteRepository.Error);
            Assert.IsTrue(rutaRepository.Delete(idRuta.ToString()), rutaRepository.Error);
            Assert.IsTrue(unidadesRepository.Delete(idUnidad.ToString()), unidadesRepository.Error);
            Assert.IsTrue(statusRepository.Delete(idStatus.ToString()), statusRepository.Error);

    */
        }

        private cortesoperador CrearCorteOperador(int idViajeNuevo)
        {
            return new cortesoperador
            {
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now,
                Costo = 568.23,
                IdViajeOps = idViajeNuevo
            };
        }

        private gasto CrearGasto(int idTipoGastoNuevo, int idViajeNuevo)
        {
            return new gasto {
                IdTipoGasto = idTipoGastoNuevo,
                Concepto = "Pago de Casetas",
                Costo = 150.65,
                RutaPdf = "",
                RutaXml = "",
                Fecha = DateTime.Now,
                IdViajeOps = idViajeNuevo
            };
        }

        private viaje CrearViaje(int idStatus, int idRuta, int idCliente, int idOPerador)
        {
            return new viaje
            {
                IdViajeCliente = "axadad",
                FechaInicioOps = DateTime.Now,
                FechaInicioCliente = DateTime.Now,
                FechaFinOps = DateTime.Now,
                FechaFinCliente = DateTime.Now,
                IdStatus = idStatus,
                IdRuta = idRuta,
                IdCliente = idCliente,
                IdOperador = idOPerador
            };
        }

        private ruta CrearRuta(int idUnidadNueva)
        {
            return new ruta
            {
                Nombre = "Nombre de la ruta nueva",
                Costo = 1600,
                IdUnidad = idUnidadNueva
            };
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
