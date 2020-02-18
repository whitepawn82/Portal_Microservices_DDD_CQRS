using Facturacion.Domain.Aggregates.NotaFiscalAggregate;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        private readonly FacturacionContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public NotaFiscal Add(NotaFiscal notafiscal)
        {
            throw new NotImplementedException();
        }
    }
}
