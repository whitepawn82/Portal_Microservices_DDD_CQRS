using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
{
    public class NotaFiscal { 
        public int Id { get; private set; }
        public DateTime? DateEnvio { get; set; }
        public string Empresa { get; set; }
        public string NroNota { get; set; }
        public DateTime? DateRechazo { get; set; }
        public DateTime? DatePago { get; set; }
        public float Valor { get; set; }
        public int Status { get; set; }
    }
}
