using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate.Agencias
{
    public class Agencia : Entity, IAggregateRoot
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public string Telefono { get; set; }
        public string Banco { get; set; }
        //public string Agencia { get; set; } Campo reemplazado por nombre
        public string nombre { get; set; }
        public int Cuenta { get; set; }
    }
}
