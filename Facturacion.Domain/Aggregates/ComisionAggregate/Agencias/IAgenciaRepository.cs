using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.ComisionAggregate.Agencias
{
    public interface IAgenciaRepository : IRepository<Agencia>
    {
        Agencia Add(Agencia agencia);
    }
}
