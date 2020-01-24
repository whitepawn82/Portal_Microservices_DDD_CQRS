using Facturacion.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.FacturaAggregate
{
    public class NotaFiscalStatus
    {
        public int Id { get; set; }

        public StatusValue Status { get; private set; }

        private NotaFiscalStatus()
        {

        }
    }
}
