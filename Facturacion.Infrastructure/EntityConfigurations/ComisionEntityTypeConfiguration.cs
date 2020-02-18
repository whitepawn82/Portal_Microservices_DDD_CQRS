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
            comisionConfiguration.ToTable("Comisiones", FacturacionContext.DEFAULT_SCHEMA);
            comisionConfiguration.HasKey(c => c.ComisionId);

            comisionConfiguration.Property(c => c.ComisionId).HasColumnName("ComisionId").ValueGeneratedOnAdd();

            //comisionConfiguration.Property(c => c.NotaFiscalId).HasColumnName("NotaFiscalId").HasColumnType("integer").HasMaxLength(50).IsRequired();

            comisionConfiguration.Property(c => c.Tipo).HasColumnName("Tipo").HasMaxLength(100).IsRequired();

            comisionConfiguration.Property(c => c.Voucher).HasColumnName("Voucher").HasMaxLength(50).IsRequired();
            comisionConfiguration.Property(c => c.Agencia).HasColumnName("Agencia").HasMaxLength(150).IsRequired();


        }
    }
}
