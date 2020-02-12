using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.Aggregates.NotaFiscalAggregate
{
    public interface INotaFiscalRepository : IRepository<NotaFiscal>
    {
        NotaFiscal Add(NotaFiscal notafiscal);

    }
}
