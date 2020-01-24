using Facturacion.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate
{
    public class ComisionStatus
    {
        public int Id { get; set; }

        public StatusValue Status { get; private set; }

        private ComisionStatus()
        {

        }
    }
}
