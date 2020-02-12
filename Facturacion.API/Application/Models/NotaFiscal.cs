using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Models
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public DateTime? DateEnvio { get; set; }
        public string Empresa { get; set; }
        public string NroNota { get; set; }
        public DateTime? DateRechazo { get; set; }
        public DateTime? DatePago { get; set; }
        public float Valor { get; set; }
        public string Detalle { get; set; }
        public NotaFiscal(int notafiscalId, DateTime dateEnvio, string empresa, string nroNota, DateTime dateRechazo, 
            DateTime datePago, float valor, string detalle)
        {
            Id = notafiscalId;
            DateEnvio = dateEnvio;
            Empresa = empresa;
            NroNota = nroNota;
            DateRechazo = dateRechazo;
            DatePago = datePago;
            Valor = valor;
            Detalle = detalle;
        }
    }
}
