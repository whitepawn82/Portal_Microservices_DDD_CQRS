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
        public int NotaFiscalId { get; set; }
        [DataMember]
        public DateTime DateEnvio { get; set; }
        [DataMember]
        public string Empresa { get; set; }
        [DataMember]
        public string NroNota { get; set; }
        [DataMember]
        public DateTime DateRechazo { get; set; }
        [DataMember]
        public DateTime DatePago { get; set; }
        [DataMember]
        public float Valor { get; set; }
        
        public CreateNotaFiscalCommand (int notaFiscalId, DateTime dateEnvio, string empresa, string nroNota, DateTime dateRechazo,
            DateTime datePago, float valor)
        {
            NotaFiscalId = notaFiscalId;
            DateEnvio = dateEnvio;
            Empresa = empresa;
            NroNota = nroNota;
            DateRechazo = dateRechazo;
            DatePago = datePago;
            Valor = valor;
        }

    }
}
