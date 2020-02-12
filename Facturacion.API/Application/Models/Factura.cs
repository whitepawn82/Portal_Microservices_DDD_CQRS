using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Models
{
    public class Factura
    {
        public int NotafiscalId { get; set; }
        public int Agencia { get; set; }
        public DateTime? DateEnvio { get; set; }
        public int NroFactura { get; set; }
        public DateTime? DateVencimiento { get; set; }
        public float Valor { get; set; }
        public int Boleto { get; set; }

        public List<FacturaItem> Items { get; set; } = new List<FacturaItem>();

        public Factura(int notafiscalId, int agencia, DateTime dataEnvio, int nroFactura, DateTime dateVencimiento, float valor, int boleto)
        {
            NotafiscalId = notafiscalId;
            Agencia = agencia;
            DateEnvio = dataEnvio;
            NroFactura = nroFactura;
            DateVencimiento = dateVencimiento;
            Valor = valor;
            Boleto = boleto;
            Items = new List<FacturaItem>();
        }

    }
}
