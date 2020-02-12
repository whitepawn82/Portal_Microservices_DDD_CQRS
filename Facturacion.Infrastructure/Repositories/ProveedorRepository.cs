
using Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Proveedor Add(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
    }
}
