using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using SCI.COMMON.Validadores;
using SCI.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class FabricManager
    {
        public ICobroAdicionalManager CobrosAdicionalManager()
        {
            return new CobrosAdicionalesManager(new GenericRepository<cobrosadicionales>(new CobrosAdicionalesValidator()));
        }

        public IDepositoManager DepositoManager()
        {
            return new DepositoManger(new GenericRepository<deposito>(new DepositoValidator()));
        }

        public IOperadoresEnViajeManager OperadoresEnViajeManager()
        {
            return new OperadoresEnViajeManager(new GenericRepository<operadoresenviaje>(new OperadoresEnViajeValidator()));
        }

        public IGasolineriaManager GasolineriaManager()
        {
            return new GasolineriaManager(new GenericRepository<gasolineria>(new GasolineriaValidator()));
        }

        public ICasetaManager CasetaManager()
        {
            return new CasetaManager(new GenericRepository<caseta>(new CasetaValidator()));
        }

        public ITipoDeUnidadManager TipoDeUnidadesManager()
        {
            return new TipoDeUnidadManager(new GenericRepository<tipounidad>(new TipoDeUnidadValidator()));
        }

        public IUnidadesManager UnidadManager()
        {
            return new UnidadesManager(new GenericRepository<unidades>(new UnidadesValidator()));
        }

        public IUsuarioManager UsuarioManager()
        {
            return new UsuarioManager(new DAL.GenericRepository<usuario>(new UsuarioValidator()));
        }

        public IClienteManager ClienteManager()
        {
            return new ClienteManager(new DAL.GenericRepository<cliente>(new ClienteValidator()));
        }

        public ICortesOperadorManager CortesOperadorManager()
        {
            return new CortesOperadorManager(new DAL.GenericRepository<cortesoperador>(new CortesOperadorValidator()));
        }

        public IGastoManager GastoManager()
        {
            return new GastoManager(new DAL.GenericRepository<gasto>(new GastoValidator()));
        }

        public ILogManager LogManager()
        {
            return new LogManager(new DAL.GenericRepository<log>(new LogValidator()));
        }
        public IOperadorManager OperadorManager()
        {
            return new OperadorManager(new DAL.GenericRepository<operador>(new OperadorValidator()));
        }

        public IRutaManager RutaManager()
        {
            return new RutaManager(new DAL.GenericRepository<ruta>(new RutaValidator()));
        }

        public IStatusViajeManager StatusViajeManager()
        {
            return new StatusViajeManager(new DAL.GenericRepository<statusviaje>(new StatusViajeValidator()));
        }

        public ITipoDeGastoManager TipoDeGastoManager()
        {
            return new TipoGastoManager(new DAL.GenericRepository<tipogasto>(new TipoDeGastoValidator()));
        }

        

        public IViajeManager ViajeManager()
        {
            return new ViajeManager(new DAL.GenericRepository<viaje>(new ViajeValidator(), false));
        }

    }
}
