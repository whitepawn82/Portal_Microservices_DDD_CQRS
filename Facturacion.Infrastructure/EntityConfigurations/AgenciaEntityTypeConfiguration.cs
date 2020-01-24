using Facturacion.Domain.Aggregates.ComisionAggregate.Agencias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.EntityConfigurations
{
    class AgenciaEntityTypeConfiguration : IEntityTypeConfiguration<Agencia>
    {
        public void Configure(EntityTypeBuilder<Agencia> builder)
        {
            throw new NotImplementedException();
        }
    }
}
