using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Models
{
    public class Comision
    {
        public int Id { get; private set; }
        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public string Pax { get; set; }
        public string Voucher { get; set; }
        public string Agencia { get; set; }
        public int Facturacion { get; set; }
        public decimal Porcentaje { get; set; }
        public int StatusId { get; set; }
        public int Valor { get; set; }
        public string Tipo { get; set; }
        //public ComisionVoucher Detalle { get; set; }

        public Comision (int comisionId, int numero, string pax, string voucher, string agencia, int facturacion, 
            decimal porcentaje, int statusId, int valor, string tipo)
        {
            Id = comisionId;
            Numero = numero;
            Pax = pax;
            Voucher = voucher;
            Agencia = agencia;
            Facturacion = facturacion;
            Porcentaje = porcentaje;
            StatusId = statusId;
            Valor = valor;
            Tipo = tipo;
            //Detalle = detalle;

        }

    }
}
