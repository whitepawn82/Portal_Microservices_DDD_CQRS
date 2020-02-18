using Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Infrastructure.EntityConfigurations
{
    class ProveedorEntityTypeConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> proveedorConfiguration)
        {
            proveedorConfiguration.ToTable("Proveedores", FacturacionContext.DEFAULT_SCHEMA);

            proveedorConfiguration.HasKey(p => p.ProveedorId);

            proveedorConfiguration.Property(p => p.ProveedorId).HasColumnName("ProveedorId").ValueGeneratedOnAdd();
            proveedorConfiguration.Property(p => p.Name).HasMaxLength(50).IsRequired(); ;
        }
    }
}
