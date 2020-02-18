using Facturacion.Domain.Aggregates.ComisionAggregate;
using Facturacion.Domain.Aggregates.ComisionAggregate.Agencias;
using Facturacion.Domain.Aggregates.ComisionAggregate.Proveedores;
using Facturacion.Domain.Aggregates.NotaFiscalAggregate;
using Facturacion.Domain.Aggregates.OperadorAggretate;
using Facturacion.Domain.SeedWork;
using Facturacion.Infrastructure.EntityConfigurations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Facturacion.Infrastructure
{
    public class FacturacionContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "facturacion";
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<NotaFiscal> NotasFiscales { get; set; }
        public DbSet<Operador> Users { get; set; }



        private readonly IMediator _mediator;
        private IDbContextTransaction _currentTransaction;

        public FacturacionContext(DbContextOptions<FacturacionContext> options) : base(options) { }

        public IDbContextTransaction GetCurrentTransaction() => _currentTransaction;

        public bool HasActiveTransaction => _currentTransaction != null;

        public FacturacionContext(DbContextOptions<FacturacionContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

            System.Diagnostics.Debug.WriteLine("FacturacionContext::ctor ->" + this.GetHashCode());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgenciaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ComisionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new NotaFiscalEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProveedorEntityTypeConfiguration());
        }


        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            // SIN MODIFICAR
            await _mediator.DispatchDomainEventsAsync(this);

            // After executing this line all the changes (from the Command Handler and Domain Event Handlers) 
            // performed through the DbContext will be committed
            var result = await base.SaveChangesAsync(cancellationToken);

            return true;
        }

    }

    public class FacturacionContextDesignFactory : IDesignTimeDbContextFactory<FacturacionContext>
    {
        public FacturacionContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FacturacionContext>()
                .UseSqlServer("Server=172.17.0.2;Initial Catalog=dbPortal02;User ID=sa;Password=P@ssw0rd;", b => b.MigrationsAssembly("Facturacion.API"));

            return new FacturacionContext(optionsBuilder.Options, new NoMediator());
        }

        class NoMediator : IMediator
        {
            public Task Publish(object notification, CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }

            public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
            {
                throw new NotImplementedException();
            }

            public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }

            public Task<object> Send(object request, CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }
        }

    }
}
