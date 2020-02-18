using Facturacion.Domain.Aggregates.OperadorAggretate;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class OperadorRepository : IOperadorRepository
    {
        private readonly FacturacionContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public Operador Add(Operador operador)
        {
            throw new NotImplementedException();
        }
    }
}
