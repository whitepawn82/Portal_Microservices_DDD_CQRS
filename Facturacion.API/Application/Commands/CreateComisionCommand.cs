using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Commands
{
    [DataContract]
    public class CreateComisionCommand : IRequest<bool>
    {
        [DataMember]
        public int StatusId { get; set; }

        [DataMember]
        public int NotaFiscalId { get; set; }

        [DataMember]
        public int Numero { get; set; }

        [DataMember]
        public DateTime DateEmision { get; set; }

        [DataMember]
        public DateTime DatePago { get; set; }

        [DataMember]
        public string Pax { get; set; }

        [DataMember]
        public int Facturacion { get; set; }

        [DataMember]
        public decimal Porcentaje { get; set; }

        [DataMember]
        public float Valor { get; set; }

        [DataMember]
        public string Tipo { get; set; }

        [DataMember]
        public string Voucher { get; set; }

        [DataMember]
        public string Agencia { get; set; }

        [DataMember]
        public int Orden { get; set; }


        public CreateComisionCommand(int statusId, int notaFiscalId, int numero, DateTime dateEmision, DateTime datePago, 
            string pax, int facturacion, decimal porcentaje, float valor, string tipo, string voucher, string agencia, int orden)
        {
            StatusId = statusId;
            NotaFiscalId = notaFiscalId;
            Numero = numero;
            DateEmision = dateEmision;
            DatePago = datePago;
            Pax = pax;
            Facturacion = facturacion;
            Porcentaje = porcentaje;
            Valor = valor;
            Tipo = tipo;
            Voucher = voucher;
            Agencia = agencia;
            Orden = orden;
        }
    }
}
