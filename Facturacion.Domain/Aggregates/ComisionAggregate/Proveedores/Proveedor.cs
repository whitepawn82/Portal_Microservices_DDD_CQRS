using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores
{
    public class Proveedor : Entity, IAggregateRoot
    {
        public object Id { get; set; }
        public object Name { get; set; }
    }
}
