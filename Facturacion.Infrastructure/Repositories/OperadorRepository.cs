using Facturacion.Domain.Aggregates.OperadorAggretate;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class OperadorRepository : IOperadorRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Operador Add(Operador operador)
        {
            throw new NotImplementedException();
        }
    }
}
