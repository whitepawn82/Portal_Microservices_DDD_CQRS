using Facturacion.Domain.Aggregates.NotaFiscalAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.EntityConfigurations
{
    class NotaFiscalEntityTypeConfiguration : IEntityTypeConfiguration<NotaFiscal>
    {
        public void Configure(EntityTypeBuilder<NotaFiscal> notafiscalConfiguration)
        {
            notafiscalConfiguration.ToTable("NotasFiscales", FacturacionContext.DEFAULT_SCHEMA);
            notafiscalConfiguration.HasKey(n => n.NotaFiscalId);

            notafiscalConfiguration.Property(n => n.NotaFiscalId).HasColumnName("NotaFiscalId").ValueGeneratedOnAdd();
        }
    }
}
