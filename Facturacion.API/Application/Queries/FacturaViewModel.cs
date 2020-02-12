using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
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
    }

}
