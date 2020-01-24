using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        Proveedor Add(Proveedor proveedor);
    }
}
