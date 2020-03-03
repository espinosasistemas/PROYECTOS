using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.BIZ
{
    public class CobrosAdicionalesManager : GenericManager<cobrosadicionales>, ICobroAdicionalManager
    {
        public CobrosAdicionalesManager(IGenericRepository<cobrosadicionales> repositorio) : base(repositorio)
        {
        }

        public IEnumerable<cobrosadicionales> BuscarCobrosPorViaje(int idViajeSci)
        {
            return repository.Query(c => c.IdViajeSci == idViajeSci);
        }
    }
}
