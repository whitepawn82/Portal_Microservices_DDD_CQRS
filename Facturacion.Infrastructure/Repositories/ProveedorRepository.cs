
using Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly FacturacionContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public Proveedor Add(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
    }
}
