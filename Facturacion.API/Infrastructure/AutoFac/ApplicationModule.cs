using Autofac;
using Facturacion.API.Application.Queries;
using Facturacion.Domain.Aggregates.ComisionAggregate;
using Facturacion.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Infrastructure.AutoFac
{
    public class ApplicationModule
    : Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(Autofac.ContainerBuilder builder)
        {

            builder.Register(c => new ComisionQueries(QueriesConnectionString))
                .As<IComisionQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ComisionRepository>()
                .As<IComisionRepository>()
                .InstancePerLifetimeScope();

            //builder.RegisterType<RequestManager>()
            //   .As<IRequestManager>()
            //   .InstancePerLifetimeScope();

            //builder.RegisterAssemblyTypes(typeof(CreateOrderCommandHandler).GetTypeInfo().Assembly)
            //    .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

        }
    }
}
