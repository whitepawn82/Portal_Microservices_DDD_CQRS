using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate.Agencias
{
    public class Agencia : Entity, IAggregateRoot
    {
        public int AgenciaId { get; set; }
        public int ProveedorId { get; set; }
        public string Telefono { get; set; }
        public string Banco { get; set; }
        //public string Agencia { get; set; } Campo reemplazado por nombre
        public string Nombre { get; set; }
        public int Cuenta { get; set; }

        public Agencia(int id, int proveedorId, string telefono, string banco, string nombre, int cuenta) : this()
        {
            AgenciaId = id;
            ProveedorId = proveedorId;
            Telefono = telefono;
            Banco = banco;
            Nombre = nombre;
            Cuenta = cuenta;
        }

        public Agencia()
        {
        }
    }
}
