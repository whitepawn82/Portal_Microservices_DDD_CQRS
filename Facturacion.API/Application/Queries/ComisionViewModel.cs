using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
{
    public class Comision
    {
        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public string Pax { get; set; }
        public string Voucher { get; set; }
        public string Agencia { get; set; }
        public int Facturacion { get; set; }
        public decimal Porcentaje { get; set; }
        public int StatusId { get; set; }
        public float Valor { get; set; }
        public string Tipo { get; set; }

    }
}
