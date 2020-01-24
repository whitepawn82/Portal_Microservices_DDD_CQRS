using Facturacion.Domain.Aggregates.ComisionAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.EntityConfigurations
{
    class ComisionEntityTypeConfiguration : IEntityTypeConfiguration<Comision>
    {
        public void Configure(EntityTypeBuilder<Comision> comisionConfiguration)
        {
            comisionConfiguration.ToTable("comisions", FacturacionContext.DEFAULT_SCHEMA);

            comisionConfiguration.HasKey(b => b.Id);

            comisionConfiguration.Property(b => b.Numero);
        }
    }
}
