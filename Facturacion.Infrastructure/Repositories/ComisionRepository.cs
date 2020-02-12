using Facturacion.Domain.Aggregates.ComisionAggregate;
using Facturacion.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infrastructure.Repositories
{
    public class ComisionRepository : IComisionRepository
    {

        private readonly FacturacionContext _context;
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Comision Add(Comision Comisiones)
        {
            if (Comisiones.IsTransient())
            {
                return _context.Comisiones
                    .Add(Comisiones)
                    .Entity;
            }
            else
            {
                return Comisiones;
            }
        }

        public Comision Delete(Comision comision)
        {
            throw new NotImplementedException();
        }

        public Task<Comision> FindAsync(string ComisionIdentityId)
        {
            throw new NotImplementedException();
        }

        public Comision Update(Comision comision)
        {
            throw new NotImplementedException();
        }
    }
}
