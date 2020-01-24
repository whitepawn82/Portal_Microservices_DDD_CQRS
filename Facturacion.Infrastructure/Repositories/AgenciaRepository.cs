using Facturacion.Domain.Aggregates.ComisionAggregate.Agencias;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class AgenciaRepository : IAgenciaRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Agencia Add(Agencia agencia)
        {
            throw new NotImplementedException();
        }
    }
}
