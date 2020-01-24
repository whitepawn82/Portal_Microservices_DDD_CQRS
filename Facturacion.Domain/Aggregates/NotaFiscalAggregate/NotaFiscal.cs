using Facturacion.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Domain.Aggregates.FacturaAggregate
{
    public class NotaFiscal
    {
        public int Id { get; private set; }
        public DateTime? DataEnvio { get; set; }
        public string Empresa { get; set; }
        public string NroNota { get; set; }
        public DateTime? DataRechazo { get; set; }
        public DateTime? DataPago { get; set; }
        public float Valor { get; set; }
        //public NotaFiscalStatus FacturaStatus { get; set; }

        private List<NotaFiscalStatus> _status;
        internal StatusValue GetStatus(string status)
        {
            return this._status.Single(x => x.Status.Status == status).Status;
        }

    }
}
