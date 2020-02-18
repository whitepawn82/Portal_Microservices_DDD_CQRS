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
        public void Configure(EntityTypeBuilder<Agencia> agenciaConfiguration)
        {
            agenciaConfiguration.ToTable("Agencias", FacturacionContext.DEFAULT_SCHEMA);
            agenciaConfiguration.HasKey(a => a.AgenciaId);

            agenciaConfiguration.Property(a => a.AgenciaId).HasColumnName("AgenciaId").ValueGeneratedOnAdd();

            //agenciaConfiguration.Property(a => a.ProveedorId).HasColumnName("ProveedorId").HasColumnType("integer").HasMaxLength(50).IsRequired();
            //agenciaConfiguration.Property(a => a.Telefono).HasColumnName("Telefono").HasMaxLength(100).IsRequired();
            //agenciaConfiguration.Property(a => a.Banco).HasColumnName("Banco").HasMaxLength(100).IsRequired();
            //agenciaConfiguration.Property(a => a.Nombre).HasColumnName("Nombre").HasMaxLength(100).IsRequired();
            //agenciaConfiguration.Property(a => a.Cuenta).HasColumnName("Cuenta").HasMaxLength(100).IsRequired();

        }
    }
}
