using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
{
    public class Agencia
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public string Telefono { get; set; }
        public string Banco { get; set; }
        //public string Agencia { get; set; } Campo reemplazado por nombre
        public string nombre { get; set; }
        public int Cuenta { get; set; }
    }
}
