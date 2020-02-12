using Facturacion.Domain.SeedWork;
using Facturacion.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Domain.Aggregates.NotaFiscalAggregate
{
    public class NotaFiscal : Entity, IAggregateRoot
    {
        private DateTime? DateEnvio;
        private DateTime? DateRechazo;
        private DateTime? DatePago;

        public int Id { get; private set; }
        //public DateTime? DateEnvio { get; set; }
        public string Empresa { get; set; }
        public string NroNota { get; set; }
        //public DateTime? DateRechazo { get; set; }
        //public DateTime? DatePago { get; set; }
        public float Valor { get; set; }
        //public NotaFiscalStatus FacturaStatus { get; set; }

        //private List<NotaFiscalStatus> _status;
        //internal StatusValue GetStatus(string status)
        //{
        //    return this._status.Single(x => x.Status.Status == status).Status;
        //}


        public NotaFiscal(DateTime? dateEnvio, string empresa, string nroNota, DateTime? dateRechazo, DateTime? datePago, float valor)
        {
            DateEnvio = dateEnvio;
            Empresa = empresa;
            NroNota = nroNota;
            DateRechazo = dateRechazo;
            DatePago = datePago;
            Valor = valor;
        }
    }
}
