using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.BIZ
{
    public class UnidadesManager : GenericManager<unidades>, IUnidadesManager
    {
        public UnidadesManager(IGenericRepository<unidades> repositorio) : base(repositorio)
        {
        }

        public unidades BuscarPorNumEco(int numero)
        {
            return repository.Query(u => u.NumeroEconomico == numero).SingleOrDefault();
        }

        public IEnumerable<unidades> BuscaUnidadesPorTipoCombustible(string tipoCombustible)
        {
            return repository.Query(u => u.TipoCombustible == tipoCombustible);
        }
    }
}
