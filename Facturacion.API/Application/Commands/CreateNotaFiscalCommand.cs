using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Commands
{
    [DataContract]
    public class CreateNotaFiscalCommand : IRequest<bool>
    {
        [DataMember]
        public DateTime? DateEnvio { get; set; }
        [DataMember]
        public string Empresa { get; set; }
        [DataMember]
        public string NroNota { get; set; }
        [DataMember]
        public DateTime? DateRechazo { get; set; }
        [DataMember]
        public DateTime? DatePago { get; set; }
        [DataMember]
        public float Valor { get; set; }
        
        public CreateNotaFiscalCommand (DateTime? dateEnvio, string empresa, string nroNota, DateTime? dateRechazo,
            DateTime? datePago, float valor)
        {
            this.DateEnvio = dateEnvio;
            this.Empresa = empresa;
            this.NroNota = nroNota;
            this.DateRechazo = dateRechazo;
            this.DatePago = datePago;
            this.Valor = valor;
        }

    }
}
