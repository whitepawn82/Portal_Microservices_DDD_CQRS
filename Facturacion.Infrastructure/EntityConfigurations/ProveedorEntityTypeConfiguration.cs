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
            proveedorConfiguration.ToTable("proveedores", FacturacionContext.DEFAULT_SCHEMA);

            proveedorConfiguration.HasKey(b => b.Id);

            proveedorConfiguration.Property(b => b.Name);
        }
    }
}
