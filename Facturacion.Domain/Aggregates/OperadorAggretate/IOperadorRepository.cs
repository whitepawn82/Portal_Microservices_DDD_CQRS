using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.OperadorAggretate
{
    public interface IOperadorRepository : IRepository<Operador>
    {
        Operador Add(Operador operador);
    }
}
