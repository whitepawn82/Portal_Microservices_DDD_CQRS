using Facturacion.Domain.SeedWork;
using Facturacion.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Domain.Aggregates.ComisionAggregate
{
    public class Comision : Entity, IAggregateRoot
    {
        public int ComisionId { get; set; }
        public int StatusId { get; set; }
        public int NotaFiscalId { get; set; }
        public int Numero { get; set; }
        public DateTime DateEmision { get; set; }
        public DateTime DatePago { get; set; }
        public string Pax { get; set; }
        public int Facturacion { get; set; }
        public decimal Porcentaje { get; set; }
        public float Valor { get; set; }
        public string Tipo { get; set; }
        public string Voucher { get; set; }
        public string Agencia { get; set; }
        public int Orden { get; set; }

        public Comision(int comisionId, int statusId, int notaFiscald, int numero, DateTime dateEmision, DateTime datePago, string pax, 
            int facturacion, decimal porcentaje, float valor, string tipo, string voucher, string agencia, int orden ) : this()
        {
            ComisionId = comisionId;
            StatusId = statusId;
            NotaFiscalId = notaFiscald;
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

        public Comision()
        {
        }

        public Comision(int statusId, int notaFiscald, int numero, DateTime dateEmision, DateTime datePago, string pax,
            int facturacion, decimal porcentaje, float valor, string tipo, string voucher, string agencia, int orden) : this()
        {
            StatusId = statusId;
            NotaFiscalId = notaFiscald;
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

        //public ComisionStatus ComisionStatus { get; set; }

        //private List<ComisionStatus> _status;
        //internal StatusValue GetStatus(string status)
        //{
        //    return this._status.Single(x => x.Status.Status == status).Status;
        //}

    }
}
