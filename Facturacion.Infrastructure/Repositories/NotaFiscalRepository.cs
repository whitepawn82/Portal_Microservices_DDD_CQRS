using Facturacion.Domain.Aggregates.NotaFiscalAggregate;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public NotaFiscal Add(NotaFiscal notafiscal)
        {
            throw new NotImplementedException();
        }
    }
}
