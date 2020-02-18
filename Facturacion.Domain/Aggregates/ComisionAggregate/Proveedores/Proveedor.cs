using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores
{
    public class Proveedor : Entity, IAggregateRoot
    {

        public int ProveedorId { get; set; }
        public string Name { get; set; }

        public Proveedor(int id, string name) : this()
        {
            ProveedorId = id;
            Name = name;
        }

        public Proveedor()
        {
        }
    }

}
