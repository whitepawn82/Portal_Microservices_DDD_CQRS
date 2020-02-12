using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Models
{
    public class ComisionVoucher
    {
        public int Id { get; set; }
        public int ComisionId { get; set; }
        public string Voucher { get; set; }
        public string Agencia { get; set; }
        public string Pax { get; set; }
        public DateTime? DateEmision { get; set; }
        public DateTime? DatePago { get; set; }
        public int NotaCredito { get; set; }
        public int? Facturacion { get; set; }
        public decimal? PorcentajeComision { get; set; }
        public decimal? PorcentajeMarkup { get; set; }
        public string Tipo { get; set; }
    }
}
