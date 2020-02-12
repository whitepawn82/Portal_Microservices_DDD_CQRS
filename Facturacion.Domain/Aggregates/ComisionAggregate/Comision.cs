using Facturacion.Domain.SeedWork;
using Facturacion.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Domain.Aggregates.ComisionAggregate
{
    public class Comision : Entity, IAggregateRoot
    {
        public int Id { get; private set; }
        public int? Numero { get; set; }
        public DateTime? DateEmision { get; set; }
        public DateTime? DatePago { get; set; }
        public string Pax { get; set; }
        public int? Facturacion { get; set; }
        public int? Porcentaje { get; set; }
        public int? Valor { get; set; }
        public string Tipo { get; set; }
        public string Voucher { get; set; }
        public string Agencia { get; set; }
        public int? Orden { get; set; }

        //public ComisionStatus ComisionStatus { get; set; }

        //private List<ComisionStatus> _status;
        //internal StatusValue GetStatus(string status)
        //{
        //    return this._status.Single(x => x.Status.Status == status).Status;
        //}

    }
}
