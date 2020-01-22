using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using SCI.COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class FabricManager
    {
        public IUsuarioManager UsuarioManager()
        {
            return new UsuarioManager(new DAL.GenericRepository<usuario>(new UsuarioValidator(), false));
        }

        public IClienteManager ClienteManager()
        {
            return new ClienteManager(new DAL.GenericRepository<cliente>(new ClienteValidator(),false));
        }

        public ICortesOperadorManager CortesOperadorManager()
        {
            return new CortesOperadorManager(new DAL.GenericRepository<cortesoperador>(new CortesOperadorValidator(), false));
        }

        public IGastoManager GastoManager()
        {
            return new GastoManager(new DAL.GenericRepository<gasto>(new GastoValidator(), false));
        }

        public ILogManager LogManager()
        {
            return new LogManager(new DAL.GenericRepository<log>(new LogValidator(), false));
        }
        public IOperadorManager OperadorManager()
        {
            return new OperadorManager(new DAL.GenericRepository<operador>(new OperadorValidator(), false));
        }

        public IRutaManager RutaManager()
        {
            return new RutaManager(new DAL.GenericRepository<ruta>(new RutaValidator(), false));
        }

        public IStatusViajeManager StatusViajeManager()
        {
            return new StatusViajeManager(new DAL.GenericRepository<statusviaje>(new StatusViajeValidator(), false));
        }

        public ITipoDeGastoManager TipoDeGastoManager()
        {
            return new TipoGastoManager(new DAL.GenericRepository<tipogasto>(new TipoDeGastoValidator(), false));
        }

        public IUnidadesManager UnidadManager()
        {
            return new UnidadesManager(new DAL.GenericRepository<unidades>(new UnidadesValidator(), false));
        }

        public IViajeManager ViajeManager()
        {
            return new ViajeManager(new DAL.GenericRepository<viaje>(new ViajeValidator(), false));
        }

    }
}
